using System.Collections.Generic;

namespace XML
{
    public class Search
    {
        #region init

        public string name = null;
        public string faculty = null;
        public string department = null;
        public string section = null;
        public string cathedra = null;
        public string audience = null;
        public string curriculum = null;
        public List<string> students = null;

        #endregion init 
        public Search() { }
        public Search(string[] data)
        {
            name = data[0];
            department = data[1];
            section = data[2];
            cathedra = data[3];
            audience = data[4];
            curriculum = data[5];
            faculty = data[6];
            students = new List<string>();
        }
        #region Comparison
        public bool Compare(Search obj)
        {
            if ((this.name == obj.name)
                && (this.faculty == obj.faculty)
                && (this.department == obj.department)
                && (this.section == obj.section)
                && (this.cathedra == obj.cathedra)
                && (this.audience == obj.audience)
                && (this.curriculum == obj.curriculum)
                && (this.students == obj.students))
            {
                return true;
            }
            else
                return false;
        }
        #endregion Comparison
    }
}
