using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ToodeteProgramm
{
    public class Category
    {
        public int CategoryID {  get; set; }
        public string? CategoryName { get; set; }
        public virtual ObservableCollectionListSource<Category> Products { get; set; } = new();
    }
}
