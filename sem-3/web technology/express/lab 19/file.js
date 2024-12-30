const express=require('express')
const fs=require('fs')
const data=fs.readFileSync('abc.txt')
const app=express()
app.get('/',(req,res)=>{
    res.send(data.toString())
})
app.listen(3000,()=>{
    console.log('server is running on port 3000')
})