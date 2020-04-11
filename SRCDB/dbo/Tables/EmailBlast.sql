CREATE TABLE [dbo].[EmailBlast]
(
	[EmailDate] DATETIME NOT NULL PRIMARY KEY, 
    [UserEmail] NVARCHAR(100) NOT NULL, 
    [ManagerEmail] NVARCHAR(100) NOT NULL 
)
