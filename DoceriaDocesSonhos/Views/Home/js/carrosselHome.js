var slidePosition = 0;

function logicaCarrossel(nomeClasse, next){
const slides = document.getElementsByClassName(nomeClasse)
const totalSlides = slides.length;
if(next){
    moveToNextSlide(totalSlides, slides);
}else{
    moveToPrevSlide(totalSlides, slides);

}
}

function updateSlidePosition(slides) {
  for (let slide of slides) {
    slide.classList.remove('carousel_item--visible');
    slide.classList.add('carousel_item--hidden');
  }

  slides[slidePosition].classList.add('carousel_item--visible')
}

function moveToNextSlide(totalSlides, slides) {
  if (slidePosition === totalSlides -1) {
    slidePosition = 0;
  } else {
    slidePosition++;
  }
  updateSlidePosition(slides);
}

function moveToPrevSlide(totalSlides, slides) {
  if (slidePosition === 0) {
    slidePosition = totalSlides -1;
  } else {
    slidePosition--;
  }
  updateSlidePosition(slides);
}