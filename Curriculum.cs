using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Xsl;
using System.IO;

namespace XML
{
    public partial class Curriculum : Form
    {
        private string path = StartForm.PATH; // FILE
        private readonly string pathPartXml = @"PartXml.xml"; // Part Xml FILE

        private readonly string pathXsl = @"XSL.xsl"; // XSL for converting to HTML

        private readonly string pathHtml = @"HTML.html"; // All HTML file
        private readonly string pathPartHtml = @"PartHTML.html"; // Part HTML file

        private bool isToHtmlPressed = false;
        private bool isToPartHtmlPressed = false;
        private bool isNew;


        public Curriculum()
        {
            InitializeComponent();

            BuildBox(NameComboBox, DepartmentComboBox, SectionComboBox, CathedraComboBox, AudienceComboBox, CurriculumComboBox, FaculityComboBox);
                        
        }


        #region Functions

        private void BuildBox(ComboBox Name, ComboBox Department, ComboBox Section, ComboBox Cathedra, ComboBox Audience, ComboBox Curriculum, ComboBox Faculty)
        {
            if (path != "")
            {
                Name.Items.Clear();
                Department.Items.Clear();
                Section.Items.Clear();
                Cathedra.Items.Clear();
                Audience.Items.Clear();
                Curriculum.Items.Clear();
                Faculty.Items.Clear();

                IParse p = new LINQ();
                List<Search> res = p.AnalizeFile(new Search(), path);
                List<string> name = new List<string>();
                List<string> faculty = new List<string>();
                List<string> department = new List<string>();
                List<string> section = new List<string>();
                List<string> cathedra = new List<string>();
                List<string> audience = new List<string>();
                List<string> curriculum = new List<string>();

                foreach (Search elem in res)
                {
                    if (!faculty.Contains(elem.faculty))
                    {
                        faculty.Add(elem.faculty);
                    }
                    if (!name.Contains(elem.name))
                    {
                        name.Add(elem.name);
                    }
                    if (!department.Contains(elem.department))
                    {
                        department.Add(elem.department);
                    }
                    if (!section.Contains(elem.section))
                    {
                        section.Add(elem.section);
                    }
                    if (!cathedra.Contains(elem.cathedra))
                    {
                        cathedra.Add(elem.cathedra);
                    }
                    if (!audience.Contains(elem.audience))
                    {
                        audience.Add(elem.audience);
                    }
                    if (!curriculum.Contains(elem.curriculum))
                    {
                        curriculum.Add(elem.curriculum);
                    }
                }

                name = name.OrderBy(x => x).ToList();
                faculty = faculty.OrderBy(x => x).ToList();
                department = department.OrderBy(x => x).ToList();
                section = section.OrderBy(x => x).ToList();
                cathedra = cathedra.OrderBy(x => x).ToList();
                audience = audience.OrderBy(x => x).ToList();
                curriculum = curriculum.OrderBy(x => x).ToList();

                Name.Items.AddRange(name.ToArray());
                Faculty.Items.AddRange(faculty.ToArray());
                Department.Items.AddRange(department.ToArray());
                Section.Items.AddRange(section.ToArray());
                Cathedra.Items.AddRange(cathedra.ToArray());
                Audience.Items.AddRange(audience.ToArray());
                Curriculum.Items.AddRange(curriculum.ToArray());
            }
        }

        private void ParseNames(object sender)
        {
            CheckBox temp = sender as CheckBox;
            if (path != "")
            {
                switch (temp.Text)
                {
                    case "Name":
                        NameComboBox.Text = "";
                        if (temp.CheckState == CheckState.Checked) NameComboBox.Enabled = true;
                        else NameComboBox.Enabled = false;
                        break;
                    case "Faculty":
                        FaculityComboBox.Text = "";
                        if (temp.CheckState == CheckState.Checked) FaculityComboBox.Enabled = true;
                        else FaculityComboBox.Enabled = false;
                        break;
                    case "Department":
                        DepartmentComboBox.Text = "";
                        if (temp.CheckState == CheckState.Checked) DepartmentComboBox.Enabled = true;
                        else DepartmentComboBox.Enabled = false;
                        break;
                    case "Section":
                        SectionComboBox.Text = "";
                        if (temp.CheckState == CheckState.Checked) SectionComboBox.Enabled = true;
                        else SectionComboBox.Enabled = false;
                        break;
                    case "Cathedra":
                        CathedraComboBox.Text = "";
                        if (temp.CheckState == CheckState.Checked) CathedraComboBox.Enabled = true;
                        else CathedraComboBox.Enabled = false;
                        break;
                    case "Audience":
                        AudienceComboBox.Text = "";
                        if (temp.CheckState == CheckState.Checked) AudienceComboBox.Enabled = true;
                        else AudienceComboBox.Enabled = false;
                        break;
                    case "Curriculum":
                        CurriculumComboBox.Text = "";
                        if (temp.CheckState == CheckState.Checked) CurriculumComboBox.Enabled = true;
                        else CurriculumComboBox.Enabled = false;
                        break;
                }
            }
        }

