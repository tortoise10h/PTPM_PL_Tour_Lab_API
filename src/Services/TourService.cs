using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using src.Helpers;

namespace src.Services
{
    public interface ITourService
    {
        Task<bool> ValidateExistTour(int Id);
    }

    public class TourService : ITourService
    {
        private readonly DataContext _context;

        public TourService(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> ValidateExistTour(int Id)
        {
            var tour = await _context.Tours
                .SingleOrDefaultAsync(
                    t => t.Id == Id &&
                    t.IsDeleted == false
                );
            if (tour == null)
            {
                return false;
            }
            return true;
        }
    }
}