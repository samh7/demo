function hello(){
    arr = []
    for (var i =0; i < 10; i++){
        console.log
        arr.push(function(){console.log(i)})
        //closure means that the function will have the actual values of i  i.e , since i is declared as a var, at the end of the function, the function will have the latest value of i
    
    i++}
    // i++
    arr[0]()
    return arr
}

const hllo = hello()

hllo[2]//prints 11, showin that the function has access to the variables even after the it ends
