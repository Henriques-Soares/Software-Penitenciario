namespace Projeto_Final.Codigo.DTO
{
    public class visitaDTO
    {
        public int cod_visita { get; set; }
        public visitanteDTO visitante = new visitanteDTO();
        public processoDTO processo = new processoDTO();
        public string tipo_visita { get; set; }
        public string data_visita { get; set; }
        public string hora_visita { get; set; }

    }
}
