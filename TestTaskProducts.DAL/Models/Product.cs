using System.ComponentModel.DataAnnotations;

namespace TestTaskProducts.DAL.Models
{
    /// <summary>
    /// Any Product
    /// </summary>
    public class Product
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Id of category
        /// </summary>
        public int CategoryId { get; set; }
    }
}
