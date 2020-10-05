using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using src.Helpers;

namespace src.Services
{
    public interface ITourDetailService
    {
        Task<bool> ValidateExistTourAttractionIds(List<Guid> Ids);
    }
    public class TourDetailService : ITourDetailService
    {
        private readonly DataContext _context;

        public TourDetailService(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> ValidateExistTourAttractionIds(List<Guid> Ids)
        {
            var uniqueTouristAttractionIds = Ids
                .Distinct()
                .ToList();

            var touristAttractions = await _context.TouristAttraction
                .Where(ta => uniqueTouristAttractionIds.Contains(ta.Id) &&
                    ta.IsDeleted == false)
                .ToListAsync();

            if (uniqueTouristAttractionIds.Count() != touristAttractions.Count())
            {
                return false;
            }

            return true;
        }
    }
}