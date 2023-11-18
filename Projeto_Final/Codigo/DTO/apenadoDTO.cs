namespace Projeto_Final.Codigo.DTO
{
    public class apenadoDTO
    {
        public int cod_apenado { get; set; }
        public string nome_apenado { get; set; }
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
        public string apelido { get; set; }
        public string descricao { get; set; }
    }
}
