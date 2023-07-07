let buttons = document.querySelectorAll('.sliderButtons');
let categoriesForSlider = document.querySelectorAll('.categoriesForSlider');

for (const button of buttons) {
    button.addEventListener('click', (e) => {
        categoriesForSlider.forEach((item) => {
            item.classList.add('hidden');
            if (item.firstElementChild.innerText == e.target.innerText) {
                item.classList.remove('hidden');
                item.classList.add('visible');
                console.log(item.firstElementChild.innerText);
            }
        });
    });
}

let priceRange = document.getElementById('priceRange');
let maxPriceRange = document.querySelector('#maxPriceRange');


priceRange.addEventListener('input', (e) => {
    maxPriceRange.value = e.target.value;
    console.log(e.target.value);
});