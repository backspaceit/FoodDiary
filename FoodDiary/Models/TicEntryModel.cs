using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodDiary.Models
{
    public class TicEntryModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Frequency { get; set; }
        public string Type { get; set; }
        public string TimeODay { get; set; }
    }
}