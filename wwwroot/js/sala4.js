const padClicker = document.getElementById("pad4");
const pad = document.getElementById("pad")
const x = document.getElementById("x")

console.log(x);
console.log(padClicker);

padClicker.addEventListener("click", () => {
    pad.classList.replace("invisible", "visible");
})

x.addEventListener("click", () => {
    console.log("hacer invisible");
    pad.classList.replace("visible", "invisible");
})