        private Search OurSearch()
        {
            string[] info = new string[7];
            if (NameCheckBox.Checked) info[0] = Convert.ToString(NameComboBox.Text);
            if (DepartmentCheckBox.Checked) info[1] = Convert.ToString(DepartmentComboBox.Text);
            if (SectionCheckBox.Checked) info[2] = Convert.ToString(SectionComboBox.Text);
            if (CathedraCheckBox.Checked) info[3] = Convert.ToString(CathedraComboBox.Text);
            if (AudienceCheckBox.Checked) info[4] = Convert.ToString(AudienceComboBox.Text);
            if (CurriculumCheckBox.Checked) info[5] = Convert.ToString(CurriculumComboBox.Text);
            if (FacultyCheckBox.Checked) info[6] = Convert.ToString(FaculityComboBox.Text);
            Search IdealSearch = new Search(info);
            return IdealSearch;
        }

        private void Parse4XML()
        {
            Search myTemplate = OurSearch();
            XmlWriters XW = new XmlWriters();
            MyDataGridView.Rows.Clear();
            List<Search> res;

            if (SAXRadioButton.Checked)
            {
                IParse parser = new SAX();
                res = parser.AnalizeFile(myTemplate, path);
                XW.WriteToXml(res);
                Output(res);                
            }
            if (DOMRadioButton.Checked)
            {
                IParse parser = new DOM();
                res = parser.AnalizeFile(myTemplate, path);
                XW.WriteToXml(res);
                Output(res);
            }
            if (LINQRadioButton.Checked)
            {
                IParse parser = new LINQ();
                res = parser.AnalizeFile(myTemplate, path);
                XW.WriteToXml(res);
                Output(res);
            }
        }

        private void Output(List<Search> res)
        {
            wind.Clear();
            this.MyDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            int count = (File.ReadAllLines(pathPartXml).Length - 4) / 5;
            if (count > 1) MyDataGridView.Rows.Add(count - 1);

            int indexCell = 0;

            foreach (Search n in res)
            {
                bool firstName = true;                

                for (int j = 0; j < MyDataGridView.Columns.Count; j++)
                {                    
                    MyDataGridView.Rows[indexCell].Cells[0].Value = n.faculty;
                    MyDataGridView.Rows[indexCell].Cells[1].Value = n.department;
                    MyDataGridView.Rows[indexCell].Cells[2].Value = n.section;
                    MyDataGridView.Rows[indexCell].Cells[3].Value = n.name;
                    MyDataGridView.Rows[indexCell].Cells[4].Value = n.cathedra;
                    MyDataGridView.Rows[indexCell].Cells[5].Value = n.audience;
                    MyDataGridView.Rows[indexCell].Cells[6].Value = n.curriculum;                    
                }
                foreach (var item in n.students)
                {
                    MyDataGridView.Rows[indexCell].Cells[7].Value += item + " ";
                }

                #region RichTexyBox
                
                wind.AppendText("Faculty: " + n.faculty + " \n");
                wind.AppendText("Department: " + n.department + " \n");
                wind.AppendText("Section: " + n.section + " \n");
                wind.AppendText("Name: " + n.name + " \n");
                wind.AppendText("Cathedra: " + n.cathedra + " \n");
                wind.AppendText("Audience: " + n.audience + " \n");
                wind.AppendText("Curriculum: " + n.curriculum + " \n");
                wind.AppendText("Students: ");
                foreach (var item in n.students)
                {
                    if (!firstName)
                        wind.AppendText("\t   ");
                    wind.AppendText(item + "\n");
                    firstName = false;
                }
                wind.AppendText("------------------------------------------------------------------------\n");
                
                #endregion RichTextBox

                indexCell++;
            }
        }

        private void IntoHTML(string XSL, string PATH, string HTML)
        {
            XslCompiledTransform xlst = new XslCompiledTransform();
            xlst.Load(XSL);
            string input = PATH;
            string result = HTML;
            xlst.Transform(input, result);
            MessageBox.Show("Done!");
        }

