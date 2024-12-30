// const path = require('path')
// filepath = ('D:\\jainil\\program\\sem-3\\web technology\\nodeDemo')

// const data = path.normalize(filepath)
// console.log(data)

// const dta3 =   path.join(filepath,'abc.txt')
// console.log(dta3)
const cp = require('child_process')
// cp.exec('dir',(err,stdout,stdin)=>{
//     console.log(stdout)
// })

cp.exec('java Demo.java',(err,stdout,stdin)=>{
    console.log(stdout)
})