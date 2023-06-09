using GitHub_Profile_Readme_Generator.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub_Profile_Readme_Generator.Forms
{
    public partial class Frm_Preview : Form
    {
        public Frm_Preview()
        {
            InitializeComponent();
        }

        private void Frm_Preview_Load(object sender, EventArgs e)
        {
            editorTxt.Text = BuilderClass.readmeText;
            BuilderClass.isPreviewFormOpen = true;
        }

        private void Frm_Preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            BuilderClass.isPreviewFormOpen = false;
        }
    }
}
