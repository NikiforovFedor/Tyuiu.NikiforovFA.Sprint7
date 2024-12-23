namespace Tyuiu.NikiforovFA.Sprint6.Task7.V14
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_NFA = new PictureBox();
            labelInformation_NFA = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_NFA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_NFA
            // 
            pictureBoxAvatar_NFA.Image = Sprint7.Project.V3.Properties.Resources.photo_2024_12_11_19_30_43;
            pictureBoxAvatar_NFA.Location = new Point(12, 12);
            pictureBoxAvatar_NFA.Name = "pictureBoxAvatar_NFA";
            pictureBoxAvatar_NFA.Size = new Size(193, 371);
            pictureBoxAvatar_NFA.TabIndex = 2;
            pictureBoxAvatar_NFA.TabStop = false;
            // 
            // labelInformation_NFA
            // 
            labelInformation_NFA.Font = new Font("Segoe UI", 14F);
            labelInformation_NFA.Location = new Point(226, 29);
            labelInformation_NFA.Name = "labelInformation_NFA";
            labelInformation_NFA.Size = new Size(342, 342);
            labelInformation_NFA.TabIndex = 1;
            labelInformation_NFA.Text = resources.GetString("labelInformation_NFA.Text");
            labelInformation_NFA.Click += labelInformation_NFA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 391);
            Controls.Add(labelInformation_NFA);
            Controls.Add(pictureBoxAvatar_NFA);
            MaximizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Разработчик";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_NFA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxAvatar_NFA;
        private Label labelInformation_NFA;
    }
}