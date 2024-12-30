// const http =require('http')

// let server = http.createServer((req,res)=>{
//     res.write("hello world")
//     res.end();
// })
// server.listen(5612,()=>{
//     console.log("server is running on port 3000");
// })
const fs=require('fs')
fs.stat('hello.js',(err,data)=>{
    console.log(data)
})