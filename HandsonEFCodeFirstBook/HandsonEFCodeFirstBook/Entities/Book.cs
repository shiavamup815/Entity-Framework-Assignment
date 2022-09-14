using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandsonEFCodeFirstBook.Entities
{
    [Table("Books")]
    internal class Book
    {
        [Key] // Set Primary Key
        [StringLength(6)]
        [Column(TypeName ="char")]
        public string BookId { get; set; }
        [Required] // Set not null
        [StringLength(30)]
        [Column(TypeName ="varchar")]
        public string BookName { get; set; }
        public double? Price { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Author { get; set; }
    }
}
