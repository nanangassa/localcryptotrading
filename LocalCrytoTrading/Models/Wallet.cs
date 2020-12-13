using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalCrytoTrading.Models
{
    public class Wallet
    {
        public Wallet()
        {

        }

        [Required]
        [Key]
        public long WalletID { get; set; }

        [ForeignKey("Standard")]
        public long UserID { get; set; }

        [Required]
        [ForeignKey("Standard")]
        public string WalletName { get; set; }

        [Required]
        [ForeignKey("Standard")]
        public string WalletLabel { get; set; }

        [Required]
        [ForeignKey("Standard")]
        public decimal Balance { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Creation { get; set; }
    }
}

