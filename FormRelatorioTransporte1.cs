using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANAYA_VIAGENS
{
    public partial class FormRelatorioTransporte : Form
    {
        public FormRelatorioTransporte()
        {
            InitializeComponent();
        }

        private void RelatorioTransporte_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
