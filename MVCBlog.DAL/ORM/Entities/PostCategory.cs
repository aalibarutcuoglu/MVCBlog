using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlog.DAL.ORM.Entities
{
    public class PostCategory : Base
    {
        public string PostCategoryName { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}
