using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    internal class PersonName
    {
        public string Name { get; set; }
        public string PateralSuname { get; set; }
        public string MatenalSuname { get; set; }

        public PersonName(string name, string paternalSuname, string maternalSuname) 
        {
            this.Name = name;
            this.PateralSuname = paternalSuname;
            this.MatenalSuname = maternalSuname;
        }

        public override string ToString()
        {
            return  "Name: " + Name + " " + PateralSuname + " " + MatenalSuname;
                
        }

    }
}
