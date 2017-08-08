using System.Windows.Forms;

namespace AlbumTagger
{
    public partial class AddTagForm : Form
    {
        const string TAG_LABEL_PLACEHOLDER = "Add Tag: Home, Friends...";
        
        public AddTagForm()
        {
            InitializeComponent();
            Utility.Utility.AddPlaceholderSupportToControl(txtAddTag, TAG_LABEL_PLACEHOLDER);
        }
    }
}