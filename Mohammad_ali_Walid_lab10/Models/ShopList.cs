using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Mohammad_ali_Walid_lab10.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
