$(document).ready(function () {


});

function SaveData() {
    
    $.ajax({
        type: "POST",
        url: "/appservice.asmx/UserSignup",
        data: "{'username': '" + $("#txtAPIName").val() + "','password': '" + $("#txtAPIPassword").val() + "','etc': '" + new Date().getTime() + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {

            alert(result.d)

        },
        error: function () {
            $("#lnkCropImg").show();
            $("#imgCLoader").hide();
        }
    });
}