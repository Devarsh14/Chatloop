using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chatloop.Models;

namespace Chatloop.IDataServices
{
   public  interface IReminderManagment
    {
        IList<Reminder> RemindersMangementList(Reminder reminder);

    }

    public class ReminderManagement : IReminderManagment
    {
        public IList<Reminder> reminders = new List<Reminder> ();
        public IList<Reminder> RemindersMangementList(Reminder reminder)
        {

            reminders.Add(reminder);
            return reminders;
        }
    }
}
