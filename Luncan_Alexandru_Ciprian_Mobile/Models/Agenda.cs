using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Luncan_Alexandru_Ciprian_Mobile.Models
{
    public class Agenda
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
