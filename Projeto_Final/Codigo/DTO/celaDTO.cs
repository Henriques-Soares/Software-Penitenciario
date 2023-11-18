namespace Projeto_Final.Codigo.DTO
{
    public class celaDTO
    {
        public int cod_cela { get; set; }
        public string nome_cela { get; set; }
        public blocoDTO bloco = new blocoDTO();
    }
}
