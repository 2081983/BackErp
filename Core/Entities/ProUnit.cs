using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ProUnit
    {
        [Key]
        public int UId { get; set; }
        [Required]
        public int ProId { get; set; }
        public string Barcode { get; set; }
        public int UmId { get; set; }
        [DataType("decimal(10,2)")]
        [Required]
        public decimal UfPrice { get; set; }
        [DataType("decimal(10,2)")]
        public decimal UsPrice { get; set; }
        [DataType("decimal(10,2)")]
        public decimal UtPrice { get; set; }
        [ForeignKey(nameof(UmId))]
        public Uom Uom { get; set; }

        [ForeignKey(nameof(ProId))]
        public Product  Product { get; set; }
    }
}
