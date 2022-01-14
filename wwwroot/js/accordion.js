function cheker() {
    if (this.style.maxHeight != "") return;
    this.style.border = "0px solid black";
}

function openClose(object) {
    object.classList.toggle("accordionActive");

    var block = object.nextElementSibling;

    if (block.style.maxHeight) {
        block.addEventListener("transitionend", cheker, false);
        block.style.maxHeight = null;
        block.style.transition = "max-height 1.5s ease";
    } else {
        block.removeEventListener("transitionend", cheker, false);
        block.style.maxHeight = "600px";
        block.style.border = "1px solid black";
        block.style.transition = "max-height 1.5s ease";
    }
}