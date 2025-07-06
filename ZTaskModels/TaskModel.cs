using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTaskModels
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AssignedToUser { get; set; }
        public int Department { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public DateTime RemainderDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Notes { get; set; }
    }
}
