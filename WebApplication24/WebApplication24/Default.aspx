<meta name="viewport" content="width=device-width, initial-scale=1.0">
<!-- Defines this document to be HTML5-->
<!DOCTYPE html>
<html>
	<head>
		<title> Registration </title>
		
			<link rel="stylesheet" href="scripts/style.css">

	</head>
	<body width="100%" align="center">
		<div id="framedesign" align="center">
			<h1>Registration</h1>
			<!-- Registration form begins, here I have redirected to same html page-->
			<form action="ResponsiveRegister.html" method="POST">
				<div class="container" align="center" >
					<div class="row"  >
						<div class="col" > <label>UserName : </label> 
						<input type="text" name="txtuname" class="inputbox" placeholder="eg. Abhisek" pattern="[A-Za-z0-9_]{1,20}" title="Enter the Username with just alphabets and numbers between 1-20" required /></div>
					</div>
					<div class="row" >
						<div class="col" > <label>Email : </label>
						 <input type="text" name="txtemail" class="inputbox" placeholder="eg. abc@d.com" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$" title="Enter a valid email" required /></div>
					</div>
					<div class="row" >
						<div class="col" > <label>City : </label>
						 <input type="text" name="txtcity" class="inputbox" placeholder="eg. Irving" pattern="[A-Za-z_]{1,20}" title="Enter the city" required /></div>
					</div>
					<div class="row">
						<div class="col" > <label>State : </label>
						 <select id="dropdowndesign" required/>
							<option value="" select="selected">Select-your-state </option>
							<option value="tx"> Texas </option>
							<option value="ca"> Califonia </option>
							<option value="fl"> Florida </option>
							<option value="ny"> New York </option>
							<option value="al"> Alaska </option>
							<option value="io"> Iowa </option>
						</select></div>
					</div>
					<div class="row">
						<div class="col"> <label>Gender : </label>
						 <span class="space"><input type="radio" name="gender" value="male" class="radiobutton" required /> Male  
						<input type="radio" name="gender" value="female" class="radiobutton" required /> Female </div></span>
					</div>
					<div class="row" >
						<div class="col" > <label>About me: </label>
						 <textarea name="aboutme" id="textareadesign" title="Describe about you" required>  </textarea> </div>
					</div>
					<br/>
					<div class="row" >
						<div class="col" colspan="2"> <button type="submit" value="submit"> Submit </button> &nbsp;&nbsp;
						<button type="reset" value="cancel"> Cancel </button>
					 </div>
					</div>
				</div>
			</form>
		</div>
	</body>


</html>