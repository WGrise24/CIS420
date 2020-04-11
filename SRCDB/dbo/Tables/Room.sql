CREATE TABLE [dbo].[Room]
(
	[RoomId] INT NOT NULL PRIMARY KEY, 
    [Location] NVARCHAR(100) NOT NULL, 
    [ReserveStatus] BIT NOT NULL
)
