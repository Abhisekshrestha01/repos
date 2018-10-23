$(document).ready(function () {
    //load all the notifications
   

    $.ajax({
        type: "GET",
        url: '/Notification/GetAllNotification/',
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
            console.log(result);
            for (i = 0; i < result.length; i++) {
                var notification = "<li><a href='" + result[i].url + "'>" + result[i].message + "</a></li>";
                $("#notificationBar").html(notification);
            }
        },
        error: function (result) {
            console.log(result);
            console.log("An error occured");
        }
    });

    //$.ajax({
    //    url: '/Deal/GetInfo/',
    //    type: 'GET',
    //    dataType: 'json',
    //    data: { id: dealID },
    //    success: function (data) {
    //        PopulateDealWorkflowDepositsTable(data, 'tableDepositDealEditProduct', true, -1, -1);
    //    },
    //    error: function (x, y, z) {
    //        alertify.error(genericErrorMessage);
    //        $('#loaderSelectProducts').css('display', 'none');
    //    }
    //});


})