let tariflerList=[],
     tariflerList2=[];

const getTarifler =() =>{
    fetch("./tarifler.json")
    .then((response) => response.json())
    .then((tarifler) => (tariflerList = tarifler)); 
};

getTarifler();



const createTariflerItemsHtml = () => {
    const tariflerListEl = document.querySelector(".menu_box");
    let tariflerListHtml = "";
    tariflerList.forEach((tarifler,index) => {
      tariflerListHtml += `
          <div class="menu_card  ${index}"  >

      <div class="menu_image">
          <img src="${tarifler.imgSource}">
      </div>

      <div class="small_card">
          <i class="fa-solid fa-heart"></i>
      </div>

      <div class="menu_info">
          <h2>${tarifler.name}</h2>
          <p>
          ${tarifler.açıklama}
          </p>
          <h3>${tarifler.kalori}</h3>
          
          
          <a href="Tarifler.html">
          <button class="menu_btn" onclick="(${
           tarifler.id
          })">Tarif</button>
      </a>
          
         

      </div>
  
  </div> `;
    });
  
    tariflerListEl.innerHTML = tariflerListHtml;
  };


  const listTarifler= () => {
   
    const tariflerListEl = document.querySelector(".cont_principal");
   
    let tariflerListHtml = "";
    
    tariflerList2.forEach((item) => {
      tariflerListHtml += `    <div class="cont_central">
      <div class="cont_modal cont_modal_active">
      <div class="cont_photo">
    <div class="cont_img_back">
        <img src=${item.product.imgSource} alt="" />
        </div>
    <div class="cont_mins">
      <div class="cont_icon_right">
    <a href="#">  <i class="material-icons">&#xE8E7;</i></a>
      </div>
        </div>

    <div class="cont_detalles">
        <h3>${item.product.name} </h3>
    <p>${item.product.açıklama} </p>
        </div>
        </div>
    <div class="cont_text_ingredients">
    <div class="cont_over_hidden">

      <div class="cont_tabs">
      <ul>
    
    <li><a href="#"><h4>TARİF</h4></a></li>
      </ul>  
      </div>
       
      <div class="cont_text_det_preparation">
      <div class="cont_title_preparation">
        <p>STEP 1</p>
        </div>
      <div class="cont_info_preparation">
        <p>${item.product.malzemeler} </p>
        </div>  
      <div class="cont_text_det_preparation">
    
      <div class="cont_title_preparation">
        <p>STEP 2</p>
        </div>
      <div class="cont_info_preparation">
        <p>${item.product.yapılıs} </p>
        </div> 
      
      </div>
    </div>  
      <div class="cont_btn_mas_dets">
      <a href="#"><i class="material-icons">&#xE313;</i></a>
      </div>
  
      </div>
      <div class="cont_btn_open_dets">
      <a href="#e" onclick="open_close() "><i class="material-icons">&#xE314;</i></a>
      </div>
    
        </div>
       </div>`;
    });
    
    tariflerListEl.innerHTML = tariflerListHtml
   
  };
  

  const addToTarifler = (tariflerId) => {
    let findedtarifler = tariflerList.find((tarifler) => tarifler.id == tariflerId);
    if (findedtarifler) {
      const tariflerAlreadyIndex = tariflerList2.findIndex(
        (tarifler) => tarifler.product.id == tariflerId
      );
      if (tariflerAlreadyIndex == -1) {
        let addedItem = { quantity: 1, product: findedtarifler };
        tariflerList2.push(addedItem);
      } else {
        
          tariflerList2[tariflerAlreadyIndex].quantity += 1;
      }
    }
  };



  setTimeout(() => {
    createTariflerItemsHtml();
    },100);
    
    