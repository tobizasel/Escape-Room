// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// const botonPista = document.getElementsByClassName("boton-pista");
// const pista = document.getElementsByClassName("pista")

// console.log(pista);

// const mostrarPista = () => {
//     pista.className = "visible";
//     console.log("llego");
// }

// pista.forEach(p => {
//     p.addEventListener("click", mostrarPista)
// });


const pizarron1 = document.getElementById("pizarron");
const pad1 = document.getElementById("pad")

console.log(pizarron1);


pizarron1.addEventListener("click", () => {
    pad1.className = "visiible";
})
