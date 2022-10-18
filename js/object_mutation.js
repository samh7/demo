const o ={
    a:'a',
    b:'b',
}

const o2 = o

console.log("o2.a(before changing o.a)",o2.a)
console.log()

o.a = "new value"
console.log("new o.a value is ","\"" + o.a + "\"")

console.log("o2.a(after changing o.a)",o2.a)
console.log()


o2.a = "aftervalue"
console.log("o2.a after changing o2.a",o2.a)
console.log("o.a after changing o2.a",o.a)
console.log("they are referencing a value in the same location so changing it in either changes the value for both of them")
console.log()

//how to make a object reference another's values but have them be independent: 
console.log()
console.log()

const o3  = Object.assign({},o)
console.log("o3.a without changing o.a (from \"aftervalue\")", o3.a)
o.a = "following"
console.log("o3.a after changing o.a (to \"following\")", o3.a)
console.log("o.a after changing o.a (to \"following\")", o.a)
o3.a = "different world"
console.log("o3.a after changing o3.a (to \"different world\")", o3.a)
console.log("see? the two object are now independent")

console.log()
const o4 = {
    a: "a",
    c: "c",
     obj: {
        key:"\"string key\"",
     },
}

const o5 = Object.assign({},o4)
console.log("default o5.obj.key:",o5.obj.key)
o5.obj.key = "\" string new key\""

console.log()
console.log("o5.obj.key after changing its value in o5:",o5.obj.key )
console.log()
console.log("o4.obj.key after changing its value in o5:",o4.obj.key )

console.log()
console.log("o4.a = ", o4.a)
o4.a = "changes"
console.log("o4.a changed to ", o4.a)
console.log("o5.a after changing o4.a", o5.a)


console.log("the value of o4.a and o5.a are independent but those of o4.obj.key and 05.obj.key are dependant")
console.log("this is because the netsted object is referenced as is into both objects such that o5 doesm't have a copy of it but an address pointing to it")
console.log("this is known as a shallow copy")