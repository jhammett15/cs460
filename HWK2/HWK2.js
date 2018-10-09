/* 
  A Javascript file that generates a table based on user input.
  The user input being game type, if it's open world, and if there's DLC.
*/

/*
  Creates arrays with the different options for the menus
*/
var gameType = ["World Builder", "RPG", "Survival", "Platformer"];
var openWorld = ["Yes", "No"];
var dlc = ["Yes", "No"];

/*
  Creates an array to hold the base amount of hours, will be used for calculation purposes
*/
var hours = [100, 150, 300, 1000];