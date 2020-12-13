using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalCrytoTrading.Models
{
    public class Advertisement
    {
        public Advertisement()
        {

        }

        [Key]
        [Required]
        public string AvertisementID { get; set; }

        [ForeignKey("Standard")]
        [Required]
        public long Userid { get; set; }

        [Required]
        [Column(TypeName="decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(5)]
        public string Currency { get; set; }

        [Required]
        [StringLength(50)]
        public string Profit { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Creation { get; set; }

        public string PaymentMethod { get; set; }

        //[Required]
        //[Column(TypeName = "decimal(18, 2)")]
        //public Decimal Creation { get; set; }
    }
}
