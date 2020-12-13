using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations.Schema;

namespace LocalCrytoTrading.Models
{
    public class User
    {
        //internal string roleid;

        public User()
        {

        }

        [Key]
        [Required]
        public long UserID { get; set; }

        //[System.ComponentModel.DataAnnotations.Schema.ForeignKey("Standard")]
        //[Required]
        //public string RoleID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[Required]
        public Boolean Verified { get; set; }

        public string BitcoinWallet{ get; set; }

        //[Required]
        //[DataType(DataType.Date)]
        //public DateTime Creation { get; set; }

        //[Required]
        //[DataType(DataType.Date)]
        //public DateTime DateOfbirth { get; set; }

        //[Required]
        //[StringLength(1000)]
        //public string City { get; set; }

        //[Required]
        //[StringLength(1000)]
        //public string Address { get; set; }

        //[Required]
        //[StringLength(1000)]
        //public string Postalcode { get; set; }

        //[Required]
        //[StringLength(1000)]
        //public string Country { get; set; }

        //[NotMapped]
        //public virtual ICollection<string> Reviews { get; set; }

        //[NotMapped]
        //public virtual ICollection<Wallet> Wallets { get; set; }

        //[NotMapped]
        //public virtual ICollection<Trades> Trades { get; set; }
    }
}

