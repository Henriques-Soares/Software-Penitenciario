using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projeto_Final.Codigo.DAL;
using Projeto_Final.Codigo.DTO;

namespace Projeto_Final.Codigo.BLL
{
    class visitanteBLL : Acesso_BancoDados
    {
        public DataTable ListarVisitante()
        {
            return retornarDados("select * from visitante");
        }

        //metodo para cadastrar Visitante
        public bool salvar(visitanteDTO _visitante)
        {
            try { 
            if (_visitante.nome_visitante == string.Empty) return msgErro("Informe o nome do Visitante!");
            if (_visitante.data_nascimento == string.Empty) return msgErro("Informe a Data de Nascimento do Visitante!");
            if (_visitante.genero == string.Empty) return msgErro("Informe o Genero do Visitante!");
            if (_visitante.bi == string.Empty) return msgErro("Informe o BI do Visitante!");
            if (_visitante.naturalidade == string.Empty) return msgErro("Informe a Naturalidade do Visitante!");
            if (_visitante.contacto.ToString() == string.Empty || _visitante.contacto <= 0) return msgErro("Informe o Número de Telefone do Visitante!");

            string sql = "insert into visitante(nome_visitante, data_nascimento, genero, bi, naturalidade, residencia, contacto) " +
                    "values( @nome_visitante, @data_nascimento, @genero, @bi, @naturalidade, @residencia, @contacto)";

            List<MySqlParameter> listaParametro = new List<MySqlParameter>();
            listaParametro.Clear();

            MySqlParameter parametro = new MySqlParameter("@nome_visitante", MySqlDbType.VarChar);
            parametro.Value = _visitante.nome_visitante;
            listaParametro.Add(parametro);

            parametro = new MySqlParameter("@data_nascimento", MySqlDbType.VarChar);
            parametro.Value = _visitante.data_nascimento;
            listaParametro.Add(parametro);

            parametro = new MySqlParameter("@genero", MySqlDbType.Enum);
            parametro.Value = _visitante.genero;
            listaParametro.Add(parametro);

            parametro = new MySqlParameter("@bi", MySqlDbType.VarChar);
            parametro.Value = _visitante.bi;
            listaParametro.Add(parametro);

            parametro = new MySqlParameter("@naturalidade", MySqlDbType.VarChar);
            parametro.Value = _visitante.naturalidade;
            listaParametro.Add(parametro);

            parametro = new MySqlParameter("@residencia", MySqlDbType.VarChar);
            parametro.Value = _visitante.residencia;
            listaParametro.Add(parametro);


            parametro = new MySqlParameter("@contacto", MySqlDbType.Int32);
            parametro.Value = _visitante.contacto;
            listaParametro.Add(parametro);


            if (executarComando(sql, listaParametro) == true) return msgInformacao("Visitante cadastrado com sucesso!");

            return msgErro("Ocorreu um erro ao cadastrar este Visitante!");

            }
            catch (Exception)
            {
                return false;
            }
        }

        //metodo para actualizar Visitante
        public bool alterar(visitanteDTO _visitante)
        {
            try
            {
                if (_visitante.nome_visitante == string.Empty) return msgErro("Insira o nome do Visitante!");

                string sql = "update visitante set nome_visitante = @nome_visitante, data_nascimento = @data_nascimento, genero = @genero, bi = @bi, naturalidade = @naturalidade, residencia = @residencia, contacto = @contacto  where cod_visitante = @id";
                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

               
                //parametro do nome
                MySqlParameter parametro = new MySqlParameter("@nome_visitante", MySqlDbType.VarChar);
                parametro.Value = _visitante.nome_visitante;
                listaParametro.Add(parametro);

                //parametro da data de nascimento
                parametro = new MySqlParameter("@data_nascimento", MySqlDbType.VarChar);
                parametro.Value = _visitante.data_nascimento;
                listaParametro.Add(parametro);

                //parametro do genero
                parametro = new MySqlParameter("@genero", MySqlDbType.Enum);
                parametro.Value = _visitante.genero;
                listaParametro.Add(parametro);

                //parametro do bi
                parametro = new MySqlParameter("@bi", MySqlDbType.VarChar);
                parametro.Value = _visitante.bi;
                listaParametro.Add(parametro);

                //parametro da naturalidade
                parametro = new MySqlParameter("@naturalidade", MySqlDbType.VarChar);
                parametro.Value = _visitante.naturalidade;
                listaParametro.Add(parametro);

                //parametro da residencia
                parametro = new MySqlParameter("@residencia", MySqlDbType.VarChar);
                parametro.Value = _visitante.residencia;
                listaParametro.Add(parametro);

                //parametro do contacto
                parametro = new MySqlParameter("@contacto", MySqlDbType.Int32);
                parametro.Value = _visitante.contacto;
                listaParametro.Add(parametro);

                //parametro do codigo do visitante
                parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _visitante.cod_visitate;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Visitante actualizado com sucesso!");
                return msgErro("Ocorreu um erro ao actualizar o Visitante!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        //metodo para remover Visitante
        public bool remover(visitanteDTO _visitante)
        {
            try
            {
                string sql = "delete from visitante where cod_visitante = @id";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _visitante.cod_visitate;
                listaParametro.Add(parametro);

                if(msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Visitante removido com sucesso!");

                //return msgErro("Ocorreu um erro ao remover o Visitante!");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}