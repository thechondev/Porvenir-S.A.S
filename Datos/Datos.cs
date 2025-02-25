using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CD_Datos
    {
        //Se declaran las variables del tipo de seguro
        public string codigo {  get; set; }
        public string tipo { get; set; }
        public string valor {  get; set; }
        public string porcentaje_in {  get; set; }
        public string valor_be {  get; set; }

        // Se declaran las variables del cliente
        public string ID_cliente { get; set; }
        public string Nombre_cliente { get; set; }
        public string Numero_cliente { get; set; }


        //Variables para los stream
        private FileStream archivo = null;
        private StreamReader lector = null;
        private StreamWriter escritor = null;

        //Almecanar los productos en lista y su forma de recorrer
        List<string> lista_seguros = new System.Collections.Generic.List<string>();

        //Rutas del archivos
        private string ruta_seguros = @"..\..\recursos\seguros.txt";
        private string ruta_ventas = @"..\..\recursos\ventas.txt";

        public string mensaje = "";

        //insertar datos del seguro
        public void insertar_seguro(string cod, string tip, string val, string por, string val_b)
        {
            try
            {
                //indicar el archivo a usar
                archivo = new FileStream(ruta_seguros, FileMode.Append, FileAccess.Write);
                //crear al escritor
                escritor = new StreamWriter(archivo);
                //Escribir los datos en el archivo (y establecer su formato)
                escritor.WriteLine(cod + ',' + tip + ',' + val + ',' + por + ',' + val_b);
                //Se cierra al chimoso porque es el que esta manipulando el archivo
                escritor.Close();

                mensaje = "¡Se ha registrado el producto!";

            }
            catch (IOException ex)
            {
                mensaje = "ERROR #1" + ex.Message;
            }

        }//aqui acaba insertar seguro

        //Metodo para listar objetos (servicio#2)
        public List<String> listado()
        {
            try
            {
                //Especificando el modo de apertura (lectura)
                archivo = new FileStream(ruta_seguros, FileMode.Open, FileAccess.Read);
                //Crear al lector
                lector = new StreamReader(archivo);
                //LA VARIABLE LINEA
                string linea;
                //Recorrer el archivo
                while ((linea = lector.ReadLine()) != null)
                {
                    lista_seguros.Add(linea);
                }

                //Se cierra al chimoso porque es el que esta manipulando el archivo
                lector.Close();


            }
            catch (IOException ex)
            {
                mensaje = "ERROR #2" + ex.Message;
            }

            return lista_seguros;
        }//aqui acaba lista

        //Buscar un seguro por su codigo
        public void buscar(string cod)
        {
            try
            {
                //Especificando el modo de apertura (lectura)
                archivo = new FileStream(ruta_seguros, FileMode.Open, FileAccess.Read);
                //Crear al lector
                lector = new StreamReader(archivo);
                //LA VARIABLE LINEA
                string linea;
                //Creando el vector para almecenar los datos separados
                string[] cadena = new string[5];
                //Creando variable booleana de encontrado
                bool encontro = false;

                //Recorrer el archivo
                while ((linea = lector.ReadLine()) != null)
                {
                    //separar la linea (por char coma) y almacenarla en el vector
                    cadena = linea.Split(new char[] { ',' });
                    if (cadena[0] == cod)
                    {
                        encontro = true;
                        break;
                    }

                }
                if (encontro == true)
                {
                    codigo = cadena[0];
                    tipo = cadena[1];
                    valor = cadena[2];
                    porcentaje_in = cadena[3];
                    valor_be = cadena[4];
                }
                //Se cierra al chimoso porque es el que esta manipulando el archivo
                lector.Close();


            }
            catch (IOException ex)
            {
                mensaje = "ERROR #3" + ex.Message;
            }

        }//aqui acaba buscar

        //Insertar datos de venta
        public void insertar_venta(string cod, string tip, string val, string por, string val_b)
        {
            try
            {
                //indicar el archivo a usar
                archivo = new FileStream(ruta_ventas, FileMode.Append, FileAccess.Write);
                //crear al escritor
                escritor = new StreamWriter(archivo);
                //Escribir los datos en el archivo (y establecer su formato)
                escritor.WriteLine();
                //Se cierra al chimoso porque es el que esta manipulando el archivo
                escritor.Close();

                mensaje = "¡Se ha registrado el producto!";

            }
            catch (IOException ex)
            {
                mensaje = "ERROR #2" + ex.Message;
            }

        }//aqui acaba insertar venta

    }
}
