
var timerFunction;
function StartCountDown(endDate) {

    
    // Set the date we're counting down to
    //var countDownDate = endDate.getTime();
    //console.log("DateTime :" + countDownDate);
    //var flag = true;
    // Update the count down every 1 second 

    if (timerFunction != "undefined") {
        clearInterval(timerFunction);

    }
    console.log("Timer function " + timerFunction);
       // Update the count down every 1 second
       timerFunction= setInterval(function () {
           var countDownDate = endDate.getTime();
           // Get todays date and time
           var now = new Date().getTime();

           // Find the distance between now an the count down date
           var distance = countDownDate - now;

           // Time calculations for days, hours, minutes and seconds
           var days = Math.floor(distance / (1000 * 60 * 60 * 24));
           var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
           var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
           var seconds = Math.floor((distance % (1000 * 60)) / 1000);

           // Output the result in an element with id="demo"
           document.getElementById("timer").innerHTML = days + "d " + hours + "h "
               + minutes + "m " + seconds + "s ";
           days = "";
           hours = "";
           minutes = "";
           seconds = "";

           // If the count down is over, write some text 
           if (distance < 0) {
               clearInterval(timerFunction);
               document.getElementById("timer").innerHTML = "EXPIRED";
           }
       }, 1000);
       
    
}