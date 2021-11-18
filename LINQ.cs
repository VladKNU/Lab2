using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XML
{
    class LINQ : IParse
    {
        private List<Search> find = null;
        XDocument doc = new XDocument();

        public List<Search> AnalizeFile(Search mySearch, string path)
        {
            doc = XDocument.Load(@path);
            find = new List<Search>();
            List<XElement> matches = (from val in doc.Descendants("section")
                                      where
                                      ((mySearch.faculty == null || mySearch.faculty == val.Parent.Parent.Attribute("FCNAME").Value) &&
                                      (mySearch.department == null || mySearch.department == val.Parent.Attribute("DEPNAME").Value) &&
                                      (mySearch.section == null || mySearch.section == val.Attribute("SECNAME").Value) &&
                                      (mySearch.name == null || mySearch.name == val.Attribute("NAME").Value) &&
                                      (mySearch.cathedra == null || mySearch.cathedra == val.Attribute("CATHEDRA").Value) &&
                                      (mySearch.audience == null || mySearch.audience == val.Attribute("AUDIENCE").Value) &&
                                      (mySearch.curriculum == null || mySearch.curriculum == val.Attribute("CURRICULUM").Value))
                                      select val).ToList();
            foreach (XElement match in matches)
            {
                Search res = new Search
                {
                    faculty = match.Parent.Parent.Attribute("FCNAME").Value,
                    department = match.Parent.Attribute("DEPNAME").Value,
                    section = match.Attribute("SECNAME").Value,
                    name = match.Attribute("NAME").Value,
                    cathedra = match.Attribute("CATHEDRA").Value,
                    audience = match.Attribute("AUDIENCE").Value,
                    curriculum = match.Attribute("CURRICULUM").Value,
                    students = SplitString(match.Attribute("STUDENTS").Value)
                };
                find.Add(res);
            }
            return find;
        }

        private List<string> SplitString(string phrase)
        {
            string[] newStr = phrase.Split(' ');
            List<string> lst = new List<string>();
            foreach (var item in newStr)
            {
                lst.Add(item);
            }
            return lst;
        }
    }
}
