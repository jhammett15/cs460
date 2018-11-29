# Homework 6

[Repository](https://github.com/jhammett15/jhammett15.github.io) 

The goal of this project was to create a dynamic, single page application using an external API called Giphy. If you typed in a string into the input bar, every time you typed a space it would translate the word below. If your word was "boring," it would just print the word. If it was "interesting," it would translate it into a gif and print that below instead of the word. The page needed to be responsive-- that is it only reloaded the parts that changed, not the entire page.

## Setup

The setup for this application was very simple. I created a blank MVC project and created one controller and corresponding view. The view had no navbar, just a title, a search bar, and a space below for the output. I also put a razor tag at the bottom called PageScripts (which I defined in the shared layout page) so that it would render my javascript.

```html
<div class="row" style="text-align:center">
    <div class="col" style="display:inline-block">
        <h3>Internet Language Translator</h3>
        <br />
        <input class="form-control" id="Input" type="text" placeholder="Start typing your message here ..." />
    </div>
    <br />
    <br />
    <div class="row">
        <div class="row gifRow" id="gifString">
            <p></p>
        </div>
    </div>
    
</div>

@section PageScripts
{
    <script type="text/javascript" src="~/Scripts/JavaScript.js"></script>    
}
```

![home](images/home.PNG)

After that was done I registered as a developer on Giphy. I created a basic application (that I did nothing with) so they would give me an API key. This key I stored in a file I called giphy.config. I saved this file outside of my repository so it wouldn't get uploaded to github. Inside the file I put this code:

```html
<appSettings>
    <add key="GiphyAPIKey" value="###MY_KEY###" />
</appSettings>
```

I then added a reference to this file in my webconfig file. 

```html
<configuration>
  <appSettings file="C:\Users\Jerika\Documents\cs460\giphy.config">
    <add key="webpages:Version" value="3.0.0.0"/>
    ...
```

