using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Title must be between 2 and 50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Description must be between 2 and 200 characters")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }


        [Required(ErrorMessage = "Priority is required")]
        public PriorityLevel Priority { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }


        [Range(1, int.MaxValue, ErrorMessage = "Category selection is required")]
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
    }


    public enum PriorityLevel
    {
        High,
        Medium,
        Low
    }


}
