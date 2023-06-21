// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const botonPista = document.getElementsByClassName("boton-pista");
const pista = document.getElementsByClassName("pista")

    console.log(pista);

const mostrarPista = (index) => {
    pista[index].classList.toggle("visiblePista");
    console.log("llego", pista);
}

for (let index = 0; index < botonPista.length; index++) {
    console.log(botonPista[index]);
    botonPista[index].addEventListener("click",() => {mostrarPista (index)})

}




