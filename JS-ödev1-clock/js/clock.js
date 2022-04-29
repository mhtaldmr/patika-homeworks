let clockDom = document.querySelector("#myClock");
let nameDom = document.querySelector("#myName");

const _name = prompt("İsiminiz:");
nameDom.innerHTML = _name;

const weekday = ["Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"];

function showTime() {
    const today = new Date();
    let h = today.getHours();
    let m = today.getMinutes();
    let s = today.getSeconds();
    let d = weekday[today.getDay()]
   
    h = (h < 10) ? "0" + h : h;
    m = (m < 10) ? "0" + m : m;
    s = (s < 10) ? "0" + s : s;

    clockDom.innerHTML =  h + ":" + m + ":" + s + d ;
    
    setTimeout(showTime, 1000);
}

showTime();