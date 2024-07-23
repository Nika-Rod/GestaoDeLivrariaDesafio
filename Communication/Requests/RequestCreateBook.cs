namespace GestãoDeLivrariaDesafio.Communication.Requests
{
    public enum Genero
    {
        Romance,
        Terror,
        Ficção,
        Aventura,
        Histórico,
        Infantil
    }
    public class RequestCreateBook
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public Genero Genero { get; set; } 
        public double Preco { get; set; }
        public int Quantidade { get; set; } 
    }
}
