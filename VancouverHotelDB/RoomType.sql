CREATE TABLE [dbo].[RoomType]
(
	[RoomTypeId] INT NOT NULL PRIMARY KEY, 
    [RoomId] INT NULL, 
    [RoomType] NVARCHAR(50) NULL, 
    [Status] NVARCHAR(50) NULL, 
    [Capacity] INT NULL, 
    [PricePerNight] DECIMAL NULL, 
    CONSTRAINT [FK_RoomType_ToRoom] FOREIGN KEY ([RoomId]) REFERENCES Room(RoomId)
)
