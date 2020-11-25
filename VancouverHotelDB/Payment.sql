CREATE TABLE [dbo].[Payment]
(
	[PaymentId] INT NOT NULL PRIMARY KEY, 
    [ReservationId] INT NULL, 
    [GuestId] INT NULL, 
    [Amount] DECIMAL NULL, 
    [PaymentType] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Payment_ToReservatioin] FOREIGN KEY ([ReservationId]) REFERENCES Reservation([ReservationId]), 
    CONSTRAINT [FK_Payment_ToGuest] FOREIGN KEY ([GuestId]) REFERENCES Guest([GuestId])
)
