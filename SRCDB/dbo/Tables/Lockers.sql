CREATE TABLE [dbo].[Lockers]
(
	[LockerNum] INT NOT NULL PRIMARY KEY, 
    [UserId] UNIQUEIDENTIFIER NOT NULL, 
    [LockerPayDate] DATETIME NOT NULL, 
    [RoomId] INT NOT NULL, 
    [Gender] BIT NOT NULL, 
    CONSTRAINT [FK_Lockers_Room] FOREIGN KEY (RoomId) REFERENCES Room(RoomId) 
)
