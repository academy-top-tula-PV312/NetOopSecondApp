using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOopSecondApp
{
    public partial class Window
    {
        partial void Load();
        public void Open()
        {
            Load();
            Console.WriteLine("Window open");
        }
    }
}
