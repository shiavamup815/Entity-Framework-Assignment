using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsonEFCodeFirstBook.Entities
{
    [Table("Order")]
    internal class Order
    {
        [Key]
        public int OrderId { get; set; }

        public string OrderDate { get; set; }
        [StringLength(6)]
        [Column(TypeName ="Char")]
        [ForeignKey("Book")]
        public string BookId { get; set; }

        public Book Book { get; set; } // Navigation Property
    }
}
