
        var sonuc;
        function hesapla(){
            var sayi1=document.getElementById("height").value;
            var sayi2=document.getElementById("neck").value;
            var sayi3=document.getElementById("bel").value;
            var sayi4=document.getElementById("kalca").value;
           
    
            var s1 = Number(sayi1);
            var s2 = Number(sayi2);
            var s3 = Number(sayi3);
            var s4 = Number(sayi4);

            sonuc=495/(1.0324 - (0.19077*log10(s3-s2) )+ (0.15456*log10(s1)))-450;


            document.getElementById("sonuc").innerHTML = "Sonuc : " + sonuc;
        }

        var hesaplaBtn=document.getElementById("bmrbutton");
        hesaplaBtn.onclick=hesapla();

  