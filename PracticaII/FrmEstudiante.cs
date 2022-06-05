using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaII
{
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void estudianteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estudianteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lAB01DataSet);

        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lAB01DataSet.Estudiante' table. You can move, or remove it, as needed.
            this.estudianteTableAdapter.Fill(this.lAB01DataSet.Estudiante);

        }

        private void matriculaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void direccionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void direccionLabel_Click(object sender, EventArgs e)
        {

        }

        private void matriculaLabel_Click(object sender, EventArgs e)
        {

        }

        private void carreraLabel_Click(object sender, EventArgs e)
        {

        }

        private void carreraTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
