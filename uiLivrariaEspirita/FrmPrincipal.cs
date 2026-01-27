namespace uiLivrariaEspirita
{
    /// <summary>
    /// Classe FrmPrincipal.
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        /// <summary>
        /// Método de inicialização do formulário.
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();

            FrmSplash frmSplash = new();
            frmSplash.ShowDialog();
        }
    }
}