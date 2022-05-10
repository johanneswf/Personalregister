using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Personal
    {
        public string förnamn;
        public string efternamn;
        public double lön;

        public Personal(string förnamn, string efternamn, double lön)
        {
            this.förnamn = förnamn;
            this.efternamn = efternamn;
            this.lön = lön;
        }
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
