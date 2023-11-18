using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Projeto_Final.Codigo.DTO;
using Projeto_Final.Codigo.DAL;
using MySql.Data.MySqlClient;


namespace Projeto_Final.Codigo.BLL
{
    public class enfermariaBLL : Acesso_BancoDados
    {
        public DataTable listarEnfermaria()
        {
            return retornarDados("select * from enfermagem, processo, utilizador where processo.cod_processo = enfermagem.cod_processo and utilizador.cod_utilizador = enfermagem.cod_utilizador;");
        }

        //metodo para retornar a lista de processo
        public DataTable listaProcesso()
        {
            return retornarDados("select * from processo");
        }

        //metodo para retornar a lista de utilizador
        public DataTable listarUtilizador()
        {
            return retornarDados("select * from utilizador");

        }

        //metodo para cadastrar enfermagem
        public bool salvar(enfermariaDTO _enfermagem)
        {
            try
            {
                if (_enfermagem.utilizador.codUtilizador.ToString() == string.Empty || _enfermagem.utilizador.codUtilizador <= 0) return msgErro("Informe o Utilizador!");
                if (_enfermagem.descricao == string.Empty) return msgErro("Imforme a Descrição");
                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                MySqlParameter parametro = new MySqlParameter("enfermagem", MySqlDbType.VarChar);

                string sql = "insert into enfermagem(cod_processo, cod_utilizador, descricao) " +
                    "values(@cod_processo, @cod_utilizador, @descricao)";

                parametro.Value = _enfermagem.cod_enfermagem;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_processo", MySqlDbType.Int32);
                parametro.Value = _enfermagem.processo.cod_processo;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_utilizador", MySqlDbType.Int32);
                parametro.Value = _enfermagem.utilizador.codUtilizador;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@descricao", MySqlDbType.Text);
                parametro.Value = _enfermagem.descricao;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Enfermagem cadastrado com Sucesso!");
                return msgErro("Ocorreu um erro ao cadastrar a Enfermagem!");
            }
            catch (Exception)
            {
                return false;
            }

        }
        //metodo para alterar Enfermagem
        public bool alterar(enfermariaDTO _enfermagem)
        {
            try
            {
                if (_enfermagem.processo.cod_processo.ToString() == string.Empty || _enfermagem.processo.cod_processo <= 0) return msgErro("Informe o Número do Processo!");


                string sql = "update enfermagem set cod_processo = @processo, cod_utilizador = @cod_utilizador, descricao = @descricao where cod_enfermagem = @id_enfermagem";
                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@processo", MySqlDbType.Int32);
                parametro.Value = _enfermagem.processo.cod_processo;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_utilizador", MySqlDbType.Int32);
                parametro.Value = _enfermagem.utilizador.codUtilizador;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@descricao", MySqlDbType.Text);
                parametro.Value = _enfermagem.descricao;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@id_enfermagem", MySqlDbType.Int32);
                parametro.Value = _enfermagem.cod_enfermagem;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Enfermagem alterada com Sucesso!");
                return msgErro("Ocorreu um erro ao alterar a Enfermagem!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        //metodo para remover a Enfermagem
        public bool remover(enfermariaDTO _enfermagem)
        {
            try
            {
                string sql = "delete from enfermagem where cod_enfermagem = @id_enfermagem";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@id_enfermagem", MySqlDbType.Int32);
                parametro.Value = _enfermagem.cod_enfermagem;
                listaParametro.Add(parametro);


                if(msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Enfermagem removida com Sucesso!");
                //return msgErro("Ocorreu um erro ao remover a Enfermagem!");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
