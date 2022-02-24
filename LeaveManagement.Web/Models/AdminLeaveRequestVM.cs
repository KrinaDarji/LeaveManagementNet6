using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Models
{
    public class AdminLeaveRequestVM
    {
        [Display(Name = "Total Number Of Requests")]
        public int TotalRequests { get; set; }
        [Display(Name = "Approved Requests")]
        public int Approved { get; set; }
        [Display(Name = "Pending Requests")]
        public int Pending { get; set; }
        [Display(Name = "Rejected Requests")]
        public int Rejected { get; set; }
        public List<LeaveRequestVM> LeaveRequests{ get; set; }
    }
}
