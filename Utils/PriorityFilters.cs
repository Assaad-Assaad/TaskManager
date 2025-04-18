using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Utils
{
    public static class PriorityFilters
    {
        public static List<string> All => new() { "All", "High", "Medium", "Low" };
    }
}
