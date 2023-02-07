using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testowe_Winforms_Devexpress.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public int SupplierId { get; set; }
        public int? StorageId { get; set; }
        public virtual Storage Storage { get; set; }

        public string Name { get; set; }
        [Range(0, int.MaxValue - 1, ErrorMessage = "Can't be less than 0!")]
        public int UnitsAtBeginning { get; set; }
        [Range(0, int.MaxValue - 1, ErrorMessage = "Can't be less than 0!")]
        public int UnitsLeft { get; set; }

        public decimal Netto{ get; set; }
        public decimal Brutto { get; set; }
        public DateTime ArrivalDate { get; set; }
    }

}
