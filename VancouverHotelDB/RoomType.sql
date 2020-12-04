CREATE TABLE [dbo].[RoomType]
(
	[RoomTypeId] INT NOT NULL PRIMARY KEY, 
    [RoomType] NVARCHAR(50) NULL, 
    [Capacity] INT NULL, 
    [PricePerNight] DECIMAL NULL, 
)
