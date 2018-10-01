# Homework 1 

This was the first homework for CS 460: Software Engineering, in which we learned the basics of HTML and CSS through creating a simple website. We used Bootstrap for our base library, which is a popular CSS and Javascript library for page layouts. 

We used the command line version of Git as a means of version control, linked to a remote repository on Github.

## Git setup

Our first task was to download and install the command line version of Git from [git-scm.com](https://git-scm.com/).

I had never used git before, so there was a bit of a learning curve, but the basics were well explained in class. I did all of my work on a Windows machine, but used the Git Bash terminal for all of the version control, which uses Linux commands.

It probably would have been easier to create the repository on Github and then clone it to my local machine, but I created the initial repository on my laptop, so I linked my machine to Github, then pushed everything there to link the two.

```
 git remote add origin https://github.com/jhammett15/cs460.git
 git remote -v
 origin  https://github.com/jhammett15/cs460.git (fetch)
 origin  https://github.com/jhammett15/cs460.git (push)
```

At this point I hadn't created any files, I only had an empty folder.

## Webpage

I learned the basics of HTML several years ago, so I knew about opening and closing tags, but that was about it for my experience. I didn't remember anything about CSS other than that it was used for styling, and I didn't know what Bootstrap was at all. I started out by downloading the files for Bootstrap and making sure it was running properly. I went [here](http://getbootstrap.com/) to download the files, then to the Get Started page to learn how to make it work. There were several links I needed to copy into my file, one link copied into the head, and three scripts into the bottom of the body. 

```
 <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
 
 <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
 <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
 <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
```

Once that was done I made a plan for my website. I had a surprisingly hard time figuring out what I wanted to do, and I even changed my idea partway through the project causing me do delete a few files, rename another, and create a few more. Eventually I settled on a site about the video games that I want to play but haven't had a chance to yet. Along with some pictures of my dog because she's too cute not to share. 

Once I had my plan I created the necessary files, leaving them blank until I had a navbar up and running on the home page. That way I could just copy the boilerplate code with the opening and closing tags, bootstrap code, and navbar code into all the other files. I had a lot more trouble with the navbar than I had expected to. I put the navbar in a div, and put another div in the navbar, in which I put an unordered list with the links. I got the links working fine, but for some reason they all wanted to stack vertically and I still don't know why. Eventually I put the list items into buttons and they sat horizontally next to each other.

Once I had the navbar up and running I copied the outline into all the other files.

```html
<!DOCTYPE html>
<!--This is the home page for my website, which will have an about me and tell the purpose of the site.-->

<html lang=en-US>
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        
        <title></title>
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
        <link rel="stylesheet" type="text/css" href="styles.css">
        
        <link rel="shortcut icon" href="donut.ico" type="image/x-icon">
    </head>
    
    <body>
        
        <div class="container-fluid" bg-1 id="banner">
            <h1 class="display-1">Jerika's Site</h1>
        </div>
        
        <div>
            <nav class="navbar navbar-expand-lg">
                <div class="container-fluid">
                    <ul class="nav navbar-nav">
                        <li class="active"><button type="button" class="btn btn-dark"><a href="#">Home</a></button></li>
                        <li><button type="button" class="btn btn-dark"><a href="Games.html">Games</a></button></li>
                        <li><button type="button" class="btn btn-dark"><a href="Images.html">Images</a></button></li>
                        <li><button type="button" class="btn btn-dark"><a href="Author.html">Author</a></button></li>
                    </ul>
                </div>
            </nav>
        </div>
        
        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
    </body>
</html>
```