using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class CategoryModel
    {
      

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Image { get; set; }


        public List<TaskModel> Tasks { get; set; } = new List<TaskModel>();


        public CategoryModel(int id, string name, string image)
        {
            Id = id;
            Name = name;
            Image = image;
        }


    }

}

