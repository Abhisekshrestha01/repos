<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication6.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


input {
  margin: 0;
  font-family: inherit;
  font-size: 100%;
}

input {
  line-height: normal;
}

input {
  font-family: inherit;
  font-size: inherit;
  line-height: inherit;
}

input {
  background-image: none;
}

input {
    max-width: 280px;
}


  * {
    color: #000 !important;
    text-shadow: none !important;
    background: transparent !important;
    box-shadow: none !important;
  }
  
* {
  -webkit-box-sizing: border-box;
     -moz-box-sizing: border-box;
          box-sizing: border-box;
}

input[type=submit] {
  cursor: pointer;
  -webkit-appearance: button;
}

    </style>
</head>
<body>
    <form id="form1" runat="server">

   

    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ClickMe" />

   

        <div>
        </div>
    </form>
</body>
</html>
