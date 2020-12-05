using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using VancouverHotelCodeFirstFromDB;

namespace SeedDatabaseExtensions
{

	public static class SeedDatabaseExtensionMethods
	{
		/// <summary>
		/// zero out the db tables, then seed all tables with initial data
		/// </summary>
		public static void SeedDatabase(this VancouverHotelEntities context)
		{
			// set up database log to write to output window in VS
			context.Database.Log = (s => Debug.Write(s));

			// reset the db
			context.Database.Delete();
			context.Database.Create();

			context.SaveChanges();

			context.Guests.Load();
			context.Rooms.Load();
			context.RoomTypes.Load();
			context.Reservations.Load();
			context.Payments.Load();

			// seed Guests data


			List<Guest> guestList = new List<Guest>()  {
				new Guest {  GuestFirstName = "Pepi", GuestLastName = "Nattrass", Adress = "209 Dixon Alle",
					City = "Bangkok", PostCode = "66110", Country = "Thailand", Email = "pnattrass0@chron.com", Phone = "999-103-078" },

				new Guest { GuestFirstName = "Kennan", GuestLastName = "Ciottoi", Adress = "9921 Holy Cross Crossing",
					City = "Stockholm", PostCode = "38680-000", Country = "Brazil", Email = "kciottoi1@t-online.de", Phone = "560-917-1312" },

				new Guest { GuestFirstName = "Meggy", GuestLastName = "Flann", Adress = "8528 Darwin Park",
					City = "Stockholm", PostCode = "114 49", Country = "Sweden", Email = "mflann2@blogger.com", Phone = "181-757-8748" },

				new Guest { GuestFirstName = "Taryn", GuestLastName = "Duinbleton", Adress = "2168 Holy Cross Pass,Qianfoling",
					City = "Qianfoling", PostCode = "45467", Country = "China", Email = "tduinbleton3@gravatar.com", Phone = "539-339-6374" },

				new Guest { GuestFirstName = "Sam", GuestLastName = "Li", Adress = "443 Glass st",
					City = "Vancouver", PostCode = "34334", Country = "Chanada", Email = "sanku@gmail.com", Phone = "778-454-3454" },

				new Guest { GuestFirstName = "Karen", GuestLastName = "Smith", Adress = "4545 Victoria ave",
					City = "New York", PostCode = "34334", Country = "America", Email = "karensmith34@gmail.com", Phone = "343-454-2333" },

			};


			context.Guests.AddRange(guestList);
			context.SaveChanges();


			List<RoomType> roomTypeList = new List<RoomType>()
			{
				new RoomType{RoomTypeName = "Single Room", Capacity = 1, PricePerNight = 100 },
				new RoomType{RoomTypeName = "Double Room", Capacity = 3, PricePerNight = 300},
				new RoomType{RoomTypeName = "Twin Room", Capacity = 3, PricePerNight = 300},
				new RoomType{RoomTypeName = "King Room", Capacity = 4, PricePerNight = 400},
			
			};

			context.RoomTypes.AddRange(roomTypeList);
			context.SaveChanges();


			List<Room> roomList = new List<Room>()
			{
				new Room{RoomTypeId = 1, Status = "Occupied"},
				new Room{RoomTypeId = 2, Status = "Vacant"},
				new Room{RoomTypeId = 2, Status = "Vacant"},
				new Room{RoomTypeId = 4, Status = "Vacant"}
			};

			context.Rooms.AddRange(roomList);
			context.SaveChanges();


            List<Reservation> reservationList = new List<Reservation>()
            {
                new Reservation{GuestId = 1, RoomId = 1, ReservationDate = "2010-01-01" , CheckInDate = "2010-01-02",CheckOutDate = "2010-01-03", NumberOfGuest = 1, NumberOfNight = 1},
			    new Reservation{GuestId = 2, RoomId = 2, ReservationDate = "2020-01-01", CheckInDate = "2020-01-02", CheckOutDate = "2020-01-03", NumberOfGuest = 2, NumberOfNight = 1},
				new Reservation{GuestId = 4, RoomId = 3, ReservationDate = "2020-01-01", CheckInDate = "2020-01-02", CheckOutDate = "2020-01-04", NumberOfGuest = 2, NumberOfNight = 2},
				new Reservation{GuestId = 4, RoomId = 3, ReservationDate = "2020-10-23", CheckInDate = "2020-12-02", CheckOutDate = "2020-12-10", NumberOfGuest = 2, NumberOfNight = 8}


			};

            context.Reservations.AddRange(reservationList);
            context.SaveChanges();

			List<Payment> paymentsList = new List<Payment>()
			{
				new Payment{ReservationId = 1, GuestId = 1, Amount = 100, PaymentType = "VISA"},
			};

			context.Payments.AddRange(paymentsList);
			context.SaveChanges();


			guestList[0].Reservations.Add(reservationList[0]);
			guestList[1].Reservations.Add(reservationList[1]);

			context.SaveChanges();
		} 
	}	
	
}
