let pic = document.getElementById("avatar");
pic.addEventListener("click", () => {
    pic.style.cursor = "pointer";
    pic.style.filter = "blur(1px)";
    pic.style.color = "blue";
});