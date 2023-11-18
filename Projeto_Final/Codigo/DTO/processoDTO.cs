
namespace Projeto_Final.Codigo.DTO
{
    public class processoDTO
    {
        public int cod_processo { get; set; }
        public string numero_processo { get; set; }
        public apenadoDTO apenado = new apenadoDTO();
        public camaDTO cama = new camaDTO();
        public string descricao { get; set; }
        public string estado { get; set; }
    }
}
