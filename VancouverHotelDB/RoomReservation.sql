﻿CREATE TABLE [dbo].[RoomReservation]
(
	[RoomId] INT NOT NULL PRIMARY KEY, 
    [ReservationId] INT NULL, 
    CONSTRAINT [FK_RoomReservation_ToRoom] FOREIGN KEY ([RoomId]) REFERENCES Room([RoomId]) ON DELETE CASCADE, 
    CONSTRAINT [FK_RoomReservation_ToReservation] FOREIGN KEY ([ReservationId]) REFERENCES Reservation([ReservationId]) ON DELETE CASCADE
)
