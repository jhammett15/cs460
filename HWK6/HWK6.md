# Homework 6

[Repository](https://github.com/jhammett15/jhammett15.github.io) 

The goal of this project was to show that we can connect to a pre-existing large database and use portions of it to build a web-based application. We made a single website with two features: the ability to find people by searching their name (either full or partial) and returning their information, and to return company and purchase history information if the person searched was a customer.

## Setting up the Project

The first step after creating my base project files was to download the database and extract the files. I first downloaded the zip file of the git repository where the sln file was stored. Once that was done I opened the wwi-sample.sln in the world-wide-importers folder and built the solution. I then right-clicked on the WorldWideImporters project, clicked publish, and set the target database connection to my SQL Server Management Studio connection. I changed the name of the database to be created there to WorldWideImporters and clicked publish.

Once the connection was created in SSMS, I needed to establish a connection to that in Visual Studios. In the Server Explorer I right-clicked on Data Connections and clicked "add connection". I changed the name of my server to the localDB server in SSMS, and selected the WorldWideImporters database.

Once the connection in Visual Studios was created, I created the context class that would allow me to access it without going directly through the database. I right-clicked on the Models folder and added a new item. This item was of type ADO.NET Entity Data Model. This model was a code-first from database, and to it I added all the tables I would need from the database. 

After the context file was created, I created a new folder in my project and called it DAL, and moved the context file there.

Now I needed to establish a connection in Linqpad so I could test my queries there. To do that, I clicked "add connection" and under the "use a typed data context from your own assembly" list I selected Entity Framework DbContext. The path to the custom assembly was the path to the HWK6.dll file in the bin folder of my project. From there I selected the context file, and added the path to the webconfig file. That established the connection to my database and I could proceed to write queries in linqpad.

Unfortunately these setup steps took me longer than I thought they should have. I didn't see the link in the homework instructions on how to restore the database until I had fiddled with it for a few hours, so I wasted time there. AFter I finally found that, I had trouble with the name of the database. For some reason the exact syntax wasn't clicking to me so it took me a while to figure out. Then after I finally got everything connected, the "Find" property in Linqpad wasn't being recognized so I searched for a reason for that for a while before I gave up and just started my project, hoping I wouldn't need to use it for a while. ******

## Task 1

