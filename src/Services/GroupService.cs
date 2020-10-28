using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using src.Helpers;

namespace src.Services
{
    public interface IGroupService
    {
        Task<bool> ValidateExistGroup(int Id);
    }

    public class GroupService : IGroupService
    {
        private readonly DataContext _context;

        public GroupService(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> ValidateExistGroup(int Id)
        {
            var group = await _context.Group.SingleOrDefaultAsync(
                g => g.Id == Id &&
                g.IsDeleted == false
            );

            if (group == null)
            {
                return false;
            }

            return true;
        }
    }
}
