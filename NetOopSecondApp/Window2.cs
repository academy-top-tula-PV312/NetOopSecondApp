using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOopSecondApp
{
    public partial class Window
    {
        partial void Load()
        {
            Console.WriteLine("Wondow loading to memory");
        }

        public void Close()
        {
            Console.WriteLine("Window close");
        }
    }
}
