using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models.AllClass
{
    public class Destek
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } 
        public string Mail { get; set; }
        public string Message { get; set; }
        public string Price { get; set; }


    }
}