using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiLivrariaEspirita
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();

            FrmSplash frmSplash = new FrmSplash();
            frmSplash.ShowDialog();
        }
    }
}