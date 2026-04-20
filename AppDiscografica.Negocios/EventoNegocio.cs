using AppDiscografica.Clases;
using AppDiscografica.Datos;

namespace AppDiscografica.Negocios
{
    public class EventoNegocio
    {

        // Instancia privada del DAO para interactuar con SQL
        private EventoDAO dao = new EventoDAO();


        public List<Evento> BuscarEventos(string criterio)
        {
            // El negocio simplemente le pide al DAO que haga la búsqueda
            return dao.BuscarEventos(criterio);
        }


        // Obtiene la lista completa de eventos sin filtros adicionales
        public List<Evento> ObtenerListaEventos()
        {
            return dao.ObtenerTodos();
        }

        // Valida los datos del evento antes de autorizar la inserción
        public string RegistrarEvento(Evento nuevoEvento)
        {
            if (string.IsNullOrWhiteSpace(nuevoEvento.Nombre))
                return "El nombre del evento es obligatorio.";

            if (nuevoEvento.Precio <= 0)
                return "El precio debe ser un valor positivo.";

            // Si pasa las validaciones, se envía al DAO
            dao.AgregarEvento(nuevoEvento);
            return "OK";
        }

        // Método para eliminar, llamando al DAO mediante el ID
        public void BorrarEvento(int id)
        {
            dao.EliminarEvento(id);
        }


        public string ActualizarEvento(Evento eventoEditado)
        {
            // Aplicamos las mismas reglas que al guardar
            if (string.IsNullOrWhiteSpace(eventoEditado.Nombre))
                return "El nombre no puede estar vacío.";

            if (eventoEditado.Precio <= 0)
                return "El precio debe ser mayor a cero.";

            // Si todo está bien, le damos la orden al DAO
            dao.ActualizarEvento(eventoEditado);

            return "OK";
        }

    }//class
}//namespace
