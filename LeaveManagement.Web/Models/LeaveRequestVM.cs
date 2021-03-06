using LeaveManagement.Web.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Models
{
    public class LeaveRequestVM : LeaveRequestCreateVM
    {
        public int Id { get; set; }
       
        [ForeignKey("LeaveTypeId")]
        public LeaveTypeVM LeaveType { get; set; }
       
        public DateTime DateRequested { get; set; }
      
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        public string? RequestingEmployeeId { get; set; }
        public EmployeeListVM Employee { get; set; }
    }
}
