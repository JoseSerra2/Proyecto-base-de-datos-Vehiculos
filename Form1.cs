using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_base_de_datos_Vehiculos
{
    public partial class Form1 : Form
    {
        private string ListaClientes = @"C:\\Users\\ADMIN2020\\source\\repos\\Proyecto base de datos Vehiculos\\ListaClientes.xlsx";
        private string ListaCarros = @"C:\\Users\\ADMIN2020\\source\\repos\\Proyecto base de datos Vehiculos\\ListaCarros.xlsx";
        private string ListaDevoluciones = @"C:\\Users\\ADMIN2020\\source\\repos\\Proyecto base de datos Vehiculos\\ListaDevoluciones.xlsx";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument(ListaClientes);
            int iRow = 2;
            List<Clientes> clientes = new List<Clientes>();
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
            {
                Clientes op = new Clientes();
                op.NIT1 = sl.GetCellValueAsInt32(iRow, 1);
                op.Nombre1 = sl.GetCellValueAsString(iRow, 2);
                op.Direccion1 = sl.GetCellValueAsString(iRow, 3);
                clientes.Add(op);
                iRow++;
            }
            dataGridView1.DataSource = clientes;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument(ListaCarros);
            int iRow = 2;
            List<Carros> Carros = new List<Carros>();
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
            {
                Carros op = new Carros();
                op.Placa1 = sl.GetCellValueAsString(iRow,1);
                op.Marca1 = sl.GetCellValueAsString(iRow, 2);
                op.Modelo1 = sl.GetCellValueAsInt32(iRow, 3);
                op.Color = sl.GetCellValueAsString(iRow, 4);
                op.PrecioKm1 = sl.GetCellValueAsString(iRow, 5);
                Carros.Add(op);
                iRow++;
            }
            dataGridView2.DataSource = Carros;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument(ListaDevoluciones);
            SLDocument sl2 = new SLDocument(ListaCarros);
            int iRow = 2;
            int mayor;
            List<Devoluciones> Devoluciones = new List<Devoluciones>();
 
            int MAYOR=0;
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow,1)))
            {
                Devoluciones op= new Devoluciones();
                op.NIT1 = sl.GetCellValueAsInt32(iRow, 1);
                op.Placa1 = sl.GetCellValueAsString(iRow, 2);
                op.FechaA1 = sl.GetCellValueAsString(iRow, 3);
                op.FechaD1 = sl.GetCellValueAsString(iRow, 4);
                op.Kmrecorridos1 = sl.GetCellValueAsInt32(iRow, 5);
                if(MAYOR < op.Kmrecorridos1)
                {
                    MAYOR=op.Kmrecorridos1;
                }
                op.Total1 = (sl.GetCellValueAsInt32(iRow, 5)) * (sl2.GetCellValueAsInt32(iRow, 5));
                Devoluciones.Add(op);
                iRow++;

            }
            dataGridView3.DataSource=Devoluciones;
            label2.Text = MAYOR.ToString();

        }
    }
}
