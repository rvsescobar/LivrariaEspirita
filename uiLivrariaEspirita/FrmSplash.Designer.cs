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
            PictureBoxSplash = new PictureBox();
            ProgressBar = new ProgressBar();
            TimerSplash = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)PictureBoxSplash).BeginInit();
            SuspendLayout();
            // 
            // PictureBoxSplash
            // 
            PictureBoxSplash.Image = Properties.Resources.ImgSplash;
            PictureBoxSplash.Location = new Point(0, 0);
            PictureBoxSplash.Margin = new Padding(3, 4, 3, 4);
            PictureBoxSplash.Name = "PictureBoxSplash";
            PictureBoxSplash.Size = new Size(366, 548);
            PictureBoxSplash.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxSplash.TabIndex = 0;
            PictureBoxSplash.TabStop = false;
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(0, 556);
            ProgressBar.Margin = new Padding(3, 4, 3, 4);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(366, 31);
            ProgressBar.TabIndex = 1;
            // 
            // TimerSplash
            // 
            TimerSplash.Enabled = true;
            TimerSplash.Tick += TimerSplash_Tick;
            // 
            // FrmSplash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 588);
            Controls.Add(ProgressBar);
            Controls.Add(PictureBoxSplash);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmSplash_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBoxSplash).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureBoxSplash;
        private ProgressBar ProgressBar;
        private System.Windows.Forms.Timer TimerSplash;
    }
}