CREATE TABLE [dbo].[Customer]
(
	[CustomerID] INT IDENTITY(1, 1) NOT NULL, 
    [EmailAddress] NVARCHAR(1000) NOT NULL, 
    CONSTRAINT [PK_Customer] PRIMARY KEY ([CustomerID]) 
)
