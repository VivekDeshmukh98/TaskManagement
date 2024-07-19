using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Nullable foreign key for self-referencing relationship
        public int? ManagerId { get; set; }

        [ForeignKey("ManagerId")]
        public Employee Manager { get; set; }

        public List<Employee> TeamMembers { get; set; }
        public List<TaskItem> Tasks { get; set; }
    }
}
