CREATE TABLE [dbo].[DemographForm]
(
	[Date] DATETIME NOT NULL PRIMARY KEY, 
    [RoomId] NVARCHAR(50) NOT NULL, 
    [UserAccount] NVARCHAR(50) NOT NULL, 
    [Female] INT NOT NULL, 
    [Caucasian] INT NOT NULL, 
    [AfricanAmerican] INT NOT NULL, 
    [Other] INT NOT NULL, 
    [Male] INT NOT NULL, 
    [Time] DATETIME NOT NULL, 
    CONSTRAINT [FK_DemographForm_Room] FOREIGN KEY (RoomId) REFERENCES Room(RoomId)
)
