using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlog.DAL.ORM.Interface
{
    public interface IUserLog
    {
        int InsertedUserID { get; set; }

        int UpdatedUserID { get; set; }

        int? DeletedUserID { get; set; }
    }
}
