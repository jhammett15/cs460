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