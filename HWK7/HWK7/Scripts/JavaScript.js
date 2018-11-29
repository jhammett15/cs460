window.addEventListener("keypress", spacePressed, false)

function spacePressed(e) {
    if (e.keyCode == "32" || e.keyCode == "13") {
        $('#gifString').text("word ");
        console.log("test complete");
    }
        
}