window.addEventListener("keypress", spacePressed, false)

gifstring = "";


function spacePressed(e) {
    if (e.keyCode == "32" || e.keyCode == "13") {
        input = document.getElementById("Input").value;
        word = input.substr(input.trim().lastIndexOf(" ") + 1);
        gifstring += word;
        $('#gifString').text(gifstring);
    }       
}