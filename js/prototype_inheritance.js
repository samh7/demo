const arr = []

arr.push('hello, world')
arr.push(1)
arr.push("1")

arr[0] = arr[0].toUpperCase()
console.log(arr)
console.log(arr.toString())
//arr.__proto__.__proto__
//if you call a method in that is both, the one in the first __proto__  is the one that is called

//only primitive have wrappers, language constants(eg number(23,23), strings) don't:
// example: 43.toString() errors but number = 42 ; number.toString() doesn't
number = 123
Number.prototype.toString = function(){
    return "100"
}

console.log(number.toString())