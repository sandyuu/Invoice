using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Invoice.Models
{
    [Table("Account_Role")]
    public class Account_Role
    {
        public Account_Role()
        {
            Account = new HashSet<Account>();
        }

        [Key]
        public int Role_ID { get; set; }

        //Admin, Member, Organization
        public string Role_Name { get; set; }

        public virtual ICollection<Account> Account { get; set; }
    }
}