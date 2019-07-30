using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlog.DAL.ORM.Entities
{
    public class Post : Base
    {
        public int PostCategoryID { get; set; } 

        [ForeignKey("PostCategoryID")]
        public virtual PostCategory PostCategory { get; set; }

        public virtual List<PostLike> PostLike { get; set; }

        public virtual List<PostComment> PostComment { get; set; }

       

    }
}
