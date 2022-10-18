const o4 = {
    a: "a",
    c: "c",
     obj: {
        key:"\"string key\"",
     },
}

const o5 = Object.assign({},o4)

function deep_copy(obj){
    // const obj2 = {}
    // keys = Object.keys(obj)
    // for (let i = 0; i < keys.length; i++){
    //     obj2[keys[i]] = obj[keys[i]]
    //     if (typeof obj[keys[i]] === "object"){
    //         obj2[keys[i]] === Object.assign(obj2, obj[keys[i]])
    //     }
    // }
    // return obj2
    const new_obj = {}
    keys = Object.keys(obj)
    for (let i=0; i<keys.length; i++){
        const key = keys[i]
        if (typeof  obj[key] === "object"){
            new_obj[key] = deep_copy(obj[key])
        }
        else{
            new_obj[key] = obj[key]

        }
    }
    return new_obj
}

const o6 = deep_copy(o4)
console.log(o6["a"])


console.log()
o6.obj.key = "hello world"
console.log(o6.obj.key)
console.log(o4.obj.key)
console.log("success")