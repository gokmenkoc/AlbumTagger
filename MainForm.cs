using System.Windows.Forms;

namespace AlbumTagger
{
    public partial class MainForm : Form
    {
        const string TAG_LABEL_PLACEHOLDER = "Add Tag: Home, Friends...";

        public MainForm()
        {
            InitializeComponent();
            Utility.Utility.AddPlaceholderSupportToControl(txtAddTag, TAG_LABEL_PLACEHOLDER);
        }
    }
}