# Maximize PowerShell window
Add-Type -AssemblyName System.Windows.Forms

# Change background to white and text to black
$Host.UI.RawUI.BackgroundColor = "White"
$Host.UI.RawUI.ForegroundColor = "Black"
Clear-Host

# Add custom C# class for window maximization
Add-Type @"
using System;
using System.Runtime.InteropServices;
public class Win {
    [DllImport("user32.dll")] public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
}
"@
$hwnd = (Get-Process -Id $PID).MainWindowHandle
[Win]::ShowWindow($hwnd, 3) | Out-Null

# Prepare output folder
$timestamp = Get-Date -Format "yyyy-MM-dd_HH-mm-ss"
$outDir = "$env:USERPROFILE\Desktop\net_checks_$timestamp"
New-Item -ItemType Directory -Path $outDir | Out-Null

# Screenshot function
Add-Type -AssemblyName System.Drawing
function Take-Screenshot($name) {
    $bounds = [System.Windows.Forms.Screen]::PrimaryScreen.Bounds
    $bmp = New-Object System.Drawing.Bitmap $bounds.Width, $bounds.Height
    $graphics = [System.Drawing.Graphics]::FromImage($bmp)
    $graphics.CopyFromScreen($bounds.Location, [System.Drawing.Point]::Empty, $bounds.Size)
    $filePath = Join-Path $outDir "$name.png"
    $bmp.Save($filePath, [System.Drawing.Imaging.ImageFormat]::Png)
    $graphics.Dispose()
    $bmp.Dispose()
}

# Fake typing function
function Type-Command($cmd) {
    foreach ($char in $cmd.ToCharArray()) {
        Write-Host -NoNewline $char -ForegroundColor Black
        Start-Sleep -Milliseconds (Get-Random -Minimum 20 -Maximum 60)
    }
    Write-Host ""
}

# Commands to run
$commands = @(
    'ipconfig',
    'ipconfig /all',
    'ipconfig /flushdns',
    'ping -n 2 google.com',
    'ping -l 1500 google.com',
    'ping -4 google.com',
    'ping -6 google.com',
    'getmac',
    'getmac /v',
    'getmac /fo list',
    'getmac /fo csv',
    'wmic nic get MACAddress,NetConnectionID',
    'systeminfo',
    'systeminfo | findstr /B /C:"Host Name" /C:"OS Name"',
    'wmic os get Caption,Version,OSArchitecture',
    'wmic computersystem get Name,Manufacturer,Model',
    'ver',
    'tracert -h 5 google.com',
    'tracert -d -h 5 google.com',
    'tracert -4 -h 5 google.com',
    'tracert -6 -h 5 google.com',
    'netstat',
    'netstat -an',
    'netstat -ano',
    'netstat -r',
    'netstat -e',
    'nslookup google.com',
    'nslookup -type=mx gmail.com',
    'nslookup google.com 8.8.8.8',
    'nslookup -type=ptr 8.8.8.8',
    'cmd /c "(echo set debug & echo google.com & echo exit) | nslookup"',
    'hostname',
    'wmic computersystem get name',
    'systeminfo | findstr /B /C:"Host Name"',
    'powershell -Command "$env:COMPUTERNAME"',
    'pathping -q 1 -h 5 google.com',
    'arp -a',
    'arp -g',
    'netsh interface ip show neighbors',
    'whoami',
    'set',
    'time /t',
    'date /t'
)

# Run each command
$count = 1
foreach ($cmd in $commands) {
    Clear-Host
    Write-Host "C:\Windows\System32>" -NoNewline -ForegroundColor Green
    Type-Command $cmd
    cmd /c $cmd
    Take-Screenshot ("{0:D2}_{1}" -f $count, ($cmd -replace '[\\\/\:\*\?\"<>\| ]','_'))
    Start-Sleep -Milliseconds (Get-Random -Minimum 500 -Maximum 1500)
    $count++
}

Write-Host "`nAll screenshots saved to: $outDir"
Pause
