namespace uiLivrariaEspirita
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmSplash : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public FrmSplash()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSplash_Load(object sender, EventArgs e)
        {
            progressBar.Maximum = 100;
            timerSplash.Enabled = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 1;
            }
            else
            {
                timerSplash.Enabled = false;
                this.Close();
            }
        }
    }
}