﻿namespace Leave_Management.Data.Migrations
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }

        public int DefaultDays { get; set; }

    }
}
