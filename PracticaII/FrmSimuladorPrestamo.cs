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
    public partial class FrmSimuladorPrestamo : Form
    {
        private double montoPrestamo = 0;
        private double tasaPrestamo = 0;
        private double cantidadCuotas = 0;

        public FrmSimuladorPrestamo()
        {
            InitializeComponent();
        }

        private void CmdCalcular_Click(object sender, EventArgs e)
        {
            if (!parametrosValidos())
            {
                MessageBox.Show("Existen parametros incorrectos");
                return;
            }
            calcularPrestamo();
        }
        private bool parametrosValidos()
        {
            try
            {
                montoPrestamo = double.Parse(TxtMontoPrestamo.Text);
                tasaPrestamo = double.Parse(TxtTasaPrestamo.Text);
                cantidadCuotas = (int)NudNoCuotas.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error a validar parametros: " + ex.Message);
            }
            return true;
        }
        private void calcularPrestamo()
        {
            try
            {
                double capitalCuota = montoPrestamo / cantidadCuotas;
                double interesCuota = (montoPrestamo * (tasaPrestamo / 100)) / 12;
                double totalCuota = capitalCuota + interesCuota;
                double capitalPagado = 0;
                double capitalRestante = 0;
                DataTable dt = new DataTable();
                dt.Columns.Add("No. Cuota");
                dt.Columns.Add("Capital Cuota");
                dt.Columns.Add("Interes Cuota");
                dt.Columns.Add("Total Cuota");
                dt.Columns.Add("Capital Pagado");
                dt.Columns.Add("Capital Restante");
                   
                for (int i = 1; i <= cantidadCuotas; i++)
                {
                    capitalPagado += capitalCuota;
                    capitalRestante = montoPrestamo - capitalPagado;

                    DataRow fila = dt.NewRow();
                    fila["No. Cuota"] = i;
                    fila["Capital Cuota"] = capitalCuota.ToString("###,###,##0.00");
                    fila["Interes Cuota"] = interesCuota.ToString("###,###,##0.00");
                    fila["Total Cuota"] = totalCuota.ToString("###,###,##0.00");
                    fila["Capital Pagado"] = capitalPagado.ToString("###,###,##0.00");
                    fila["Capital Restante"] = capitalRestante.ToString("###,###,##0.00");
                    dt.Rows.Add(fila);
                }
                DGVResultados.DataSource = dt;
                DGVResultados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular prestamo: " + ex.Message);
            }
        }
    }
}
