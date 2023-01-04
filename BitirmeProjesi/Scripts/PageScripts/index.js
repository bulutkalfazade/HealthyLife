var GetLogin = function () {
    var username = $('#txtFirstName').val();
    var password = $('#txtPassword').val();

    var url = "/api/Values/GetLogin";
    var loginData = JSON.stringify({ "Username": username, "Password": password });

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
};