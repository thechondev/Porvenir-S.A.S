using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    /// <Datos_en_vista>
    /// -Codigo del seguro 
    /// -Tipo de seguro
    /// -Valor del seguro
    /// -Porcentaje de incremento
    /// -Valor del benefecio
    /// -ID del cliente
    /// -Nombre del cliente
    /// -Numero del cliente
    /// 
    /// </Datos_en_ vista>

    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            cargar_seguros();
        }

        CN_Negocio objetoCN = new CN_Negocio();
        string[] seguro = new string[5];

        public void cargar_seguros()
        {
            foreach (var lista in objetoCN.listado_seguros())
            {
                seguro = lista.Split(new char[] {','});
                cboseguros.Items.Add((seguro[0] + " " + seguro[1]));
            }
        }

        private void cmdguardar_Click(object sender, EventArgs e)
        {
            //invocar la funcion de insertar
            objetoCN.Insertar_Seguros(txtsegurocod.Text,txtsegurotip.Text,txtseguroval.Text,txtseguropor.Text,txtseguroval_b.Text);

            MessageBox.Show("Se ha registrado correctamente el producto", "Almacenes Don chucho", MessageBoxButtons.OK);

            cargar_seguros();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        private void cmdBuscarSeg_Click(object sender, EventArgs e)
        {
            //invocar la funcion de buscar
            objetoCN.Busqueda_seguros(txtsegurocod.Text);

            //mostrar las propiedades en una caja de texto
            txtsegurocod.Text = objetoCN.codigo.ToString();
            txtsegurotip.Text = objetoCN.tipo.ToString();
            txtseguroval.Text = objetoCN.valor.ToString();
            txtseguropor.Text = objetoCN.porcentaje_in.ToString();
            txtseguroval_b.Text = objetoCN.valor_be.ToString();
           
        }

        private void cmdVenta_Click(object sender, EventArgs e)
        {
            objetoCN.Insertar_ventas(txtsegurocod.Text, txtsegurotip.Text,txtseguroval.Text,txtIDcliente.Text,
                txtNombreCliente.Text,txtNumeroCliente.Text,txtNumeroBe.Text,lbltotal.Text);

            MessageBox.Show("Se ha registrado correctamente el producto", "Almacenes Don chucho", MessageBoxButtons.OK);

            cargar_seguros();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            double total_cliente = new int();

            double incremento = int.Parse(txtseguroval.Text) * double.Parse(txtseguropor.Text)/100;

            double incremento_beneficiario = int.Parse(txtseguroval_b.Text) / int.Parse(txtNumeroBe.Text);

            total_cliente = int.Parse(txtseguroval.Text) + incremento + incremento_beneficiario;

            
        }
    }


}
