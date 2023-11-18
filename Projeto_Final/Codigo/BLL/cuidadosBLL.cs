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
    public class cuidadosBLL : Acesso_BancoDados
    {
        public DataTable ListarCuidado()
        {
            return retornarDados("select * from cuidado, enfermagem where enfermagem.cod_enfermagem = cuidado.cod_enfermagem;");
        }

        public DataTable listarEnfermagem()
        {
            return retornarDados("select * from enfermagem");
        }

        public bool salvar(cuidadosDTO _cuidados)
        {
            try
            {
                if (_cuidados.enfermaria.cod_enfermagem.ToString() == string.Empty || _cuidados.enfermaria.cod_enfermagem <= 0) return msgErro("Escolha a enfermagem!");
                if (_cuidados.problema == string.Empty) return msgErro("Digite o Pooblema!");
                if (_cuidados.acao_implementada  == string.Empty) return msgErro("Digite a Ação Implementada!");
                if (_cuidados.data_registo == string.Empty) return msgErro("Digite a Data de Registo!");
                if (_cuidados.hora == string.Empty) return msgErro("Digite a Hora!");

                string sql = "insert into cuidado(cod_enfermagem, problema, acao_implementada, data_registo, hora) " +
                   "values(@cod_enfermagem, @problema, @acao_implementada, @data_registo, @hora)";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                listaParametro.Clear();

                MySqlParameter parametro = new MySqlParameter("@cod_enfermagem", MySqlDbType.Int32);
                parametro.Value = _cuidados.enfermaria.cod_enfermagem;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@problema", MySqlDbType.VarChar);
                parametro.Value = _cuidados.problema;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@acao_implementada", MySqlDbType.VarChar);
                parametro.Value = _cuidados.acao_implementada;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@data_registo", MySqlDbType.VarChar);
                parametro.Value = _cuidados.data_registo;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@hora", MySqlDbType.VarChar);
                parametro.Value = _cuidados.hora;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Cuidado Cadastrado com Sucesso!");

                return msgErro("Ocorreu um erro ao cadastrar Cuidado!");

            }
                catch (Exception)
            {
                    return false;
            
            }
        }

        public bool alterar(cuidadosDTO _cuidados)
        {
            try
            {
                if (_cuidados.enfermaria.cod_enfermagem.ToString() == string.Empty || _cuidados.enfermaria.cod_enfermagem <= 0) return msgErro("Escolha a enfermagem!");
                if (_cuidados.problema == string.Empty) return msgErro("Digite o Pooblema!");
                if (_cuidados.acao_implementada == string.Empty) return msgErro("Digite a Ação Implementada!");
                if (_cuidados.data_registo == string.Empty) return msgErro("Digite a Data de Registo!");
                if (_cuidados.hora == string.Empty) return msgErro("Digite a Hora!");

                string sql = "update cuidado set cod_enfermagem = @cod_enfermagem, problema = @problema," +
                    " acao_implementada = @acao_implementada, data_registo = @data_registo, hora = @hora " +
                    "where cod_cuidado = @cod_cuidado";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                listaParametro.Clear();

                MySqlParameter parametro = new MySqlParameter("@cod_enfermagem", MySqlDbType.Int32);
                parametro.Value = _cuidados.enfermaria.cod_enfermagem;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@problema", MySqlDbType.VarChar);
                parametro.Value = _cuidados.problema;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@acao_implementada", MySqlDbType.VarChar);
                parametro.Value = _cuidados.acao_implementada;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@data_registo", MySqlDbType.VarChar);
                parametro.Value = _cuidados.data_registo;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@hora", MySqlDbType.VarChar);
                parametro.Value = _cuidados.hora;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_cuidado", MySqlDbType.Int32);
                parametro.Value = _cuidados.cod_cuidado;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Cuidado actualizada com Sucesso!");

                return msgErro("Erro ao actualizar Cuidado!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool remover(cuidadosDTO _cuidados)
        {
            try
            {
                string sql = "delete from cuidado where cod_cuidado = @id";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                listaParametro.Clear();

                MySqlParameter parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _cuidados.cod_cuidado;
                listaParametro.Add(parametro);


                if (msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Visita removida com sucesso!");

                // return msgErro("Erro ao remover Cuidado!");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
