using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Final.Codigo.DAL;
using Projeto_Final.Codigo.DTO;
using System.Data;

namespace Projeto_Final.Codigo.BLL
{
    public class dashbardBLL : Acesso_BancoDados
    {
        public double qtdApenado()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();                
                dt = retornarDados("select count(*) from apenado");
                return  dt.Rows.Count == 0 ? 0 : double.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public double qtdProcesso()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt = retornarDados("select count(*) from processo");
                return dt.Rows.Count == 0 ? 0 : double.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public double qtdApenadoDetido()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt = retornarDados("select count(*) qtd from processo where estado = 'Detido'");
                return dt.Rows.Count == 0 ? 0 : double.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public double qtdApenadoSolto()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt = retornarDados("select count(*) qtd from processo where estado = 'Solto'");
                return dt.Rows.Count == 0 ? 0 : double.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public double qtdApenadoM()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt = retornarDados("select count(*) from apenado where apenado.genero='Masculino'");
                return dt.Rows.Count == 0 ? 0 : double.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public double qtdApenadoF()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt = retornarDados("select count(*) qtd from apenado where cod_apenado in(select cod_apenado from processo) and genero = 'Feminino'");
                return dt.Rows.Count == 0 ? 0 : double.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
}
