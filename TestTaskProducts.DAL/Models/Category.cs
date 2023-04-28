using System.ComponentModel.DataAnnotations;


namespace TestTaskProducts.DAL.Models
{
    /// <summary>
    /// Any category
    /// </summary>
    public class Category
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Category name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        ///List products of category
        /// </summary>
        public List<Product> CategoryProducts { get; set; } = new List<Product>();
    }
}
