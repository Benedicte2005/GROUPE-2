using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersonne.Modals
{
    public partial class PreviewRapport : Form
    {
        public PreviewRapport()
        {
            InitializeComponent();
        }

        private void PreviewRapport_Load(object sender, EventArgs e)
        {

            this.preview.RefreshReport();
        }
    }
}
