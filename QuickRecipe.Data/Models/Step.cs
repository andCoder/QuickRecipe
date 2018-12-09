using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuickRecipe.Data.Models
{
    [Table("steps")]
    public class Step
    {
        [Column("stepid")]
        public int Id { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("image")]
        public string ImageUrl { get; set; }
        [Column("recipe")]
        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public Recipe Parent { get; set; }
    }
}
