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
        [StringLength(100)]
        public string Title { get; set; }
        [Column("description")]
        [StringLength(300)]
        public string Description { get; set; }
        [Column("cooking_time")]
        [StringLength(10)]
        public string TimeAmount { get; set; }
        [Column("portions")]
        public int Portions { get; set; }
        public ICollection<Step> Steps { get; set; } = new List<Step>();
    }
}