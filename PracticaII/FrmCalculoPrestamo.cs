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
    public partial class FrmCalculoPrestamo : Form
    {
        private double montoPrestamo = 0;
        private double tasaPrestamo = 0;
        private double cantidadCuotas = 0;
        public FrmCalculoPrestamo()
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
            limpiarResultados();
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

        private void limpiarResultados()
        {
            try
            {
                LstNoCuota.Items.Clear();
                LstCapitalCuota.Items.Clear();
                LstInteresCuota.Items.Clear();
                LstTotalCuota.Items.Clear();
                LstCapitalPagado.Items.Clear();
                LstCapitalRestante.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error a limpiar resultados: " + ex.Message);
            }
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

                for (int i = 1; i <=cantidadCuotas; i++)
                {
                    capitalPagado += capitalCuota;
                    capitalRestante = montoPrestamo - capitalPagado;

                    LstNoCuota.Items.Add(i);
                    LstCapitalCuota.Items.Add(capitalCuota.ToString("###,###,##0.00"));
                    LstInteresCuota.Items.Add(interesCuota.ToString("###,###,##0.00"));
                    LstTotalCuota.Items.Add(totalCuota.ToString("###,###,##0.00"));
                    LstCapitalPagado.Items.Add(capitalPagado.ToString("###,###,##0.00"));
                    LstCapitalRestante.Items.Add(capitalRestante.ToString("###,###,##0.00"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular prestamo: " + ex.Message);
            }
        }
    }
}
