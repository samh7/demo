// scope/variable lifetime:
// lexical scoping(var) - exist from when declared until their function ends  ( exist until their function exists)
// block scoping(const, let) - exist until the next } is reached  (exist only with until a } is reached eg in loops)

hoisted_anon_func = "hoisted_anon_func"
console.log(hoisted_anon_func)


hoisted_function()

hoisted_value = "this is a hoisted value"
console.log(hoisted_value)

hello= function (){
    for (var i = 0; i < 10; i++){
        console.log(i)
    }
    i+=1
    //it exists even after is scope ends
    console.log(i)    
}
hello()

console.log()

hello2= function (){
    for (let y = 0; y < 10; y++){
        console.log(y)
    }
    // y+=1  causes an error
    // console.log(y)  causes an error
}

hello2()

//const cant be updated
//values in a object which is declared a a 
//let and var can be updated
// console.log(i)


var hoisted_value = 32
hoisted_value =23
console.log(hoisted_value)
//note that when  variable declared within main, it is available even before where you declared it but as undefined
//since it was declared below. I.e the compiler knows that it exits throughout the function but only gets its value
//at where you declare it
//since the compiler is aware of it even before the line you declare it, you can manipulate that variable even before where you declare it
//this is called hoisting
//vars and functions  are hoisted
//const  and let can't be hoisted
//note: vars with declared with anonymous functions are hoisted but since the function definition is below, they cannot be called as functions above, they are just undefined values  

var hoisted_anon_func = function(){
    console.log("this a hoisted function")
}


//functions are hoisted and they can be called at the top
function hoisted_function(){
    console.log("this a hoisted function")
}




this_is_a_global_variable = "this_is_a_global_variable"

//global variables are not hoisted