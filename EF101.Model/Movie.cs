using System;
using System.ComponentModel.DataAnnotations;

namespace EF101.Model
{
    public class Movie
    {
        public int ID { get; set; }
        //public int MovieKey { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    // DataAnnotations
    //public class Movie
    //{
    //    [Key]
    //    public int ID { get; set; }
    //    [MaxLength(256)]
    //    public string Title { get; set; }
    //    public DateTime? ReleaseDate { get; set; }
    //    [MaxLength(64)]
    //    public string Genre { get; set; }
    //    public decimal? Price { get; set; }
    //}
}
