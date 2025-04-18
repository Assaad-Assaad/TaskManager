using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Utils
{
    public static class DateFilters
    {
        public static List<string> All => new() { "Nearest → Farthest", "Farthest → Nearest" };
    }
}
