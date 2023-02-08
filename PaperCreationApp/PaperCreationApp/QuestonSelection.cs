using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperCreationApp
{
    public partial class QuestonSelection : Form
    {
        private Form1 form1;

        List<DB_SUBJECTs> subjects;
        List<DB_CHAPTER> chapters;
        List<DB_LONGQ> LongQuest;
        List<DB_SHORTQ> ShortQuest;
        List<DB_MCQ> MCQs;
        List<int> randomNumber;
        int GlobalCount = 1;
        string fileName = "";

        public QuestonSelection()
        {
            InitializeComponent();
            randomNumber = new List<int>();
            subjects = new MasterDate().GetSubjects();
            populateSubjects();
            fileName = @"D:\ProductDev\PaperGenerator\PaperCreationApp\" ;

        }


        public QuestonSelection(Form1 form1)
        {
            this.form1 = form1;

            subjects = new MasterDate().GetSubjects();
            populateSubjects();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void QuestonSelection_Load(object sender, EventArgs e)
        {
           
        }

        private void SubjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int subId = Int32.Parse(SubjectComboBox.SelectedValue.ToString());
                if (subId > 0)
                {
                    chapters = new MasterDate().GetChapters(subId);
                    populateChapters();

                }
            }
            catch (Exception ex)
            { }
        }

        private void populateChapters()
        {
            ChapterComboBox.DataSource = chapters;
            ChapterComboBox.DisplayMember = "Name";
            ChapterComboBox.ValueMember = "Id";
        }

        private void populateSubjects()
        {
            SubjectComboBox.SelectedValue = 1;
            SubjectComboBox.DataSource = subjects;
            SubjectComboBox.DisplayMember = "Name";
            SubjectComboBox.ValueMember = "Id";
            SubjectComboBox_SelectedIndexChanged(null, null);
        }

        private void MCQ_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (!int.TryParse(MCQ.Text, out result))
            {
                MCQ.Text = "";
            }
        }

        private void Short_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (!int.TryParse(Short.Text, out result))
            {
                Short.Text = "";
            }

        }

        private void Long_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (!int.TryParse(Long.Text, out result))
            {
                Long.Text = "";
            }

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            if (Long.Text.Equals("") || MCQ.Text.Equals("") || Short.Text.Equals(""))
            {
                MessageBox.Show("Please fill above categories");
            }
            string chapName = "Chapter";
            int chapId =  Int32.Parse(ChapterComboBox.SelectedValue.ToString());
            LongQuest = new MasterDate().GetLongQ(chapId);
            int reqLongCount = Int32.Parse( Long.Text);
            //get list for long questions
            generateRandomList(LongQuest.Count, reqLongCount);

            chapName = ChapterComboBox.Text;
            addLongToFile(randomNumber,chapName );


            ShortQuest = new MasterDate().GetShortQ(chapId);
            int reqShortCount = Int32.Parse(Short.Text);
            //get list for long questions
            generateRandomList(ShortQuest.Count, reqShortCount);
            addShortToFile(randomNumber, chapName);


        }

        private void addShortToFile(List<int> randomNumber, string chapName)
        {
            fileName += @"Short_" + (GlobalCount++) + chapName + " " + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }


            StreamWriter sw = File.CreateText(fileName);
            try
            {
                sw.WriteLine("Attempt Short Questions \n\n");

                int count = 1;
                foreach (var item in randomNumber)
                {
                    var quest = ShortQuest.ElementAt(item);

                    sw.Write(count++.ToString() + ". " + quest.Description + "\n");

                }
                sw.Close();

            }


            catch (Exception ex)
            {
                sw.Close();
            }
        }

        private void addLongToFile(List<int> randomNumber,string chapName)
        {
            fileName += "_Long" + GlobalCount + chapName + " " + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            
            StreamWriter sw = File.CreateText(fileName);
            try
            {
                sw.WriteLine("Attempt Long Questions \n\n");

                int count = 1;
                foreach (var item in randomNumber)
                {
                    var quest = LongQuest.ElementAt(item);

                    sw.Write(count++.ToString() + ". " + quest.Description + "\n");

                }
                sw.Close();

            }
            catch (Exception ex)
            {
                sw.Close();
            }
        }

        private void generateRandomList(int maxNumber,int requiredCount)
        {
            randomNumber = new List<int>();
            for (int i = 0; i < requiredCount; )
            {
                Random rand = new Random();
                int val = rand.Next(1, maxNumber);
                if (!randomNumber.Contains(val))
                {
                    randomNumber.Add(val);
                    i++;
                }
            }
        }
    }
}
