CREATE TABLE [dbo].[Reservation]
(
	[ReservationId] INT NOT NULL PRIMARY KEY, 
    [GuestId] INT NULL, 
    [RoomId] INT NULL, 
    [ReservationDate] DATE NULL, 
    [CheckInDate] DATE NULL, 
    [CheckOutDate] DATE NULL, 
    [NumberOfGuest] INT NULL, 
    [NumberOfNight] INT NULL, 
    CONSTRAINT [FK_Reservation_ToGuest] FOREIGN KEY ([GuestId]) REFERENCES Guest([GuestId]) ON DELETE CASCADE, 
    CONSTRAINT [FK_Reservation_ToRoom] FOREIGN KEY ([RoomId]) REFERENCES Room([RoomId]) ON DELETE CASCADE
)
