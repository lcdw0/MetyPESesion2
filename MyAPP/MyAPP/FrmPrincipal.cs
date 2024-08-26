using MyAPP.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyAPP
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = tbNombre.Text;
            persona.FechaNac = dtpFechaNac.Value;
            MessageBox.Show(persona.EvaluarEdad());
        }
    }
}
