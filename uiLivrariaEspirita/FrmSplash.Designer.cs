namespace uiLivrariaEspirita
{
    partial class FrmSplash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBoxSplash = new PictureBox();
            progressBar = new ProgressBar();
            timerSplash = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSplash).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxSplash
            // 
            pictureBoxSplash.Image = Properties.Resources.ImgSplash;
            pictureBoxSplash.Location = new Point(0, 0);
            pictureBoxSplash.Name = "pictureBoxSplash";
            pictureBoxSplash.Size = new Size(320, 411);
            pictureBoxSplash.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSplash.TabIndex = 0;
            pictureBoxSplash.TabStop = false;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(0, 417);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(320, 23);
            progressBar.TabIndex = 1;
            // 
            // timerSplash
            // 
            timerSplash.Enabled = true;
            timerSplash.Tick += timerSplash_Tick;
            // 
            // FrmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 441);
            Controls.Add(progressBar);
            Controls.Add(pictureBoxSplash);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmSplash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSplash).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxSplash;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timerSplash;
    }
}