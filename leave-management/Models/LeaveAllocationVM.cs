﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class LeaveAllocationVM
    {
        public int Id { get; set; }
        [Required]
        public int NumberOfdays { get; set; }
        public DateTime DateCreated { get; set; }
        
        public EmployeeVM Employee { get; set; }
        public string EmployeeId { get; set; }

        public DetailsLeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public IEnumerable<SelectList> Employees { get; set; }

        public IEnumerable<SelectList> LeaveTypes { get; set; }
    }
}
