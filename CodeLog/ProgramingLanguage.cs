using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLog
{
    public class ProgramingLanguage
    {
        private int id;
        private String name;

        public ProgramingLanguage(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
