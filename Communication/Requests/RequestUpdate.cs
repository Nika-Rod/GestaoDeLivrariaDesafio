namespace GestãoDeLivrariaDesafio.Communication.Requests
{
    public class RequestUpdate
    {
        public string Title { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public double Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
