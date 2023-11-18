
namespace Projeto_Final.Codigo.DTO
{
    public class funcionarioDTO
    {
        public int cod_funcionario { get; set; }
        public tipo_funcionarioDTO tipoFuncionario = new tipo_funcionarioDTO();
        public string nome_funcionario { get; set; }
        public string data_nascimento { get; set; }
        public string genero { get; set; }
        public string bi { get; set; }
        public string nome_pai { get; set; }
        public string nome_mae { get; set; }
        public provinciaDTO provincia = new provinciaDTO();
        public string naturalidade { get; set; }
        public string residencia { get; set; }
        public string estado_civil { get; set; }
        public float altura { get; set; }
        public string img { get; set; }
        public int nip { get; set; }
        public int tel1 { get; set; }
        public int tel2 { get; set; }
    }
}
