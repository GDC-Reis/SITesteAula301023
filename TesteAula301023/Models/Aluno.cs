using System.Globalization;

namespace TesteAula301023.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DataNasc { get; set; }
        public string Endereco { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }
        public double? Media { get; set; }
    }
}
