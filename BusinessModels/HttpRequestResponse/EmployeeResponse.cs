using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModels.HttpRequestResponse
{
    public class EmployeeResponse
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Int32 Department { get; set; }
        public string DepartmentName { get; set; }
        public DateTime Dob { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
