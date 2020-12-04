using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLog
{
    public class CodeSnippet
    {
        private int id;
        private int programinglanguage_id;
        private String name;
        private String code;
        private String description;

        public CodeSnippet(int id, int programinglanguage_id, string name, string code, string description)
        {
            this.id = id;
            this.programinglanguage_id = programinglanguage_id;
            this.name = name;
            this.code = code;
            this.description = description;
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int ProgramingLanguage_Id
        {
            get { return this.programinglanguage_id; }
            set { this.programinglanguage_id = value; }
        }
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public String Code
        {
            get { return this.code; }
            set { this.code = value; }
        }
        public String Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
