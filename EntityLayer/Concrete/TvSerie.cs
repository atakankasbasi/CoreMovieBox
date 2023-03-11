using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TvSerie
    {
        [Key]
        public int SerieID { get; set; }
        [StringLength(40)]
        public string? Title { get; set; }
        [StringLength(600)]
        public string? Content { get; set; }
        public DateTime History { get; set; }
        public string? HeaderImage { get; set; }
        public string? Image1 { get; set; }
        public int? SerieGenre { get; set; }
        public int? SerieCategory { get; set; }
        public int? SerieScore { get; set; }
        [StringLength(20)]
        public string? SerieYear { get; set; }
        public int? SerieTime { get; set; }
        public bool? Status { get; set; }

        public int? CategoryID { get; set; }
        public Category? Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
