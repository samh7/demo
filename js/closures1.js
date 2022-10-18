// const message = "hello"

function make_a_function(){
    const message = "hello"
    function say_hello(){
        console.log(message)
    }
    return say_hello
}
// const message = "hello"

function hello(){
    const message = "message"
    console.log(message)
}
console.log(hello.toString())

// const say_hello = make_a_function()
// console.log(say_hello.toString())


