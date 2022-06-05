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
    }
}
