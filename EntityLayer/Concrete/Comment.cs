using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [StringLength(50000)]
        public string CommentContents { get; set; }
        public DateTime CommentDate { get; set; }
        public ICollection<User> users { get; set; }
    }
}
