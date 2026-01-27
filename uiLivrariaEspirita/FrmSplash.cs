namespace uiLivrariaEspirita
{
    /// <summary>
    /// Classe FrmSplash.
    /// </summary>
    public partial class FrmSplash : Form
    {
        /// <summary>
        /// Método de inicialização do formulário.
        /// </summary>
        public FrmSplash()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método que trata o evento Load do formulário FrmSplash.
        /// </summary>
        /// <param name="sender">Objeto que disparou o evento.</param>
        /// <param name="e">Informações adicionais sobre o evento.</param>
        private void FrmSplash_Load(object sender, EventArgs e)
        {
            ProgressBar.Maximum = 100;
            TimerSplash.Enabled = true;
        }
        /// <summary>
        /// Método que trata o evento Tick do Timer.
        /// </summary>
        /// <param name="sender">Objeto que disparou o evento.</param>
        /// <param name="e">Informações adicionais sobre o evento.</param>
        private void TimerSplash_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Value < 100)
            {
                ProgressBar.Value += 1;
            }
            else
            {
                TimerSplash.Enabled = false;
                this.Close();
            }
        }
    }
}