using System;
using System.Threading.Tasks;
using src.Entities;
using src.Helpers;

namespace src.Services
{
    public interface ITourCategoryService
    {
        TourCategory CreateTourCategory();
    }

    public class TourCategoryService : ITourCategoryService
    {
        public readonly DataContext _context;

        public TourCategoryService(DataContext context)
        {
            _context = context;
        }

        public TourCategory CreateTourCategory()
        {
            return new TourCategory {
                Id = 1,
                Name = "High quality tour"
            };
        }
    }
}