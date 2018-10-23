<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication27._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script src="Scripts/jquery-3.3.1.js"></script>
    
    <script type="text/javascript">
    //function getProducts() {
    //    $.getJSON("api/products",
    //        function (data) {
    //            $('#products').empty(); // Clear the table body.

    //            // Loop through the list of products.
    //            $.each(data, function (key, val) {
    //                // Add a table row for the product.
    //                var row = '<td>' + val.Name + '</td><td>' + val.Price + '</td>';
    //                $('<tr/>', { html: row })  // Append the name.
    //                    .appendTo($('#products'));
    //            });
    //        });
    //    }

        //  $(document).ready(getProducts);
        $(document).ready(function () {
            $('#Button1').click(function () {
                var name = $("#txtname").val();
                var email1 = $("#txtemail").val();
                var comment = $('#txtmessage').val();
                var value = '{name:"' + name + '",email1:"' + email1 + '",comment:"'+comment+'"}';
                $.ajax({
                    type: 'POST',
                    url: '/api/products/SendEmail',
                  
                    data: value,
                      dataType: 'json',
                    
                    success: function (data) {
                    
                        alert(data)

                    },
                    error: function (err, xhr) {
                        alert('ff'+err.statusText);
                    },
                    fail: function (xhr) {
                        alert('kk'+xhr);
                    }


                });
            });
        });
</script>
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
</asp:Content>