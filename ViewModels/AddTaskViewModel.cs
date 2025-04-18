using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager.ViewModels
{
    public partial class AddTaskViewModel : ObservableObject
    {

        
        public CategoryModel[] Categories { get; set; } = CategoryService.Categories;

       
            
        
    }



}

