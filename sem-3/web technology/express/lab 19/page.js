const express=require('express')
const app=express()
app.get('/',(req,res)=>{
    res.send('hellhno')
})
app.get('/about',(req,res)=>{
    res.send('about page')
})
app.get('/contact',(req,res)=>{
    res.send('contact page')
})
app.get('/home',(req,res)=>{
    res.send('home page')
})
app.listen(3000,()=>{
    console.log('server is running on port 3000')
})