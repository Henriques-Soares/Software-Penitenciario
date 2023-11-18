
namespace Projeto_Final.Codigo.DTO
{
    public class permissaoDTO
    {
        public int cod_permissao { get; set; }
        public string nome_permissao { get; set; }
        public string descricao_permissaoo { get; set; }
        public funcaoDTO funcaoDto = new funcaoDTO();
    }
}