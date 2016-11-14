using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodDiary.Models
{
    public class BehaveEntryModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string TimeOfDay { get; set; }

    }
}