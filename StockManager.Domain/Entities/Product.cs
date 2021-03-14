using System;
using System.ComponentModel.DataAnnotations;

namespace StockManager.Domain.Entities
{
    public class Product
    {
        [Key]
        public string SN { get; set; }
        public string PCode { get; set; }
        public string Name { get; set; }
        public DateTime RDate { get; set; }
        public bool InStock { get; set; }
    }
}
