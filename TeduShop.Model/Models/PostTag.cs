using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(Order = 1)] //th khi co 2 key, khi do vao db no ko hieu key nao nen phai them cai nay
        public int PostID { set; get; }

        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar", Order = 2)]
        public string TagID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}
