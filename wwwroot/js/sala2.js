const pizarron1 = document.getElementById("pizarron");
const pad1 = document.getElementById("pad")

console.log(pizarron1);
console.log(pad1);

pizarron1.addEventListener("click", () => {
    pad1.className = "visiible";
})