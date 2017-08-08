namespace AlbumTagger
{
    partial class AddTagForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTagForm));
            this.pbxPicture = new System.Windows.Forms.PictureBox();
            this.pnlPictureBox = new System.Windows.Forms.Panel();
            this.txtAddTag = new System.Windows.Forms.TextBox();
            this.lblSourceFolderPath = new System.Windows.Forms.Label();
            this.lblSourceFolderName = new System.Windows.Forms.Label();
            this.lblFileNAme = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.btnShowPreviousPhoto = new System.Windows.Forms.Button();
            this.btnShowNextPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).BeginInit();
            this.pnlPictureBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxPicture
            // 
            this.pbxPicture.BackColor = System.Drawing.Color.Black;
            this.pbxPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxPicture.Location = new System.Drawing.Point(0, 0);
            this.pbxPicture.Name = "pbxPicture";
            this.pbxPicture.Size = new System.Drawing.Size(566, 787);
            this.pbxPicture.TabIndex = 0;
            this.pbxPicture.TabStop = false;
            // 
            // pnlPictureBox
            // 
            this.pnlPictureBox.Controls.Add(this.pbxPicture);
            this.pnlPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPictureBox.Location = new System.Drawing.Point(0, 0);
            this.pnlPictureBox.Name = "pnlPictureBox";
            this.pnlPictureBox.Size = new System.Drawing.Size(566, 787);
            this.pnlPictureBox.TabIndex = 1;
            // 
            // txtAddTag
            // 
            this.txtAddTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddTag.ForeColor = System.Drawing.Color.Gray;
            this.txtAddTag.Location = new System.Drawing.Point(575, 78);
            this.txtAddTag.Name = "txtAddTag";
            this.txtAddTag.Size = new System.Drawing.Size(163, 20);
            this.txtAddTag.TabIndex = 2;
            this.txtAddTag.Text = "Add Tag: Home, Friends...";
            // 
            // lblSourceFolderPath
            // 
            this.lblSourceFolderPath.AutoSize = true;
            this.lblSourceFolderPath.Location = new System.Drawing.Point(572, 9);
            this.lblSourceFolderPath.Name = "lblSourceFolderPath";
            this.lblSourceFolderPath.Size = new System.Drawing.Size(69, 13);
            this.lblSourceFolderPath.TabIndex = 3;
            this.lblSourceFolderPath.Text = "Source Path:";
            // 
            // lblSourceFolderName
            // 
            this.lblSourceFolderName.AutoSize = true;
            this.lblSourceFolderName.Location = new System.Drawing.Point(572, 32);
            this.lblSourceFolderName.Name = "lblSourceFolderName";
            this.lblSourceFolderName.Size = new System.Drawing.Size(70, 13);
            this.lblSourceFolderName.TabIndex = 3;
            this.lblSourceFolderName.Text = "Folder Name:";
            // 
            // lblFileNAme
            // 
            this.lblFileNAme.AutoSize = true;
            this.lblFileNAme.Location = new System.Drawing.Point(572, 57);
            this.lblFileNAme.Name = "lblFileNAme";
            this.lblFileNAme.Size = new System.Drawing.Size(69, 13);
            this.lblFileNAme.TabIndex = 4;
            this.lblFileNAme.Text = "Photo Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tags:";
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(744, 78);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(75, 23);
            this.btnAddTag.TabIndex = 5;
            this.btnAddTag.Text = "Add";
            this.btnAddTag.UseVisualStyleBackColor = true;
            // 
            // btnShowPreviousPhoto
            // 
            this.btnShowPreviousPhoto.Location = new System.Drawing.Point(575, 107);
            this.btnShowPreviousPhoto.Name = "btnShowPreviousPhoto";
            this.btnShowPreviousPhoto.Size = new System.Drawing.Size(119, 23);
            this.btnShowPreviousPhoto.TabIndex = 5;
            this.btnShowPreviousPhoto.Text = "← Previous Photo";
            this.btnShowPreviousPhoto.UseVisualStyleBackColor = true;
            // 
            // btnShowNextPhoto
            // 
            this.btnShowNextPhoto.Location = new System.Drawing.Point(700, 107);
            this.btnShowNextPhoto.Name = "btnShowNextPhoto";
            this.btnShowNextPhoto.Size = new System.Drawing.Size(119, 23);
            this.btnShowNextPhoto.TabIndex = 5;
            this.btnShowNextPhoto.Text = "Next Photo →";
            this.btnShowNextPhoto.UseVisualStyleBackColor = true;
            // 
            // AddTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 787);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.btnShowNextPhoto);
            this.Controls.Add(this.btnShowPreviousPhoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFileNAme);
            this.Controls.Add(this.lblSourceFolderName);
            this.Controls.Add(this.lblSourceFolderPath);
            this.Controls.Add(this.txtAddTag);
            this.Controls.Add(this.pnlPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTagForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Album Tag Manager v0.1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).EndInit();
            this.pnlPictureBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPicture;
        private System.Windows.Forms.Panel pnlPictureBox;
        private System.Windows.Forms.TextBox txtAddTag;
        private System.Windows.Forms.Label lblSourceFolderPath;
        private System.Windows.Forms.Label lblSourceFolderName;
        private System.Windows.Forms.Label lblFileNAme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.Button btnShowPreviousPhoto;
        private System.Windows.Forms.Button btnShowNextPhoto;
    }
}

