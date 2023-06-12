// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const botonPista = document.getElementsByClassName("boton-pista");
const pista = document.getElementsByClassName("pista")

    console.log(pista);

const mostrarPista = (index) => {
    pista[index].classList.toggle("visible");
    console.log("llego", pista);
}

for (let index = 0; index < botonPista.length; index++) {
    console.log(botonPista[index]);
    botonPista[index].addEventListener("click",() => {mostrarPista (index)})

}


// pista.forEach(p => {
//     p.addEventListener("click", mostrarPista)
// });


const pizarron1 = document.getElementById("pizarron");
const pad1 = document.getElementById("pad")

console.log(pizarron1);


pizarron1.addEventListener("click", () => {
    pad1.className = "visiible";
})

const sala3 = document.getElementById("sala3");

setInterval(() => {
    console.log("cambio");
    sala3.classList.toggle("sala3-oscura")
}, 1000)