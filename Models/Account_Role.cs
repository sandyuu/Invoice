using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Invoice.Models
{
    public enum Identity
    {
        [Description("管理者")]
        Admin = 0,

        [Description("註冊會員")]
        Member = 1,
    }

    [Table("Account_Role")]
    public class Account_Role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account_Role()
        {
            Account = new HashSet<Account>();
        }

        [Key]
        public int Role_ID { get; set; }

        //Admin, Member, Organization
        public string Role_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Account { get; set; }
    }
}