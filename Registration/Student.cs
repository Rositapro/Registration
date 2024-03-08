using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    internal class Student : Persona
    {
        public string Registration { get; set; }
        public string Career { get; set; }
        public string Avarage { get; set; }

        public Student(string Name, string PaternalName, string maternalSuname, string dataTime, string registrstion, string career, string average):base(Name, PaternalName, maternalSuname,dataTime )
        {
            this.Registration = registrstion;
            this.Career = career;
            this.Avarage = average;

        }

        //public Student( string dateTime, string name, string paternalSuname, string maternalSuname, string v1, string v2) : base( dateTime, name, paternalSuname, maternalSuname)
        //{
        //}

        public override string ToString()
        {
            return base.ToString() + " " + Registration + " " + Career + " " + Avarage;

        }
    }
}
