using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffAddress { get; set; }
        public DateTime StaffDate { get; set; }
        public string StaffRole { get; set; }
        public bool StaffPrivilage { get; set; }
    }
}