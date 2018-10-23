# Homework 4

[Repository](https://github.com/jhammett15/jhammett15.github.io) 

The task for homework 4 was to create an MVC project to demonstrate simple server-side logic. We demonstrated the basics of GET and POST commands, as well as query strings, form data, and input validation. We did this through the creation of two pages: a mile converter which took in a mile number and converted it to one of many other measurements, and a color chooser which took in two colors and added their hexadecimal values together and displayed a third color.

## Setup

The first step was to create an empty MVC project. Prior to starting this homework I had gone through the first few chapters of the Pro ASP.NET MVC 5 book so I already had an idea on how to do this and where to look for things. The instrucions given in class were also very helpful, so I didn't have much issue with the setup of this project.

## Planning

I created two branches in git for this project: a mileconverter branch and a colorchooser branch. I was already familiar with the idea of switching between branches and isolating the work so all the work for the Color Chooser was don only on the colorchooser branch for example. I would work on a branch, commit it, and then switch to another branch and work on that. One thing I had forgotten to do until I was done with the mile converter and half-way done with the color chooser however was to push the various branches to github. This was a bad idea and will not be happening again. Once everything was done, I merged the two branches into Master. The mileconverter branch I merged first with no problem. When I merged the colorchooser branch I had merge conflicts in several of my files. These were easily fixed however simply by going into the file. When git told me there were merge conflicts it put both versions of what was conflicting side by side in each file so all I had to do was go in and choose which one I wanted.

## Content/Coding

The first thing I did was create the pages I was going to need. In the HomeController I added an ActionResult method to do the mile conversion and created a View based on that. Then I created a ColorController and gave it Index and Create ActionResult methods, and created Views based on those. The next thing I did was create a blank blog page. The last thing I did on Master before creating my branches was to delete the default pages I wasn't going to use and go into the Layout.cshtml page and change the links in the navbar so that they pointed to my pages.

```html
<div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Homework-4", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" })
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Mile Converter", "Converter", "Home")</li>
                    <li>@Html.ActionLink("Color Chooser", "Index", "Color")</li>
                </ul>
            </div>
        </div>
    </div>
```

I also did minor changes like change the title of the pages and put my name on the footer.

## Home Index View

![HomeIndex](HWK4/HWK4/images/HomeIndex.PNG)

This class was very straightforward and did not require much changing. I simply changed the descriptions to match what my pages were about, then changed the links to the buttons.