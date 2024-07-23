using GestãoDeLivrariaDesafio.Communication.Requests;

namespace GestãoDeLivrariaDesafio.Communication.Response
{
    public class ResponseGetBook
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public Genero Genero { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