        private void OpenDoc()
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog
            {
                InitialDirectory = "D:",
                Filter = "xml files(*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                URLlabel.Text = OpenFileDialog.FileName;
                wind.Clear();
                isNew = true;
                path = URLlabel.Text;
                Clear();
                BuildBox(NameComboBox, DepartmentComboBox, SectionComboBox, CathedraComboBox, AudienceComboBox, CurriculumComboBox, FaculityComboBox);
            }
            if (!isNew)
            {
                path = "";
                isNew = false;
            }
        }

        private void Clear()
        {
            if (path != "")
            {
                wind.Clear();
                wind.Text = "";
            }
            isToHtmlPressed = false;
            isToPartHtmlPressed = false;

            NameCheckBox.Checked = false;
            FacultyCheckBox.Checked = false;
            DepartmentCheckBox.Checked = false;
            SectionCheckBox.Checked = false;
            CathedraCheckBox.Checked = false;
            AudienceCheckBox.Checked = false;
            CurriculumCheckBox.Checked = false;

            NameComboBox.Text = null;
            DepartmentComboBox.Text = null;
            SectionComboBox.Text = null;
            CathedraComboBox.Text = null;
            AudienceComboBox.Text = null;
            CurriculumComboBox.Text = null;

            SAXRadioButton.Checked = false;
            DOMRadioButton.Checked = false;
            LINQRadioButton.Checked = false;

            File.WriteAllText(pathPartXml, String.Empty);
            MyDataGridView.Rows.Clear();
        }

        #endregion Functions

        #region Events

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                MessageBox.Show("Please select a file");
            }
            else
            {
                if (!SAXRadioButton.Checked && !DOMRadioButton.Checked && !LINQRadioButton.Checked)
                {
                    MessageBox.Show("Choose a method!");
                }
                Parse4XML();
            }
        }

        private void ToHtmlButton_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                MessageBox.Show("Please select a file");
            }
            else
            {
                IntoHTML(pathXsl, path, pathHtml);
                isToHtmlPressed = true;
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (isToHtmlPressed)
            {
                System.Diagnostics.Process.Start(pathHtml);
            }
            else
                MessageBox.Show("Please, create a document");
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void OpenPartButton_Click(object sender, EventArgs e)
        {
            if (isToPartHtmlPressed)
            {
                System.Diagnostics.Process.Start(pathPartHtml);
            }
            else
                MessageBox.Show("Please, create a document");
        }

        private void ConvertPartButton_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                MessageBox.Show("Please select a file");
            }
            else
            {
                if (wind.Text.Length != 0)
                {
                    IntoHTML(pathXsl, pathPartXml, pathPartHtml);
                    isToPartHtmlPressed = true;
                }
                else
                    MessageBox.Show("RichBox is empty");
            }
        }

        private void MyTimeTable_Load(object sender, EventArgs e)
        {
            FaculityComboBox.Enabled = false;
            NameComboBox.Enabled = false;
            DepartmentComboBox.Enabled = false;
            SectionComboBox.Enabled = false;
            CathedraComboBox.Enabled = false;
            AudienceComboBox.Enabled = false;
            CurriculumComboBox.Enabled = false;
            wind.Text = "";
            URLlabel.Text = StartForm.PATH;
            isNew = true;
            wind.Clear();
        }

        private void MyTimeTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Attention!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void NameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ParseNames(NameCheckBox);
        }

        private void FacultyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ParseNames(FacultyCheckBox);
        }

        private void CathedraCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ParseNames(CathedraCheckBox);
        }

        private void AudienceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ParseNames(AudienceCheckBox);
        }

        private void CurriculumCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ParseNames(CurriculumCheckBox);
        }

        private void DepartmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ParseNames(DepartmentCheckBox);
        }

        private void SectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ParseNames(SectionCheckBox);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDoc();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Оберіть файл, з яким бажаєте працювати \n" +
               "2. Оберіть метод\n" +
               "3. Натисніть на кнопку \"Search\" для здійснення пошуку за всіма категоріями\n" +
               "4. Якщо бажаєте здійснити пошук за якоюсь категорією, або за декількома -" +
               " оберіть їх та їх значення і натисніть на \"Search\" \n" +
               "5. Якщо ви бажаєте сконвертувати файл в HTML формат, натисніть кнопку \"To HTML\"\n" +
               "6. Натисніть кнопку \"Clear\", щоб очистити вікно \n" +
               "7. Натисніть кнопку \"Help!\" для виклику допомоги.", "Help!", MessageBoxButtons.OK);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабораторну роботу виконав \n" +
                "Цицюра Владислав К-24 \n" +
                "Варіант №5 \n", "Help!", MessageBoxButtons.OK);

        }

        #endregion Events
    }
}