using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlog.DAL.ORM.Entities
{
    public class PostLike : Base
    {
        public int PostID { get; set; }

        [ForeignKey("PostID")]
        public Post Post { get; set; }
    }
}
