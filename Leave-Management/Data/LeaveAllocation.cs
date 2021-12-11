using Leave_Management.Data.Migrations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leave_Management.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; } //foreign key of a Leave type
        public int LeaveTypeId { get; set; } //this is the foreign key Id of the leave type: NOte the name
        public string EmployeeId { get; set; }

    }
}
