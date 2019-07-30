using MVCBlog.DAL.ORM.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlog.DAL.ORM.Entities
{
    public class AdminUser : Base,IUserLog
    {
        [Required]
        [StringLength(100)]
        public string EMail { get; set; }
        [Required]
        public string Password { get; set; }
        public int InsertedUserID { get; set; }
        public int UpdatedUserID { get; set; }
        public int? DeletedUserID { get; set; }
    }
}
