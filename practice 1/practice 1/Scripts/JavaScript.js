$(document).ready(function () {
    var error_flightno = false;
    $("#txtflightno").blur(function () {
        var re = /^[a-zA-Z]*$/;
        var flag = re.test($("#txtflightno").val());
        if (flag && ($("#txtflightno").val()) != '') {
            $('#Labelerrorflightno').hide();
        }
        else {
            $('#Labelerrorflightno').show();
            $('#Labelerrorflightno').html('FlightID should only contains alphabets and numbers').css("color", "red");
            $('#txtflightno').css("boorder-bottom", "2px solid #F90A0A");
            error_flightno = true;
        }
    });

    var error_flightname = false;
    $("#DropDownList4").blur(function () {
        if (($("#DropDownList4").val()) != '') {
            $('#Labelerrorflightname').hide();
        }
        else {
            $('#Labelerrorflightname').show();
            $('#Labelerrorflightname').html('Please select one option').css("color", "red");
            $('#DropDownList4').css("boorder-bottom", "2px solid #F90A0A");
            error_flightname = true;
        }
    });

    var error_departurecity = false;
    $("#txtDCity").blur(function () {
        var re = /^[a-zA-Z]*$/;
        var flag2 = re.test($("#txtDCity").val());
        if (flag2 && ($("#txtDCity").val()) != '') {
            $('#Labelerrordepartmentcity').hide();
        }
        else {
            $('#Labelerrordepartmentcity').show();
            $('#Labelerrordepartmentcity').html('Please Enter Departure City in alphabets').css("color", "red");
            $('#txtDCity').css("boorder-bottom", "2px solid #F90A0A");
            error_departurecity = true;
        }
    });

    var error_departureDate = false;
    $("#txtDdate").blur(function () {
        if ($("#txtDdate").val() != '') {
            $('#Labelerrordepartmentdate').hide();
        }
        else {
            $('#Labelerrordepartmentdate').show();
            $('#Labelerrordepartmentdate').html('Please enter the date').css("color", "red");
            $('#txtDdate').css("border-bottom", "2px solid #F90A0A");
            error_departureDate = true;
        }
    });

    var error_arrivalcity = false;
    $("#txtACity").blur(function () {
        var re = /^[a-zA-Z]*$/;
        var flag = re.test($("#txtACity").val());
        if (flag && ($("#txtACity").val()) != '') {
            $('#LabelerrorarrivalCity').hide();
        }
        else {
            $('#LabelerrorarrivalCity').show();
            $('#LabelerrorarrivalCity').html('Please Eter the arrical C ity in alphabets').css("color", "red");
            $('#txtACity').css("boorder-bottom", "2px solid #F90A0A");
            error_arrivalcity = true;
        }
    });
    var error_arrivaltime = false;
    $("#txtATime").blur(function () {
        if ($("#txtATime").val() != '') {
            $('#LabelerrorArrivalTime').hide();
        }
        else {
            $('#LabelerrorArrivalTime').show();
            $('#LabelerrorArrivalTime').html('Please Enter time arrival').css("color", "red");
            $('#txtATime').css("boorder-bottom", "2px solid #F90A0A");
            error_arrivaltime = true;
        }
    });
    var error_seats = false;
    $("#txtNSeats").blur(function () {
        var re = /^[0-9]*$/;
        var flag4 = re.test($("#txtNSeats").val());
        if (flag4 && ($("#txtNSeats").val()) != '') {
            $('#Labelerrorseats').hide();
        }
        else {
            $('#Labelerrorseats').show();
            $('#Labelerrorseats').html('Please Enter the number of seats').css("color", "red");
            $('#txtNSeats').css("boorder-bottom", "2px solid #F90A0A");
            error_seats = true;
        }
    });
    $('#Button1').click(function () {
        if (($("#txtflightno").val() == '') || ($("#DropDownList4").val() == '') || ($("#txtDCity").val() == '') || ($("#txtDdate").val() == '') || ($("#txtACity").val() == '') || ($("#txtATime").val() == '') || ($("#txtNSeats").val() == '')) {
            alert("Please enter all data correctly");
            return false;

        }
        else {
            return true;
        

        }
    });
});