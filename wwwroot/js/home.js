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
function fullView(ImgLink) {
    document.getElementById("full-image").src = ImgLink;
    document.getElementById("full-image-view").style.display = "block";
    document.getElementsByTagName("header")[0].style.display = "none";
}

function closefullView(event) {
    // Check if the clicked element is outside the full-image
    if (event.target.id === "full-image-view" || event.target.id === "close-button") {
        document.getElementById("full-image-view").style.display = "none";
        document.getElementsByTagName("header")[0].style.display = "block";
    }
}