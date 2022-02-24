using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Models
{
    public class EmployeeLeaveRequestViewVM
    {
        public EmployeeLeaveRequestViewVM(List<LeaveAllocationVM> leaveAllocations, List<LeaveRequestVM> leaveRequests)
        {
            this.leaveAllocations = leaveAllocations;
            LeaveRequests = leaveRequests;
        }

        public List<LeaveAllocationVM> leaveAllocations { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }
        
    }
}
