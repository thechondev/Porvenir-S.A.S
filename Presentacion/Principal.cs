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
            foreach (var lista in objetoCN.listado_ventas())
            {
                lstVentas.Items.Add(lista.Replace(',', ' '));
            }
        }

        CN_Negocio objetoCN = new CN_Negocio();
        string[] seguro = new string[5];

        public void cargar_seguros()
        {
            cboseguros.DataSource = null;
            cboseguros.Items.Clear();

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

       
        private void cmdBuscarSeg_Click(object sender, EventArgs e)
        {
            //Revisar si se puede buscar mediante el combobox
            if (cboseguros.Text != "")
            {
                string[] cadena_busqueda = new string[2];
                cadena_busqueda = cboseguros.Text.Split(new char[] {' '});
                //invocar la funcion de buscar
                objetoCN.Busqueda_seguros(cadena_busqueda[0]);

                //mostrar las propiedades en una caja de texto
                txtsegurocod.Text = objetoCN.codigo.ToString();
                txtsegurotip.Text = objetoCN.tipo.ToString();
                txtseguroval.Text = objetoCN.valor.ToString();
                txtseguropor.Text = objetoCN.porcentaje_in.ToString();
                txtseguroval_b.Text = objetoCN.valor_be.ToString();

            }
            else
            {
                try
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
                catch(Exception)
                {
                    MessageBox.Show("No se intrudijieron los datos correctamente");
                }
                
            }

           
        }

        private void cmdVenta_Click(object sender, EventArgs e)
        {
            //limpiar la listbox
            lstVentas.DataSource = null;
            lstVentas.Items.Clear();

            //Se calcula la venta previamente
            cmdCalcular.PerformClick();

            //Se le entregan las ventas al objeto CN para que luego se guarden envie a CD y al archivo plano
            objetoCN.Insertar_ventas(txtsegurocod.Text, txtsegurotip.Text,txtseguroval.Text,txtIDcliente.Text,
                txtNombreCliente.Text,txtNumeroCliente.Text,txtNumeroBe.Text,lbltotal.Text);

            //cargar la venta en la lista.
            foreach (var lista in objetoCN.listado_ventas())
            {
                lstVentas.Items.Add(lista.Replace(',',' '));
            }

            MessageBox.Show("Se ha registrado correctamente la venta", "Porvenir S.A.S", MessageBoxButtons.OK);

            cargar_seguros();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            //se busca previamente el seguro
            cmdBuscarSeg.PerformClick();

            //se calcula el total e incremento
            try
            {

                double total_cliente = new int();

                double incremento = int.Parse(txtseguroval.Text) * (double.Parse(txtseguropor.Text) / 100);

                double incremento_beneficiario = incremento * int.Parse(txtNumeroBe.Text);

                lblvalori.Text = incremento_beneficiario.ToString();

                total_cliente = int.Parse(txtseguroval.Text) + incremento_beneficiario;

                lbltotal.Text = total_cliente.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio el error " + error.Message);
            }

        }

        private void cboseguros_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdBuscarSeg.PerformClick();
        }
        
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
