using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuickRecipe.Data.Models
{
    [Table("products")]
    public class Product
    {
        [Column("productid")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("amount")]
        public double Amount { get; set; }
        [Column("recipe")]
        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public Recipe Parent { get; set; }
    }
}
