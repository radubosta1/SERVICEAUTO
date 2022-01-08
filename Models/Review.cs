using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceAuto1.Models
{
    public class Review
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        [DataType(DataType.Date)]
        public  DateTime Data  { get; set; }
        public string Recenzie { get; set; }
    }
}
