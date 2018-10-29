-- Requests table
CREATE TABLE [dbo].[Requests]
(
	[ID]			INT IDENTITY (1,1)	NOT NULL,
	[FirstName]		NVARCHAR(64)		NOT NULL,
	[LastName]		NVARCHAR(64)		NOT NULL,
	[PhoneNumber]	INT (10)			NOT NULL,
	[ApartmentName]	NVARCHAR(64)		NOT NULL,
	[UnitNumber]	int (5)				NOT NULL,
	[Explanation]	NVARCHAR(250)		NOT NULL,
	CONSTRAINT [PK_dbo.Requests] PRIMARY KEY CLUSTERED ([ID] ASC)
);

INSERT INTO [dbo].[Requests] (FirstName, LastName, PhoneNumber, ApartmentName, UnitNumber, Explanation) VALUES
	('Jerika', 'Hammett', '5037461948', 'Random Apartments', '14', 'Testing'),
	('Bob', 'Marley', '3608372957', 'Random Apartments', '15', 'The kitchen faucet is leaking'),
	('Susie', 'Susanson', '5837591024', 'Other Apartments', '2', 'There are rats in my apartment'),
	('Jack', 'Harkness', '6969696969', 'The Tardis', '0', 'I locked myself out.'),
	('Queen', 'Elizabeth', '1111111111', 'Buckingham Palace', '1', 'It is a bit chilly')
GO