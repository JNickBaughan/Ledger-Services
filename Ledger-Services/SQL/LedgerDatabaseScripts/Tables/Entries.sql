CREATE TABLE [dbo].[Entries]
(
    [EntryId] INT IDENTITY(1,1) PRIMARY KEY,
    [EntryType] VARCHAR(25) FOREIGN KEY REFERENCES [dbo].[EntryTypes]([EntryType]),
	[Account] INT FOREIGN KEY REFERENCES [dbo].[Accounts]([AccountId]),
	[Vendor] INT FOREIGN KEY REFERENCES [dbo].[Vendors]([VendorId]),
    [EntryDescription] VARCHAR(250),
    [EntryDate] DATE,
    [Memo] VARCHAR(500),
    [Amount] MONEY
)

GO