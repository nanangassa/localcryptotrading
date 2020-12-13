using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalCrytoTrading.Models
{
    public class Trades
    {
        public Trades()
        {

        }

        [Key]
        [Required]
        public long TradeID { get; set; }

        [Required]
        //[ForeignKey("Standard")]
        public Advertisement Advertisement { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        //[ForeignKey("Standard")]
        public string BuyerID { get; set; }

        [Required]
        [StringLength(50)]
        //[ForeignKey("Standard")]
        public string SellerID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Creation { get; set; }

        [Required]
        //[ForeignKey("Standard")]
        public Wallet BuyerWallet { get; set; }

        public string BuyerReview { get; set; }

        ////[ForeignKey("Standard")]
        public Wallet SellerWallet { get; set; }

        public string SellerReview { get; set; }

        [Required]
        public TimeSpan Timer { get; set; }

        [Required]
        [ForeignKey("Standard")]
        public string ReferenceID { get; set; }
    }
}

