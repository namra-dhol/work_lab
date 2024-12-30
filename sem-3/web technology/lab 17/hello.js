// function display(ans){
//     console.log('ans is:'+ans)
// }
// function oddEven(n,callFun){
//     if(n%2==0){
//         callFun("even")
//     }
//     else{
//         callFun('odd')
//     }
// }
// oddEven(10,display)

function funCall(ans){
    console.log(ans)
}
function positiveNeg(n,checkIf){
    if(n==0){
        checkIf('number is 0')
    }
    else if(n<0){
        checkIf("number is negative")
    }
    else{
        checkIf("number is positive")
    }
}

positiveNeg(-10,funCall)