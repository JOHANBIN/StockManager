using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockManager.Domain.Entities
{
    public class UniqueNo
    {
        [Key]
        public int Unique_No { get; set; }
        public string Prefix { get; set; }
    }
}
