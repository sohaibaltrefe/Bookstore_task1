using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models.Category
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime UpdateOn { get; set; } = DateTime.Now;

    }
}
