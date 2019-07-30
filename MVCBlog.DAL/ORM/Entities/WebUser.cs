using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlog.DAL.ORM.Entities
{
    public class WebUser : Base
    {
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual List<PostComment> PostComments { get; set; }

        public virtual List<PostLike> PostLike { get; set; }

        public virtual PostImage PostImage { get; set; }

    }
}
