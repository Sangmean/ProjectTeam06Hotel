CREATE TABLE [dbo].[Guest]
(
	[GuestId]INT NOT NULL PRIMARY KEY, 
    [GuestFirstName] NVARCHAR(50) NULL, 
    [GuestLastName] NVARCHAR(50) NULL, 
    [Adress] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL, 
    [PostCode] NVARCHAR(50) NULL, 
    [Country] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Phone] NVARCHAR(50) NULL
)
