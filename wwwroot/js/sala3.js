const sala3 = document.getElementById("sala3");
let tiempo = 1000;

const cambiarIluminacion = () => {
    sala3.classList.toggle("sala3-oscura");
    console.log("cambio");
    console.log(tiempo , "AAA");
}

const incremetarTiempo = () => {
    console.log(tiempo);
    return tiempo * 1.5
}

//incrementar exponencialmente tiempo

setInterval(() => {
    tiempo * 1.2
    cambiarIluminacion();
    
}, tiempo)
