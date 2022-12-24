using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.AllClass
{
    public class Beslenme
    {
        [Key]
        public int ID { get; set; }
        public string FotoUrl { get; set; }
        public string Description { get; set; }
    }
}