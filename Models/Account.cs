using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Invoice.Models
{
    public enum AccountStatus
    {
        [Description("停用")]
        Disable = 0,

        [Description("啟用")]
        Activity = 1,
    }

    [Table("Account")]
    public class Account
    {
        //系統流水編號
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }

        [Key]
        [Required]
        public Guid Account_ID { get; set; }

        //申請時間
        [Required]
        public DateTime Application_Date { get; set; }

        [Required]
        [DisplayName("帳號名稱（Email）")]
        public string Login_Name { get; set; }

        [Required]
        [DisplayName("密碼")]
        public string Password { get; set; }

        [DisplayName("姓名")]
        public string Name { get; set; }

        [Required]
        [DisplayName("帳號狀態")]
        public int Account_Status { get; set; }

        [Required]
        public int Role_ID { get; set; }

        public virtual Account_Role Account_Role { get; set; }
    }
}