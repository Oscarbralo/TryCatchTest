using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchModel
{
    public class Person
    {
        private string name;
        private string id;
        private string residence;

        public string Residence
        {
            get { return residence; }
            set { residence = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(string name, string id, string residence)
        {
            this.Name = name;
            this.ID = id;
            this.Residence = residence;
        }
    }
}
