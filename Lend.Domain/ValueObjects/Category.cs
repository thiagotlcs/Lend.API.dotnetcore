using Lend.Domain.Entities;

namespace Lend.Domain.ValueObjects
{
    public class Category
    {
        public Category() { }

        public ICollection<Product> Products { get; set; }
    }
}
