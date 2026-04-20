namespace AppDiscografica.Clases
{
    public class Evento
    {

        public int ID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string ArtistaPrincipal { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }

    } // class
} // namespace
