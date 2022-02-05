using System.Collections.Generic;

namespace PieShop.Models
{
    /// <summary>
    /// Interface for set Categories for Pies
    /// </summary>
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
