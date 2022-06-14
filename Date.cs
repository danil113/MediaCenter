using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КурсС4
{
    class Date
    {
        public static int Access { get; set; }
        public static int UserID { get; set; }
        public static bool isManager() => Access == 0;
        public static bool isAdmin() => Access == 1;
    }
}
