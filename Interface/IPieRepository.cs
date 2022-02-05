using System.Collections.Generic;

namespace PieShop.Models
{
    /// <summary>
    /// Interface for gets all Pies
    /// </summary>
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieId);
    }
}
