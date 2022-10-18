const o = new Object()
o.firs_tname = "Jordan"
o.last_name = "Micheal"

o.greet = function (){
    console.log("hello my name is " + o.firs_tname, o.last_name)
}
o.greet()

const i ={}
i["first_name"] = "2micheal2"
i["last_name"] = "2Jordan2"

console.log(i.first_name)

const o2 = {
    first_name : "Jordan",
    last_name : "Mitchelle",
    greet : function (){
        console.log("hello my name is " + o2.first_name, o2.last_name)
    }
}

o2.greet()

// object nesting

const o3 = {
    first_name: "Obama",
    last_name: "Barack",
    // address: address = {
    //     city: "Washington D.C.",
    //     street: "302 Avenue",
    //     block: 12
    // }
    // note - not a must to name the nested object
    address:  {
        city: "Washington D.C.",
        street: "302 Avenue",
        block: 12
    }
}
console.log(o3.address)
console.log(o3.address.street)

// use [] if we have a predefined key/variable
// eg: 
const my_variable_or_key = "address"
console.log('\n')
console.log(o3[my_variable_or_key])

console.log('\n')

const i2 = new Object()
i2["1"] = 1

console.log(i2[1])//converts the 1 to string
