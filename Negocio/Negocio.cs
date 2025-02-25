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

        //Metodo para insertar los valores entre CD y CN
        public void Insertar_Seguros(string cod, string tip, string val, string por, string val_b)
        {
            objeto_CD.insertar_seguro(cod, tip, val, por, val_b);
        }

        //listado de seguros
        public List<string> listado_seguros()
        {
            //Traer los datos de la Capa de Datos a la Capa de Negocios
            List<String> lista = new List<string>();
            lista = objeto_CD.listado();

            return lista;
        }

        //Metodo de busqueda
        public void Busqueda_seguros(string cod)
        {
            objeto_CD.buscar(cod);
            codigo = objeto_CD.codigo;
            tipo = objeto_CD.tipo;
            valor = objeto_CD.valor;
            porcentaje_in = objeto_CD.porcentaje_in;
            valor_be = objeto_CD.valor_be;
        }
    }
}
