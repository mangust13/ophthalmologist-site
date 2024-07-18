//Slideshow

let slideIndex = 0;
showSlides();

function showSlides() {
    let i;
    let slides = document.getElementsByClassName("mySlides");
    for (i = 0; i < slides.length; ++i) 
        slides[i].style.display = "none";

    ++slideIndex;

    if (slideIndex > slides.length)
        slideIndex = 1

    slides[slideIndex - 1].style.display = "block";
    setTimeout(showSlides, 8000);
}

//Відкриття зображення
var modal = document.getElementById("modal");
var modalImage = document.getElementById("modal-image");
var closeBtn = document.getElementsByClassName("close")[0];

document.querySelectorAll('.clickable-image').forEach(function (img) {
    img.onclick = function () {
        modal.style.display = "block";
        modalImage.src = this.src;
    }
});

closeBtn.onclick = function () {
    modal.style.display = "none";
}

modal.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}
