using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cochera.Windows
{
    public partial class frmAbonados : Form
    {
        frmPrincipal formPrincipal;
        public frmAbonados(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;
        }
    }
}
