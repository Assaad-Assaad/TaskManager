using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public List<TaskModel> Tasks { get; set; } = new List<TaskModel>();



        public CategoryModel(int Id, string Name, string Image)
        {
            this.Id = Id;
            this.Name = Name;
            this.Image = Image;
        }
    }
}
