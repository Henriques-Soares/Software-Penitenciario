namespace Projeto_Final.Codigo.DTO
{
    public class cuidadosDTO
    {
        public int cod_cuidado { get; set; }
        public enfermariaDTO enfermaria = new enfermariaDTO();
        public string problema { get; set; }
        public string acao_implementada { get; set; }
        public string data_registo { get; set; }
        public string hora { get; set; }
    }
}
