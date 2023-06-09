using GitHub_Profile_Readme_Generator.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GitHub_Profile_Readme_Generator.Forms
{
    public partial class Frm_MainWindow : Form
    {

        BuilderClass builder = new BuilderClass();
        public static string readmeText;

        public Frm_MainWindow()
        {
            InitializeComponent();
        }

        private void Frm_MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {

            BuilderClass.preTitle = preTitleTxt.Text;
            BuilderClass.title = titleTxt.Text;
            BuilderClass.subtitle = subtitleTxt.Text;

            BuilderClass.workText1 = workingText1Txt.Text;
            BuilderClass.workText1Desc = workingText1DescTxt.Text;
            BuilderClass.workText2 = workingText2Txt.Text;
            BuilderClass.workText2Desc = workingText2DescTxt.Text;
            Thread.Sleep(500);
            BuilderClass.workText3 = workingText3Txt.Text;
            BuilderClass.workText3Desc = workingText3DescTxt.Text;
            BuilderClass.workText4 = workingText4Txt.Text;
            BuilderClass.workText4Desc = workingText4DescTxt.Text;
            Thread.Sleep(500);
            BuilderClass.workText5 = workingText5Txt.Text;
            BuilderClass.workText5Desc = workingText5DescTxt.Text;
            BuilderClass.workText6 = workingText6Txt.Text;
            BuilderClass.workText6Desc = workingText6DescTxt.Text;
            Thread.Sleep(500);
            BuilderClass.workText7 = workingText7Txt.Text;
            BuilderClass.workText7Desc = workingText7DescTxt.Text;
            BuilderClass.workText8 = workingText8Txt.Text;
            BuilderClass.workText8Desc = workingText8DescTxt.Text;
            Thread.Sleep(500);

            readmeText = BuildReadme();

            BuilderClass.readmeText = readmeText;

        }

        public string BuildReadme()
        {
            string readme;

            readme = "<h1 align=\"center\">" + BuilderClass.preTitle + " " + BuilderClass.title + "</h1>\n";
            readme = readme + "<h3 align=\"center\">" + BuilderClass.subtitle + "</h3>\n";

            if (BuilderClass.workText1 != "" && BuilderClass.workText1Desc != "")
            {
                readme = readme + "- " + BuilderClass.workText1 + " **" + BuilderClass.workText1Desc + "**\n";
            }
            if (BuilderClass.workText4 != "" && BuilderClass.workText4Desc != "")
            {
                readme = readme + "- " + BuilderClass.workText4 + " **" + BuilderClass.workText4Desc + "**\n";
            }
            if (BuilderClass.workText2 != "" && BuilderClass.workText2Desc != "")
            {
                readme = readme + "- " + BuilderClass.workText2 + " **" + BuilderClass.workText1Desc + "**\n";
            }
            if (BuilderClass.workText3 != "" && BuilderClass.workText3Desc != "")
            {
                readme = readme + "- " + BuilderClass.workText3 + " **" + BuilderClass.workText3Desc + "**\n";
            }
            if (BuilderClass.workText5 != "" && BuilderClass.workText5Desc != "")
            {
                readme = readme + "- " + BuilderClass.workText5 + " **" + BuilderClass.workText5Desc + "**\n";
            }
            if (BuilderClass.workText6 != "" && BuilderClass.workText6Desc != "")
            {
                readme = readme + "- " + BuilderClass.workText6 + " **" + BuilderClass.workText6Desc + "**\n";
            }
            if (BuilderClass.workText7 != "" && BuilderClass.workText7Desc != "")
            {
                readme = readme + "- " + BuilderClass.workText7 + " **" + BuilderClass.workText7Desc + "**\n";
            }
            if (BuilderClass.workText8 != "" && BuilderClass.workText8Desc != "")
            {
                readme = readme + "- " + BuilderClass.workText8 + " **" + BuilderClass.workText8Desc + "**\n";
            }

            return readme;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (BuilderClass.isPreviewFormOpen)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BuilderClass.isPreviewFormOpen = true;
                Frm_Preview preview = new Frm_Preview();
                preview.Show();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string filePath;
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Readme | *.md";
            sf.ShowDialog();

            filePath = sf.FileName;
            
            StreamWriter sw = new StreamWriter(filePath);
            sw.Write(BuilderClass.readmeText);
            sw.Close();
        }

        private void gitHubBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/lulv3z/GitHub-Profile-Readme-Generator");
        }
    }
}
