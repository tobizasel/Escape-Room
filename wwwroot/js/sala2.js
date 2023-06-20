const pizarron1 = document.getElementById("pizarron");
const pad1 = document.getElementById("pad")
const cerrar = document.getElementById("x")

console.log(pizarron1);
console.log(pad1);

pizarron1.addEventListener("click", () => {
    pad1.classList.replace("invisible", "visible");
})

x.addEventListener("click", () => {
    console.log("hacer invisible");
    pad1.classList.replace("visible", "invisible");
})