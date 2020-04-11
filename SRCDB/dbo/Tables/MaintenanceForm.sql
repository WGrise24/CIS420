CREATE TABLE [dbo].[MaintenanceForm]
(
	[MaintenanceId] INT NOT NULL PRIMARY KEY, 
    [MachineName] NVARCHAR(100) NOT NULL, 
    [SerialNum] NVARCHAR(100) NOT NULL, 
    [Comments] NVARCHAR(100) NOT NULL, 
    CONSTRAINT [FK_MaintenanceForm_Equipment] FOREIGN KEY (SerialNum) REFERENCES Equipment(SerialNum)
)
