using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceAuto1.Models
{
    public class Programare
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        [DataType(DataType.Date)]
        public DateTime data { get; set; }
        public int SpecializareID { get; set; }
    }
}
