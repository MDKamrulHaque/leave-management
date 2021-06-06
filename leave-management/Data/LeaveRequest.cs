using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Data
{
    public class LeaveRequest
    {
        [Key]
        public int Id { get; set; }

        [ForeingKey("RequestingEmployeeId")]

        public Employee RequestingEmployee { get; set; }

        public string RequestingEmployeeId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        [ForeingKey("LeaveTypeId")]

        public LeaveType LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        public DateTime DateRequested { get; set; }

        public string RequestComments { get; set; }
        
        public DateTime DateActioned { get; set; }

        public bool? Approved { get; set; }

        public bool Cancelled { get; set; }
        [ForeingKey("ApprovedById")]

        public Employee ApprovedBy { get; set; }

        public string ApprovedById { get; set; }



    }
}
