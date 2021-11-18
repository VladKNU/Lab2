using System.Collections.Generic;
using System.Xml;

namespace XML
{
    class SAX : IParse
    {
        public List<Search> AnalizeFile(Search mySearch, string path)
        {
            List<Search> info = new List<Search>();

            XmlReader BestReader = XmlReader.Create(path);
            info.Clear();

            List<Search> result = new List<Search>();
            Search ser;
            string dep = null;
            string fac = null;

            while (BestReader.Read())
            {
                switch (BestReader.Name)
                {
                    case "faculty":
                        while (BestReader.MoveToNextAttribute())
                        {
                            if (BestReader.Name == "FCNAME")
                            {
                                fac = BestReader.Value;
                            }
                        }
                        break;
                    case "department":
                        while (BestReader.MoveToNextAttribute())
                        {
                            if (BestReader.Name == "DEPNAME")
                            {
                                dep = BestReader.Value;
                            }
                        }
                        break;
                    case "section":
                        if (BestReader.HasAttributes)
                        {
                            ser = new Search
                            {
                                faculty = fac,
                                department = dep
                            };

                            while (BestReader.MoveToNextAttribute())
                            {
                                switch (BestReader.Name)
                                {
                                    case "SECNAME":
                                        ser.section = BestReader.Value;
                                        break;
                                    case "NAME":
                                        ser.name = BestReader.Value;
                                        break;
                                    case "CATHEDRA":
                                        ser.cathedra = BestReader.Value;
                                        break;
                                    case "AUDIENCE":
                                        ser.audience = BestReader.Value;
                                        break;
                                    case "CURRICULUM":
                                        ser.curriculum = BestReader.Value;
                                        break;
                                    case "STUDENTS":
                                        ser.students = SplitString(BestReader.Value);
                                        break;
                                    default:
                                        break;
                                }
                            }
                            result.Add(ser);
                        }
                        break;
                    default:
                        break;
                }
            }
            info = Filter(result, mySearch);
            return info;
        }

        private List<Search> Filter(List<Search> allRes, Search tmp)
        {
            List<Search> newResult = new List<Search>();

            if (allRes != null)
            {
                foreach (Search i in allRes)
                {
                    try
                    {
                        if ((i.faculty == tmp.faculty || tmp.faculty == null) &&
                            (i.name == tmp.name || tmp.name == null) &&
                            (i.department == tmp.department || tmp.department == null) &&
                            (i.section == tmp.section || tmp.section == null) &&
                            (i.cathedra == tmp.cathedra || tmp.cathedra == null) &&
                            (i.audience == tmp.audience || tmp.audience == null) &&
                            (i.curriculum == tmp.curriculum || tmp.curriculum == null)
                            )
                        {
                            newResult.Add(i);
                        }
                    }
                    catch { }
                }
            }
            return newResult;
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
