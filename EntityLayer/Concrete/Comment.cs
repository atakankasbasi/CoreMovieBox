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

        [StringLength(30)]
        public string Username { get; set; }

        public DateTime Date { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        public bool Status { get; set; }

        public int MovieID { get; set; }
        public Movie Movie { get; set; }
        public int SerieID { get; set; }
        public TvSerie TvSerie { get; set; }
    }
}
