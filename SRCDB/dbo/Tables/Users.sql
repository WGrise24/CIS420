CREATE TABLE [dbo].[Users]
(
	[UserId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(100) NOT NULL, 
    [LastName] NVARCHAR(100) NOT NULL, 
    [PhoneNumber] NVARCHAR(10) NOT NULL, 
    [Address] NVARCHAR(100) NOT NULL, 
    [City] NVARCHAR(100) NOT NULL, 
    [State] NVARCHAR(2) NOT NULL, 
    [Zip] INT NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    [Password] NVARCHAR(100) NOT NULL, 
    [DOB] DATETIME NOT NULL, 
    [IsEmployee] BIT NOT NULL, 
    [IsManager] BIT NOT NULL, 
    [IsMember] BIT NOT NULL 
)
