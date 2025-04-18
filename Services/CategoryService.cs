
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Services
{
    public class CategoryService
    {
        public static CategoryModel[] Categories { get; private set; } = [];

        static CategoryService()
        {
            Categories = [
                new CategoryModel(1, "Work", "work.png"),
                new CategoryModel(2, "Home", "home_tasks.png"),
                new CategoryModel(3, "School", "school.png"),
                new CategoryModel(4, "Other", "other.png"),

                ];

        }



    }
}
