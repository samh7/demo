const first_name ="Jordan";
// not a must to use a semicolon
// single or double quotes
const val = 42

const arr = [
    'string',
    42,
    function () {console.log('hi')},
]

console.log(arr[2])

for (let i = 0;  i < arr.length; i++ ){
    console.log(i)
}


// coercion : implicit or explicit
const x = 42

const explicit = String(x)
console.log(explicit)

const implicit = x + ""
console.log("",implicit )

// == - this coerces the types
// === - equivalent operator
// never use == in js
const y = 84
console.log(typeof y)
