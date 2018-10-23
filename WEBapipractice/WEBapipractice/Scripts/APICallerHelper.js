var APICallerHelper = function () {
    this.URL = "";
    this.Method = "";
    this.DataType = "";
    this.ContentType = "";
    this.Data = "";
    this.Response = "";
    this.Headers = {};
}

APICallerHelper.prototype.Send = function () {
    var h = this;
    h.CollectHeaderKey();
    $.ajax({
        url: h.URL,
        type: h.Method,
        headers: h.Headers// { Accept: h.DataType }
        ,
        // dataType: h.DataType,
        contentType: h.ContentType,
        data: h.Data,
        success: function (result) {
            h.Response = result;
            if (h.DataType == "application/json")
                $('#txtResponse').val(JSON.stringify(h.Response));
            else {
                $('#txtResponse').val(h.XmlToString(h.Response));
            }
        },
        error: function (err, xhr) {
            $('#txtResponse').val(err.statusText);
        },
        fail: function (xhr) {
            $('#txtResponse').val(xhr);
        }
    });
}

APICallerHelper.prototype.XmlToString = function (xmlData) {

    var xmlString;
    //IE
    if (window.ActiveXObject) {
        xmlString = xmlData.xml;
    } // code for Mozilla, Firefox, Opera, etc.
    else {
        xmlString = (new XMLSerializer()).serializeToString(xmlData);
    }
    return xmlString;
}

APICallerHelper.prototype.Events = function () {
    var h = this;

    $('#txtURL').val(window.location.protocol + "//" + window.location.host + "/");

    $('#btnSend').on("click", function () {
        h.URL = $('#txtURL').val();
        h.Method = $('#ddlMethod').val();
        h.DataType = $('#ddlDataType').val();
        h.ContentType = $('#ddlContentType').val();
        h.Data = $('#txtDataToPost').val();
        h.Send();
    });

    $('#btnAddHeader').on("click", function () {
        $('#divHeaderKeys').append($("<p>Key&nbsp;<input type='text' rel='hKey' value='' />&nbsp;:&nbsp;Value&nbsp;<input type='text' rel='hVal' value='' /><input type='button' name='remove' rel='RemoveHKey' value='Remove' onclick='objAPIC.RemoveHeaderKey(this)' /></p>"));
    });
}

APICallerHelper.prototype.RemoveHeaderKey = function (control) {
    $(control).parent('p').remove();
}

APICallerHelper.prototype.CollectHeaderKey = function () {
    var h = this;
    h.Headers["Accept"] = h.DataType;
    $('#divHeaderKeys p').each(function (index) {
        var keyName = $(this).find('input[rel="hKey"]').val();
        var Value = $(this).find('input[rel="hVal"]').val();
        h.Headers[keyName] = Value;
    });
}

var objAPIC;
$(document).ready(function () {
    objAPIC = new APICallerHelper();
    objAPIC.Events();
});