using System;
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

  partial class Room
  {
		/// <summary>
		/// For debugging
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			VancouverHotelEntities context = new VancouverHotelEntities();

			RoomType roomType =  context.RoomTypes.Find(RoomTypeId);

			return RoomId + ": " + roomType.RoomTypeName + " " + roomType.Status;
		}
  }





}
