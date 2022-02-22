using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
