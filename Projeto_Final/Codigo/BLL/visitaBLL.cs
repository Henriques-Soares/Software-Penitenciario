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
    public class visitaBLL : Acesso_BancoDados
    {
        public DataTable ListarVisita()
        {
            return retornarDados("select * from visita, visitante, processo where " +
                "visitante.cod_visitante = visita.cod_visitante and processo.cod_processo = visita.cod_processo; ");
        }

        public DataTable listarVisitante()
        {
            return retornarDados("select * from visitante");
        }
        
        public DataTable listarProcesso()
        {
            return retornarDados("select * from processo, apenado where apenado.cod_apenado = processo.cod_apenado");
        }

        public bool salvar(visitaDTO _visita)
        {
            try
            {
                if (_visita.visitante.cod_visitate.ToString() == string.Empty || _visita.visitante.cod_visitate <= 0) return msgErro("Escolha o Visitante!");
                if (_visita.processo.cod_processo.ToString() == string.Empty || _visita.processo.cod_processo <= 0) return msgErro("Escolha o Nº PRocesso!");
                if (_visita.tipo_visita == string.Empty) return msgErro("Escolha o Tipo de Visita!");
                if (_visita.data_visita == string.Empty) return msgErro("Escolha a Data da Visita!");
                if (_visita.hora_visita == string.Empty) return msgErro("Escolha a Hora da Visita!");

                string sql = "insert into visita(cod_visitante, cod_processo, tipo_visita, data_visita, hora_visita) " +
                    "values(@cod_visitante, @cod_processo, @tipo_visita, @data_visita, @hora_visita)";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                listaParametro.Clear();

                MySqlParameter parametro = new MySqlParameter("@cod_visitante", MySqlDbType.Int32);
                parametro.Value = _visita.visitante.cod_visitate;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_processo", MySqlDbType.Int32);
                parametro.Value = _visita.processo.cod_processo;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@tipo_visita", MySqlDbType.Enum);
                parametro.Value = _visita.tipo_visita;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@data_visita", MySqlDbType.VarChar);
                parametro.Value = _visita.data_visita;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@hora_visita", MySqlDbType.VarChar);
                parametro.Value = _visita.hora_visita;
                listaParametro.Add(parametro);


                
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Visita Cadastrado com Sucesso!");

                return msgErro("Ocorreu um erro ao cadastrar Visita!");
                
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool alterar(visitaDTO _visita)
        {
            try
            {

                if (_visita.visitante.cod_visitate.ToString() == string.Empty || _visita.visitante.cod_visitate <= 0) return msgErro("Escolha o Visitante!");
                if (_visita.processo.cod_processo.ToString() == string.Empty || _visita.processo.cod_processo <= 0) return msgErro("Escolha o Nº PRocesso!");
                if (_visita.tipo_visita == string.Empty) return msgErro("Escolha o Tipo de Visita!");
                if (_visita.data_visita == string.Empty) return msgErro("Escolha a Data da Visita!");
                if (_visita.hora_visita == string.Empty) return msgErro("Escolha a Hora da Visita!");

                string sql = "update visita set cod_visitante = @cod_visita, cod_processo = @cod_processo, tipo_visita = @tipo_visita, " +
                    "data_visita = @data_visita, hora_visita = @hora_visita where cod_visita = @cod_visita";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                listaParametro.Clear();

                MySqlParameter parametro = new MySqlParameter("@cod_visitante", MySqlDbType.Int32);
                parametro.Value = _visita.visitante.cod_visitate;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_processo", MySqlDbType.Int32);
                parametro.Value = _visita.processo.cod_processo;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@tipo_visita", MySqlDbType.Enum);
                parametro.Value = _visita.tipo_visita;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@data_visita", MySqlDbType.VarChar);
                parametro.Value = _visita.data_visita;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@hora_visita", MySqlDbType.VarChar);
                parametro.Value = _visita.hora_visita;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_visita", MySqlDbType.Int32);
                parametro.Value = _visita.cod_visita;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Visita actualizada com Sucesso!");

                return msgErro("Erro ao actualizar Visita!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool remover(visitaDTO _visita)
        {
            try
            {
                string sql = "delete from visita where cod_visita = @id";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                listaParametro.Clear();

                MySqlParameter parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _visita.cod_visita;
                listaParametro.Add(parametro);

                if (msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Visita removida com sucesso!");

                //return msgErro("Erro ao remover Visita!");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
