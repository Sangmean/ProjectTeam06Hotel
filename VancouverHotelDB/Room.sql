CREATE TABLE [dbo].[Room]
(
	[RoomId] INT NOT NULL PRIMARY KEY, 
    [RoomTypeId] INT NULL, 
    CONSTRAINT [FK_Room_ToRoomType] FOREIGN KEY ([RoomTypeId]) REFERENCES RoomType([RoomTypeId])
)
