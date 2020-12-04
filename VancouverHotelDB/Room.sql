CREATE TABLE [dbo].[Room]
(
	[RoomId] INT NOT NULL PRIMARY KEY, 
    [RoomTypeId] INT NULL, 
    [Status] NCHAR(10) NULL, 
    CONSTRAINT [FK_Room_ToRoomType] FOREIGN KEY ([RoomTypeId]) REFERENCES RoomType([RoomTypeId]) ON DELETE CASCADE
)
