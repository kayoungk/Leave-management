using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_management.Models
{
    public class LeaveRequestVM
    {
        public int Id { get; set; }
        public EmployeeVM RequestingEmployee { get; set; }
        public string RequestingEmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        public EmployeeVM ApprovedBy { get; set; }
        public string ApprovedById { get; set; }
    }

    public class AdminLeaveRequestViewVM 
    {
        public int TotalRequest { get; set; }
        public int ApprovedRequest { get; set; }
        public int PendingRequest { get; set; }
        public int RejectedRequest { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }
}
