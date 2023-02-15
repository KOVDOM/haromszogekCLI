using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromszogekCLI
{
    public class haromszogadatok
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public haromszogadatok(string h)
        {
            string[] adatok = h.Split(' ');
            this.a = int.Parse(adatok[0]);
            this.b = int.Parse(adatok[1]);
            this.c = int.Parse(adatok[2]);
        }
    }
}
