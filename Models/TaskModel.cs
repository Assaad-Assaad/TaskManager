using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class TaskModel
    {
        
        public int Id { get; set; }

        
        public string Title { get; set; }

        
        public DateTime DueDate { get; set; }

        
        public string Priority { get; set; }

        
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public CategoryModel? Category { get; set; }
    }
}
