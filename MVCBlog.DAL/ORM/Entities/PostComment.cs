using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlog.DAL.ORM.Entities
{
    public class PostComment : Base
    {
        [Required]
        public string CommentContent { get; set; }


        public bool CommentConfirmed { get; set; }

        public int PostID { get; set; }

        [ForeignKey("PostID")]
        public Post Post { get; set; }

        public int WebUserID { get; set; }
        [ForeignKey("WebUserID")]
        public virtual WebUser WebUser { get; set; }
    }
}
