//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCAngularHotelBooking
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoomBooking
    {
        public int BookingID { get; set; }
        public Nullable<int> RoomID { get; set; }
        public string BookedDateFR { get; set; }
        public string BookedDateTO { get; set; }
        public string BookingStatus { get; set; }
        public string PaymentStatus { get; set; }
        public string AdvancePayed { get; set; }
        public string TotalAmountPayed { get; set; }
    }
}
