using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateAdded { get; set; }

        public byte NumberInStock { get; set; }
    }
}