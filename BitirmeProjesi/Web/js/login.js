
function getInfo() {


    var isim = document.getElementById("username").value;
    var soyisim = document.getElementById("password").value;

    $.ajax({
        type: "POST",
        data: loginData,
        url: loginUrl,
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            alert(result)
        },
        error: function (result) {
            alert(result)
        }
    });

}
