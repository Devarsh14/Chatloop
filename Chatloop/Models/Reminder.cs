using System;

namespace Chatloop.Models
{
    public class Reminder
    {
       public bool RemindOnMonday  { get; set; }
       public  DateTime RemindOnMondayTime  { get; set; }
        public bool RemindOnTuesday  { get; set; }
         public DateTime RemindOnTuesdayTime  { get; set; }
        public bool RemindOnWednesday  { get; set; }
        public DateTime RemindOnWednesdayTime  { get; set; }
        public bool RemindOnThursday  { get; set; }
       public DateTime RemindOnThursdayTime  { get; set; }
        public bool RemindOnFriday  { get; set; }
        public DateTime RemindOnFridayTime  { get; set; }
        public bool RemindOnSaturday  { get; set; }
        public DateTime RemindOnSaturdayTime  { get; set; }

    }
}