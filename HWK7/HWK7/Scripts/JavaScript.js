window.addEventListener("keypress", main, false)

var gifstring = "";
var giphyLink = "";
//var key = $("#key").data(value);

function main(e) {
    if (e.keyCode == "32" || e.keyCode == "13") {
       spacePressed();
    }
}


function spacePressed(link) {
    var input = document.getElementById("Input").value;
    var word = input.substr(input.trim().lastIndexOf(" ") + 1);
    giphyLink = "https://api.giphy.com/v1/stickers/translate?&api_key=" + System.Web.Configuration.WebConfigurationManager.AppSettings["GiphyApiKey"] + "&s=" + word;

    $.ajax({
        type: 'GET',
        url: giphyLink,
        dataType: 'json',
        success: displayString,
        error: errorOnAjax
    });
}

function buildString(word) {
    var output = document.getElementById("gifString");

    if (word.length < 6) {
        output.innerHTML += word + " ";
    }
    else {
        var gif = '<iframe class="giphy-embed" src="' + word.data.embed_url + '" width="100" height="100"';
        output.innerHTML += gif;
    }
}

function errorOnAjax() {
    console.log("error");
}

/*function spacePressed(e) {
    if (e.keyCode == "32" || e.keyCode == "13") {
        input = document.getElementById("Input").value;
        word = input.substr(input.trim().lastIndexOf(" ") + 1);
        gifstring += word + " ";
        $('#gifString').text(gifstring);
    }       
}
*/