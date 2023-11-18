namespace Projeto_Final.Codigo.DTO
{
    public class refeitorioDTO
    {
        public int cod_refeitorio { get; set; }
        public processoDTO processo = new processoDTO();
        public alimentoDTO alimento = new alimentoDTO();
        public string tipo_refeicao { get; set; }
    }
}
