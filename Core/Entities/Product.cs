using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        
        public int IdCat { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        [ForeignKey(nameof(Product.IdCat))]
        public Category Category { get; set; }
    }
}
