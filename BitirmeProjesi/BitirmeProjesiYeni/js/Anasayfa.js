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

  section.forEach(sec =>{

    let top = window.scrollY;
    let height = sec.offsetHeight;
    let offset = sec.offsetTop - 150;
    let id = sec.getAttribute('id');

    if(top >= offset && top < offset + height){
      navLinks.forEach(links =>{
        links.classList.remove('active');
        document.querySelector('header .navbar a[href*='+id+']').classList.add('active');
      });
    };

  });

}

function Hesapla() {
    var oran;
    s1 = parseInt(document.getElementById('height').value);
    s2 = parseInt(document.getElementById('neck').value);
    s3 = parseInt(document.getElementById('bel').value);
    s4 = parseInt(document.getElementById('kalca').value);
    oran = (495 / (1.0324 - (0.19077 * (Math.Log10(s3 - s2))) + (0.15456 * (Math.Log10(s1))))) - 450;
    document.getElementById('sonuc').value = oran;
}