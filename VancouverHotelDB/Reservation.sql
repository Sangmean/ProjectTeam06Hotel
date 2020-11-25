CREATE TABLE [dbo].[Reservation]
(
	[ReservationId] INT NOT NULL PRIMARY KEY, 
    [GuestId] INT NULL, 
    [RoomId] INT NULL, 
    [ReservationDate] DATE NULL, 
    [CheckInDate] DATE NULL, 
    [CheckOutDate] DATE NULL, 
    [NumberOfGuest] INT NULL, 
    CONSTRAINT [FK_Reservation_ToGuest] FOREIGN KEY ([GuestId]) REFERENCES Guest([GuestId]), 
    CONSTRAINT [FK_Reservation_ToRoom] FOREIGN KEY ([RoomId]) REFERENCES Room([RoomId])
)
