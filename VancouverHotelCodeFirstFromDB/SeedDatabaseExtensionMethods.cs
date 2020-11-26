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

			// another way to reinitialize the database, resetting everything and zeroing out data

			//Database.SetInitializer(new DropCreateDatabaseAlways<StudentRegistrationEntities>());
			//context.Database.Initialize(true);        

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

			};


			context.Guests.AddRange(guestList);
			context.SaveChanges();


			List<RoomType> roomTypeList = new List<RoomType>()
			{
				new RoomType{RoomTypeName = "Single Room", Status = "Occupied", Capacity = 1, PricePerNight = 100 },
				new RoomType{RoomTypeName = "Double Room", Status = "Vacant", Capacity = 2, PricePerNight = 200}
			};

			context.RoomTypes.AddRange(roomTypeList);
			context.SaveChanges();


			List<Room> roomList = new List<Room>()
			{
				new Room{RoomTypeId = 1},
				new Room{RoomTypeId = 2}
			};

			context.Rooms.AddRange(roomList);
			context.SaveChanges();


            List<Reservation> reservationList = new List<Reservation>()
            {
                new Reservation{GuestId = 1, RoomId = 1 }, //ReservationDate = "2010-01-01", CheckInDate = "2010-01-02",CheckOutDate = "2010-01-03", NumberOfGuest = 1},
			    new Reservation{GuestId = 2, RoomId = 2, } //ReservationDate = "2020-01-01", CheckInDate = "2020-01-02", CheckOutDate = "2020-01-03", NumberOfGuest = 2}

			};

            context.Reservations.AddRange(reservationList);
            context.SaveChanges();

			List<Payment> paymentsList = new List<Payment>()
			{
				new Payment{ReservationId = 1, GuestId = 1, Amount = 100, PaymentType = "VISA"},
				new Payment{ReservationId = 2, GuestId = 2, Amount = 200, PaymentType = "Credit"}
			};

			context.Payments.AddRange(paymentsList);
			context.SaveChanges();


			guestList[0].Reservations.Add(reservationList[0]);
			guestList[1].Reservations.Add(reservationList[1]);



			context.SaveChanges();
		} 
	}	
	
}
