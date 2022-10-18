function hello(){
    arr = []
    for (let i =0; i < 10; i++){
        console.log
        arr.push(function(){console.log(i)})
    }
    arr[0]()
    return arr
}
// hello()
// arr[0]()
// const h = hello()
// h[0]()