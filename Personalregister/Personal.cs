using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Personal
    {
        private string förnamn;
        private string efternamn;
        private double lön;

        public Personal() { }
        public string Förnamn
        {
            get { return förnamn; }
            set { förnamn = value; }
        }
        public string Efternamn
        {
            get { return efternamn; }
            set { efternamn = value; }
        }
        public double Lön
        {
            get { return lön; }
            set { lön = value; }
        }
    }
}
