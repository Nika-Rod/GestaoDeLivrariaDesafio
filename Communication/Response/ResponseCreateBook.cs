namespace GestãoDeLivrariaDesafio.Communication.Response
{
    public class ResponseCreateBook
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
    }
}
