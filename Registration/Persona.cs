using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    internal class Persona : PersonName
    {
      
        public string DateTime { get; set; }

        public Persona(string name, string paternalSuname, string maternalSuname, string dateTime) : base(name, paternalSuname, maternalSuname)
        {
            
            this.DateTime = dateTime;
            
        }

        public override string ToString()
        {
            return base.ToString()+ " " + DateTime;

        }

    }
}
