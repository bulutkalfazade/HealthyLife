let menu = document.querySelector('#menu-bars');
let navbar = document.querySelector('.navbar');

menu.onclick = () =>{
  menu.classList.toggle('fa-times');
  navbar.classList.toggle('active');
}

let section = document.querySelectorAll('section');
let navLinks = document.querySelectorAll('header .navbar a');

window.onscroll = () =>{

  menu.classList.remove('fa-times');
  navbar.classList.remove('active');


}



var swiper = new Swiper(".home-slider", {
  spaceBetween: 30,
  centeredSlides: true,
  autoplay: {
    delay: 7500,
    disableOnInteraction: false,
  },
  pagination: {
    el: ".swiper-pagination",
    clickable: true,
  },
  loop:true,
});



function loader(){
  document.querySelector('.loader-container').classList.add('fade-out');
}

function fadeOut(){
  setInterval(loader, 2000);
}

window.onload = fadeOut;


let YemekServisi=[],
     tariflerList2=[];

const getYemekler =() =>{
    fetch("./YemekServisi.json")
    .then((response) => response.json())
    .then((Yemekler) => (YemekServisi = Yemekler)); 
};

getYemekler();



const createYemeklerItemsHtml = () => {
    const YemekServisiEl = document.querySelector(".box-container");
    let YemeklerListHtml = "";
    YemekServisi.forEach((Yemekler,index) => {
      YemeklerListHtml += `
      <div class="box ${index}">
      <a href="#" class="fas fa-heart"></a>
      <a href="#" class="fas fa-eye"></a>
      <img src="${Yemekler.img}" alt="">
      <h3>  ${Yemekler.isim}</h3>
      <div class="stars">
          <i class="fas fa-star"></i>
          <i class="fas fa-star"></i>
          <i class="fas fa-star"></i>
          <i class="fas fa-star"></i>
          <i class="fas fa-star-half-alt"></i>
      </div>
      <span>${Yemekler.fiyat}</span>
      <a href="#" class="btn">SİPARİŞ VER</a>
  </div> `;
    });
  
    YemekServisiEl.innerHTML =YemeklerListHtml;
  };
