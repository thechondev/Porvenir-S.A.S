using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CN_Negocio
    {
        private CD_Datos objeto_CD = new CD_Datos();


        //Atributos entre el CD y CN
        public string codigo { get; set; }
        public string tipo { get; set; }
        public string valor { get; set; }
        public string porcentaje_in { get; set; }
        public string valor_be { get; set; }

        //atributos del cliente
        public string ID_cliente { get; set; }
        public string Nombre_cliente { get; set; }
        public string Numero_cliente { get; set; }
        public string Numero_beneficiarios { get; set; }
        public string Valor_totalseguro { get; set; }


        //Metodo para insertar los valores entre CD y CN
        public void Insertar_Seguros(string cod, string tip, string val, string por, string val_b)
        {
            objeto_CD.insertar_seguro(cod, tip, val, por, val_b);
        }

        public void Insertar_ventas(string cod, string tip, string val, string id_c, string nom_c, string num_c, string num_be, string val_t)
        {
            objeto_CD.insertar_venta(cod, tip, val, id_c,nom_c , num_c, num_be, val_t);
        }

        //listado de seguros
        public List<string> listado_seguros()
        {
            //Traer los datos de la Capa de Datos a la Capa de Negocios
            List<String> lista_seguros = new List<string>();
            lista_seguros = objeto_CD.listado_seguros();

            return lista_seguros;
        }

        //listado de ventas
        public List<string> listado_ventas()
        {
            //Traer los datos de la Capa de Datos a la Capa de Negocios
            List<String> lista_ventas = new List<string>();
            lista_ventas = objeto_CD.listado_ventas();

            return lista_ventas;
        }

        //Metodo de busqueda
        public void Busqueda_seguros(string cod)
        {
            objeto_CD.buscar_seguros(cod);
            codigo = objeto_CD.codigo;
            tipo = objeto_CD.tipo;
            valor = objeto_CD.valor;
            porcentaje_in = objeto_CD.porcentaje_in;
            valor_be = objeto_CD.valor_be;
        }

        public class ventaSevicio
        {
            /*
             * private Venta datosventa = new venta();
             * 
             * public venta calularVenta (string ID_cliente, string Nombre_cliente string contacto cliente,
             * Seguro seguro, int beneficiarios )
             * {
             * IncremBenfciario=valorSeguro * (0.10 * cantidadBenefciarios);
             *  incrementotipo= valorSeguro * porcentaje / 100;
             *
             *  valorBenefciario= valorbenefico / cantidadbeneficiario
             *  totalvalor = valorseguro + IncremBenfciario + incrementotipo +  IncremBenfciario
             * 
             * 
             * 
             * 
             * }



             */


        }

        public class seguroServicio
        { 
        
        
        }


    }
}
