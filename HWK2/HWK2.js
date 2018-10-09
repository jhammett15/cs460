/* 
  A Javascript file that generates a table based on user input.
  The user input being game type, if it's open world, and if there's DLC.
*/

/*
  gets the values from the dropdown menus in the html page
*/
var type = ('#GameType:selected').val();
var world = ('#OpenWorld:selected').val();
var dlc = ('#ExtraContent:selected').val();

/*
  Assigns number values to variables based on what was gotten from the dropdown menus, then calculates the total hours needed.
*/
function calculateHours() {
    "use strict";
    var hours, multiplier, addition, totalHours;
    
    if (type === 0) { hours = 1000; }
    if (type === 1) { hours = 150; }
    if (type === 2) { hours = 300; }
    if (type === 3) { hours = 100; }
    
    if (world === 0) { multiplier = 3; }
    if (world === 1) { multiplier = 1; }
    
    if (dlc === 0) { addition = 80; }
    if (dlc === 1) { addition = 0; }
    
    totalHours = hours * multiplier + addition;
    return totalHours;
}

/*
  Generates a comment on the total amount of hours needed to finish a game depending on the amount of hours
*/
function generateComment() {
    "use strict";
    var comment, hours = calculateHours();
    
    if (hours < 150) { comment = "Well that should take no time at all!"; }
    if (hours >= 150 && hours <= 300) { comment = "A decently sized game it apperas."; }
    if (hours > 300 && hours < 500) { comment = "Well that should take a while."; }
    if (hours > 500 && hours < 1000) { comment = "Ok, that's getting excessive."; }
    if (hours > 1000) { comment = "You'll never finish this game! Muahahaha!"; }
    
    return comment;
}

