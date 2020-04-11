CREATE TABLE [dbo].[Equipment]
(
	[SerialNum] NVARCHAR(100) NOT NULL PRIMARY KEY, 
    [RoomId] INT NOT NULL, 
    [EquipmentType] BIT NOT NULL, 
    [PurchaseDate] DATETIME NOT NULL, 
    CONSTRAINT [FK_Equipment_Room] FOREIGN KEY (RoomId) REFERENCES Room(RoomId)
)
