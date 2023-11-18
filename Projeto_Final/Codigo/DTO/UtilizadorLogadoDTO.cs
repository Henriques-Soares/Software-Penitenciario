using System.Collections;
using System.Collections.Generic;

namespace Projeto_Final.Codigo.DTO
{
    public static class UtilizadorLogadoDTO
    {
        public static int codUtilizador { get; set; }
        public static int codFuncionario { get; set; }
        public static string nomeUtilizador { get; set; }
        public static string senha { get; set; }
        public static List<string> Permissao = new List<string>();
    }
}
