CREATE TABLE [dbo].[Accounts] 
( 
    [AccountId] INT IDENTITY(1,1) PRIMARY KEY, 
    [AccountName] VARCHAR(250) NOT NULL ,
	[AccountDescription] VARCHAR(250) 
)

INSERT INTO [dbo].[Accounts] ([AccountName], [AccountDescription])
VALUES
    ('Chase Freedom (5555)', 'Chase Freedom Credit Card'),
	('Chase Sapphire (5555)', 'Joint Chase Credit Card'),
	('Wells Fargo (5555)', 'Wells Fargo Credit Card'),
	('Discover (5555)', 'Joint Discover Credit Card'),
	('Bank Savings', 'Savings Account'),
	('Credit Union Savings', 'Savings Account'),
	('Credit Union checking', 'Checking Account');