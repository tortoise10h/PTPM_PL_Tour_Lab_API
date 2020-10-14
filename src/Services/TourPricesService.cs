using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using Microsoft.EntityFrameworkCore;
using src.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Services
{
    public interface ITourPricesService
    {
        Task<string> IsTourPriceDateConflict(int tourId, int tourPriceId, DateTime startDate, DateTime endDate);
        Task<string> CheckConflictTimeWhenCreateTourPrice(int tourId, DateTime startDate, DateTime endDate);
     }

    public class TourPricesService: ITourPricesService
    {
        private readonly DataContext _context;

        public TourPricesService(DataContext context)
        {
            _context = context;
        }

        public async Task<string> IsTourPriceDateConflict(int tourId, int tourPriceId, DateTime startDate, DateTime endDate)
        {
            string errorResponse = "";

            var conflictDateTourPrice = await _context.TourPrice
                .SingleOrDefaultAsync(tp =>
                    tp.TourId == tourId &&
                    tp.Id != tourPriceId &&
                    tp.IsDeleted == false &&
                    tp.StartDate <= startDate && tp.EndDate >= startDate ||
                    tp.StartDate <= endDate && tp.EndDate >= endDate || 
                    tp.StartDate >= startDate && tp.EndDate <= endDate);

            if (conflictDateTourPrice != null)
            {
                // This mean new date of tour price is conflicted with the other
                if (conflictDateTourPrice.StartDate <= startDate && conflictDateTourPrice.EndDate >= startDate)
                {
                    errorResponse += $"The start date of price [{startDate}] is conflicted with another tour price [{conflictDateTourPrice.StartDate} - {conflictDateTourPrice.EndDate}]. ";
                }

                if (conflictDateTourPrice.StartDate <= endDate && conflictDateTourPrice.EndDate >= endDate)
                {
                    errorResponse += $"The end date of price [{endDate}] is conflicted with another tour price [{conflictDateTourPrice.StartDate} - {conflictDateTourPrice.EndDate}]";
                }

                if (conflictDateTourPrice.StartDate >= startDate && conflictDateTourPrice.EndDate <= endDate)
                {
                    errorResponse += $"There was a different tour price [{conflictDateTourPrice.StartDate} - {conflictDateTourPrice.EndDate}] during this time [{startDate} - {endDate}]";
                }
                 
                return errorResponse;
            }

            return errorResponse;
        }
        public async Task<string> CheckConflictTimeWhenCreateTourPrice(int tourId, DateTime startDate, DateTime endDate)
        {
            string errorResponse = "";

            var conflictDateTourPrice = await _context.TourPrice
                .SingleOrDefaultAsync(tp =>
                    tp.TourId == tourId &&
                    tp.IsDeleted == false &&
                    tp.StartDate <= startDate && tp.EndDate >= startDate ||
                    tp.StartDate <= endDate && tp.EndDate >= endDate || 
                    tp.StartDate >= startDate && tp.EndDate <= endDate);

            if (conflictDateTourPrice != null)
            {
                // This mean new date of tour price is conflicted with the other
                if (conflictDateTourPrice.StartDate <= startDate && conflictDateTourPrice.EndDate >= startDate)
                {
                    errorResponse += $"The start date of price [{startDate}] is conflict with another tour price [{conflictDateTourPrice.StartDate} - {conflictDateTourPrice.EndDate}]. ";
                }

                if (conflictDateTourPrice.StartDate <= endDate && conflictDateTourPrice.EndDate >= endDate)
                {
                    errorResponse += $"The end date of price [{endDate}] is conflict with another tour price [{conflictDateTourPrice.StartDate} - {conflictDateTourPrice.EndDate}]";
                }

                if (conflictDateTourPrice.StartDate >= startDate && conflictDateTourPrice.EndDate <= endDate)
                {
                    errorResponse += $"There was a different tour price [{conflictDateTourPrice.StartDate} - {conflictDateTourPrice.EndDate}] during this time [{startDate} - {endDate}]";
                }
                 
                return errorResponse;
            }

            return errorResponse;
        }
    }
}
