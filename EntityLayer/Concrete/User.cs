using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string UserMail { get; set; }
        [StringLength(20)]
        public string UserPassword { get; set; }
        [StringLength(500000)]
        public string UserImage { get; set; }
        public int StreetID { get; set; }
        public int CommentID { get; set; }
        public virtual Comment Comments { get; set; }
    }
}
