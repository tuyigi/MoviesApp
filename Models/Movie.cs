using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesApp.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)] 
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string Poster { get; set; }
        
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}