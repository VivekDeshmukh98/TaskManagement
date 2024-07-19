using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public string Attachments { get; set; }
        public string Notes { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
