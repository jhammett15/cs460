# Homework 5

[Repository](https://github.com/jhammett15/jhammett15.github.io) 

The goal of this homework was to create a database-backed web application using ASP.NET MVC 5. This would take the form of a maintenance request form. To begin with I was to write the T-SQL necessary to create and populate a simple one-table database. The first page would be the request form. The user would fill out the fields and when submitted the data would be stored in a local database. The second part of the project was to create a table populated with the data from this database. I did this through the use of T-SQL

## Creating the database
The first step in the project was to create the database that I would be adding to. This was done solely through an SQL script and VisualStudios. I created two scripts. An Up.sql, which created and seeded the table with default entries:

```sql
-- Requests table
CREATE TABLE [dbo].[Requests]
(
	[ID]			INT IDENTITY (1,1)	NOT NULL,
	[FirstName]		NVARCHAR(64)		NOT NULL,
	[LastName]		NVARCHAR(64)		NOT NULL,
	[PhoneNumber]	NVARCHAR(10)		NOT NULL,
	[ApartmentName]	NVARCHAR(64)		NOT NULL,
	[UnitNumber]	INT					NOT NULL,
	[Explanation]	NVARCHAR(250)		NOT NULL,
	[CurrTime]		DATETIME			NOT NULL	DEFAULT SYSUTCDATETIME(),
	CONSTRAINT [PK_dbo.Requests] PRIMARY KEY CLUSTERED ([ID] ASC)
);

INSERT INTO [dbo].[Requests] (FirstName, LastName, PhoneNumber, ApartmentName, UnitNumber, Explanation, CurrTime) VALUES
	('Jerika', 'Hammett', '5037461948', 'Random Apartments', '14', 'Testing', '2013-06-05 17:00:00'),
	('Bob', 'Marley', '3608372957', 'Random Apartments', '15', 'The kitchen faucet is leaking', '12-12-12 00:00:00'),
	('Susie', 'Susanson', '5837591024', 'Other Apartments', '2', 'There are rats in my apartment', '03-04-05 01:01:01'),
	('Jack', 'Harkness', '6969696969', 'The Tardis', '0', 'I locked myself out.', '12-13-14 08:09:10'),
	('Queen', 'Elizabeth', '1111111111', 'Buckingham Palace', '1', 'It is a bit chilly', '07-07-18 15:15:15')
GO
```

And a Down.sql which cleared the table.

```sql
-- Take the Requests table down
DROP TABLE [dbo].[Requests];
```

The database I created was called OurRequests, and the Table I created through the SQL above was called Requests. The fields it contained were ID (which was the primary key), FirstName, LastName, PhoneNumber, ApartmentName, UnitNumber, Explanation, and CurrTime. All of these fields were required, so I marked them not null. The CurrTime field had the type DateNime. It could be set, as I did when I seeded the table, but when not set, as when I added to the database through the form, it defaulted to the current time. 

Following the creation of the table is the insert statement where I seeded it. This part is fairly self-explanatory, I just said insert into the table these fields, given the values provided.

## Request Model Class


## DAL RequestContext Class


## WebConfig File


## Home Controller


## RequestForm View


## ViewRequest View