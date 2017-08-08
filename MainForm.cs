using AlbumTagger;
using System;
using System.Windows.Forms;

namespace AlbumTagManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectSourceFolder_Click(object sender, EventArgs e)
        {
            AddTagForm frmAddTag = new AddTagForm();
            frmAddTag.FormClosed += AddTagFormClosed;
            frmAddTag.Show();

        }

        private void AddTagFormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
