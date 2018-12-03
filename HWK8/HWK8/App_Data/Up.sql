CREATE TABLE [dbo].[Buyers]
(
    [Name]          NVARCHAR(64)                NOT NULL,
    PRIMARY KEY (Name)
);

CREATE TABLE [dbo].[Sellers]
(
    [Name]          NVARCHAR(64)                NOT NULL,
    PRIMARY KEY (Name)
);

CREATE TABLE [dbo].[Bids]
(
	[ID]			INT IDENTITY (1,1)		NOT NULL,
    [Item]          NVARCHAR(64)                NOT NULL,
    [Buyer]         NVARCHAR(64)                NOT NULL,
    [Price]         DECIMAL(10,2)               NOT NULL,
    [Timestamp]     DATETIME                    NOT NULL    DEFAULT SYSUTCDATETIME(),
    PRIMARY KEY (ID),
    FOREIGN KEY (Buyer) REFERENCES Buyers(Name)
);

CREATE TABLE [dbo].[Items]
(
    [ID]            INT IDENTITY (1000,1)       NOT NULL,
    [Name]          NVARCHAR(64)                NOT NULL,
    [Description]   NVARCHAR(128)               NOT NULL,
    [Seller]        NVARCHAR(64)                NOT NULL,
	[BidID]			INT,
    CONSTRAINT [PK_dbo.Items] PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY (Seller) REFERENCES Sellers(Name),
	FOREIGN KEY (BidID) REFERENCES Bids(ID)
);

INSERT INTO [dbo].[Buyers] (Name) VALUES
    ('Jane Stone'),
    ('Tom McMasters'),
    ('Otto Vanderwall');
    
INSERT INTO [dbo].[Sellers] (Name) VALUES
    ('Gayle Hardy'),
    ('Lyle Banks'),
    ('Pearl Greene');
    
INSERT INTO [dbo].[Items] (Name, Description, Seller) VALUES
    ('Abraham Lincoln Hammer', 'A bench mallet fashioned from a broken rail-splitting maul in 1829 and owned by Abraham Lincoln', 'Pearl Greene'),
    ('Albert Einsteins Telescope', 'A brass telescope owned by Albert Einstein in Germany, circa 1927', 'Gayle Hardy'),
    ('Bob Dylan Love Poems', 'Five versions of an original unpublished, handwritten, love poem by Bob Dylan', 'Lyle Banks');
    
INSERT INTO [dbo].[Bids] (Item, Buyer, Price, Timestamp) VALUES
    (1001, 'Otto Vanderwall', 250000, '12/04/2017 09:04:22'),
    (1003, 'Jane Stone', 95000, '12/04/2017 08:44:03');
    
GO