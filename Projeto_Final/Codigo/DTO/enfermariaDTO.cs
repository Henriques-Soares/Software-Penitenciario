namespace Projeto_Final.Codigo.DTO
{
    public class enfermariaDTO
    {
        public int cod_enfermagem { get; set; }
        public processoDTO processo = new processoDTO();
        public utilizadorDTO utilizador { get; set; }
        public string descricao { get; set; }
    }
}
