using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlbumTagger.Utility
{
    public static class Utility
    {
        #region Placeholder support

        public static void AddPlaceholderSupportToControl(Control control, string placeholderText)
        {
            if (control is TextBox)
            {
                control.Tag = placeholderText;
                control.Enter += OnTextBoxControlEnter;
                control.Leave += OnTextBoxControlLeave;
            }
        }

        private static void OnTextBoxControlLeave(object sender, EventArgs e)
        {
            TextBox txtControl = sender as TextBox;
            if (string.IsNullOrEmpty(txtControl.Text.Trim()))
            {
                txtControl.Text      = txtControl.Tag.ToString();
                txtControl.ForeColor = Color.Gray;
                txtControl.Font      = new Font(txtControl.Font, FontStyle.Italic);
            }
        }

        private static void OnTextBoxControlEnter(object sender, EventArgs e)
        {
            TextBox txtControl = sender as TextBox;
            if (txtControl.Text == txtControl.Tag.ToString())
            {
                txtControl.Clear();
                txtControl.ForeColor = Color.Black;
                txtControl.Font      = new Font(txtControl.Font, FontStyle.Regular);
            }
        }

        #endregion
    }
}