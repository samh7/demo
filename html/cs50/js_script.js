function hello2(){
    const heading = document.querySelector("h2")
    if (heading.innerHTML === "WELCOME"){
        heading.innerHTML="GOODBYE"
    }
    else {
        heading.innerHTML="WELCOME"        
    }
}
if (!localStorage.getItem("counter")){
    let counter = 0
}



function count(){
    let counter = localStorage.getItem("counter")
    counter++
    document.querySelector("h1").innerHTML = counter
    localStorage.setItem("counter", counter)
    // if (counter%10 === 0){
    // alert(`The count is now${counter}`)
    // }
}
document.addEventListener('DOMContentLoaded', function(){
    document.querySelector("h1").innerHTML = localStorage.getItem("counter")
    document.querySelector("button").onclick = count;
    //automatically calls count function every 1 second and increaments the value of counter by 1
    // setInterval(count, 1000)
})
    
    
