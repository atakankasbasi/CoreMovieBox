using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        [StringLength(40)]
        public string? Title { get; set; }
        [StringLength(600)]
        public string? Content { get; set; }
        public DateTime? History { get; set; }
        public string? HeaderImage { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }
        public int? MovieGenre { get; set; }
        public int? MovieCategory { get; set; }
        public int? MovieScore { get; set;}
        [StringLength(20)]
        public string? MovieYear { get; set;}
        public int? MovieTime { get; set; }
        public bool? Status { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
