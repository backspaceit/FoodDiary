using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodDiary.Models
{
    public class FoodEntryModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<TimeOfDayModel> TimeOfDay { get; set; }


    }
}