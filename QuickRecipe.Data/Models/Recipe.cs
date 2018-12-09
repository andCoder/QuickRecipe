using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickRecipe.Data.Models
{
    [Table("recipes")]
    public class Recipe
    {
        [Column("recipeid")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("preview")]
        public string PreviewUrl { get; set; }
        [Column("cooking_time")]
        public string TimeAmount { get; set; }
        [Column("portions")]
        public int Portions { get; set; }
        public ICollection<Step> Steps { get; set; } = new List<Step>();
    }
}