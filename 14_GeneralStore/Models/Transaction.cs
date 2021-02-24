using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _14_GeneralStore.Models
{
    // Transaction table is a "Joining Table"
    // Because it connects two other tables (Product and Customer) with inner joins (foreign keys)
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateOfTransaction { get; set; }

        // Foreign Key represents an "INNER JOIN" 
        [Required]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        // This sets up the exact same type of relationship, just does it differently
        [Required]
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}