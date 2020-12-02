﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VancouverHotelCodeFirstFromDB
{
  partial class Guest
  {
		/// <summary>
		/// For debugging
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return GuestId + ": " + GuestFirstName + " " + GuestLastName;
		}
   }

  partial class RoomType
  {
        /// <summary>
        /// For debugging
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            VancouverHotelEntities context = new VancouverHotelEntities();

            RoomType roomType = context.RoomTypes.Find(RoomTypeId);
            return RoomTypeId + ": " + roomType.RoomTypeName + " " + roomType.Status;
        }
    }
	partial class Reservation
    { 

		public override string ToString()
        {

			VancouverHotelEntities context = new VancouverHotelEntities();
			
			Room room = context.Rooms.Find(RoomId);
			RoomType roomType = context.RoomTypes.Find(room.RoomTypeId);
			return ReservationId + ":" + roomType.RoomTypeName + "$" + roomType.PricePerNight * NumberOfNight;
        }
	
	}






}
