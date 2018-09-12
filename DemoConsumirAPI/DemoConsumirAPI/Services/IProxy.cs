using DemoConsumirAPI.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsumirAPI.Services
{
    public interface IProxy
    {
        Task<List<Pie>> GetAllPies();
        Task<List<Pie>> GetPiesOfTheWeek();
        Task<Pie> GetPieById(int ID);
    }
}
