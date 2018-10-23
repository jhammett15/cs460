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

![HomeIndex](HWK4/images/HomeIndex.PNG)

After creating the branches I first switched to the mileconverter branch where I completed the HomeController's Index page (the landing site for the project), and the mile converter. The Index View was very straightforward and did not require much changing. I simply changed the descriptions to match what my pages were about, then changed the links to the buttons.

```html
@{
    ViewBag.Title = "Home Page";
}

<!--A View for the home page, contains a description of the project, as well as a link to the project directions page. Below that there is 
    a description of each page as well as a button linking to them.-->
<div class="jumbotron">
    <h1>CS 460 Homework 4</h1>
    <p class="lead">
        A few forms and some simple server-side logic -- learning the basics of GET, POST, query strings, form data and 
        handling it all from an ASP.NET MVC 5 application.</p>
    <p><a href="http://www.wou.edu/~morses/classes/cs46x/assignments/HW4_1819.html" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
</div>

<div class="row">
    <div class="col-md-4">
        <h2>Mile to Metric Converter</h2>
        <p>
            Want to know how many millimeters there are in 26.2 miles? This calculator is for you. Uses query strings to send form data to
            the server, which performs the calculation and returns the answer in the requested page.
        </p>
        <p><button type="button">@Html.ActionLink("Try it out", "MileConverter")</button></p>        
    </div>
    <div class="col-md-4">
        <h2>Color Chooser</h2>
        <p>
            Typical online color choosers are way too useful. We wanted something fun and completely useless. This form POSTs the data to the
            server.
        </p>
        <p><button type="button">@Html.ActionLink("Check it out", "Create", "Color")</button></p>
    </div>
</div>
```

## Converter View

The next thing I worked on, although I didn't finish it until after I completed the Home Controller, was the Converter View.

## Home Controller

On the HomeController Page there was already an existing ActionResult method for the View for the Index, I just needed to create the View itself. As for the methods I had to add to this controller, the only one I needed to add was a Converter method, and create its corresponding View. 

The Converter method is an HttpGet method that uses Request.QueryString to retrieve information from the query string that is generated in the URL when the user hits the submit button on their input. It retrieved the mile string (which it then converted into a double) and the units string. Then it performed a calculation on the mile number depending on the unit it retrieved. Finally, it created a string to return this information in and added this string to the ViewBag if the input it retrieved from the user was not null (meaning there was input to be retrieved).

```C#
public class HomeController : Controller
    {
        private double? mi;
        private string measurement;
        private string result;

        /// <summary>
        /// A Controller method that generates the "Home" or "Index" page of the project
        /// </summary>
        /// <returns>The View for the Index page.</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// A Controller method that retrieves a double representing the number of miles and a string representing the measurement to be 
        /// converted to from the View via a GET method. It then converts the miles, storing the result in a new variable. Finally it checks 
        /// so see if the measurement variable is not null. If it is null, this means that the input has not been submitted yet. If it is 
        /// not null, the input has ben submitted and it stores the measurement variable and result of the conversion in a ViewBag.
        /// </summary>
        /// <returns>The View for the Mile Converter page</returns>
        [HttpGet]
        public ActionResult Converter()
        {
            Debug.WriteLine(Request.QueryString["miles"]);
            Debug.WriteLine(Request.QueryString["units"]);

            mi = Convert.ToDouble(Request.QueryString["miles"]);
            measurement = Request.QueryString["units"];
            double? total;

            if(measurement == "millimeters")
            {
                total = mi * 1609.34 * 1000;
            }
            else
            {
                if(measurement == "centimeters")
                {
                    total = mi * 1609.34 * 100;
                }
                else
                {
                    if(measurement == "meters")
                    {
                        total = mi * 1609.34;
                    }
                    else
                    {
                        total = mi * 1.60934;
                    }
                }
            }

            result = mi + " miles is equal to " + total + " " + measurement;

            Debug.WriteLine(total);
            Debug.WriteLine(result);

            if (measurement != null)
            {
                ViewBag.measurement = measurement;
                ViewBag.result = result;
            }

            return View();
        }       
    }
```



