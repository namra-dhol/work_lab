const express=require('express')
const app=express()
app.use('/',(req,res,next)=>{
    console.log('msg')
    next()
})
app.all('/',(req,res)=>{
    res.send('Hello World')
})
app.listen(3000,()=>{
    console.log('server is running on port 3000')
})