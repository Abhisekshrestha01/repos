<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication25.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function validate() {
            var uname = document.getElementById("username").value;
            if (uname == "") {
                alert("Please enter the name");
            }
            
        }
        function ValidateUsername() {
            var name = document.getElementById("username").value;
            var pattern = /^[A-Za-z]+$/;
            if (name.match(pattern)) {

                document.getElementById("name_formate").innerHTML = "Error in name formate";
            }
            else {
                document.getElementById("name_formate").innerHTML = " ";
            }
        }

        //
       
                
           
        


</script>
    <style>
        body{
            background-color:#00ff90;
        }
        #container{
            background-color:#00ffff;
            width:40%;
            margin:auto;
        }
        #button{
            background-color:#ff6a00;
            padding:2px;
            
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
        <div>
            <script>
            </script>
            <label> Username</label>
            <input type="text" name="username" id="username" onblur ="ValidateUsername();" />

        </div>
            
        <div id="name_formate"></div>
        <div>
            <label> Gender </label>
            <input type="radio" name="gender" value="male" /> Male
            <input type="radio" name="gender" value="female" /> Female
        </div>
        <div>
            <label> City </label>
                <select name="city">
                    <option value="texas">Texas</option>
                    <option value="dallas"> Dallas </option>
                    <option value="houston"> Houston </option>
                    </select>
        </div>
            <script>
                document.getElementById("button").addEventListener("click", validate);
            </script>
            <span id="button" onmouseover="document.getElementById('button').style.backgroundColor = 'green'">button</span>
        <!--<input type="button" value="submit" onclick="validate()" />
        -->
            </div>
    </form>
</body>
</html>
