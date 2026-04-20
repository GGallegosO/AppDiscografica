using AppDiscografica.Clases;

namespace AppDiscografica.Datos
{
    public class EventoDAO
    {

        // CREAR: Inserta un nuevo concierto en la DB
        public void AgregarEvento(Evento nuevo)
        {
            using (var db = new AppDbContext())
            {
                db.Eventos.Add(nuevo);
                db.SaveChanges();
            }
        }


        // LEER (Listado completo): Para la grilla principal
        public List<Evento> ObtenerTodos()
        {
            using (var db = new AppDbContext())
            {
                return db.Eventos.ToList();
            }
        }


        // BUSCAR (Por ID): Para cargar datos antes de editar o borrar
        public Evento? BuscarPorId(int id)
        {
            using (var db = new AppDbContext())
            {
                return db.Eventos.FirstOrDefault(e => e.ID == id);
            }
        }


        // ACTUALIZAR: Modifica los datos de un evento existente
        public void ActualizarEvento(Evento eventoModificado)
        {
            using (var db = new AppDbContext())
            {
                // Buscamos el original en la DB
                var original = db.Eventos.FirstOrDefault(e => e.ID == eventoModificado.ID);

                if (original != null)
                {
                    // Actualizamos cada campo
                    original.Nombre = eventoModificado.Nombre;
                    original.ArtistaPrincipal = eventoModificado.ArtistaPrincipal;
                    original.Fecha = eventoModificado.Fecha;
                    original.Precio = eventoModificado.Precio;

                    db.SaveChanges(); // Impacta los cambios en SQL
                }
            }
        }


        // ELIMINAR: Quita un registro de la base de datos
        public void EliminarEvento(int id)
        {
            using (var db = new AppDbContext())
            {
                var evento = db.Eventos.FirstOrDefault(e => e.ID == id);
                if (evento != null)
                {
                    db.Eventos.Remove(evento);
                    db.SaveChanges();
                }
            }
        }


    } // Class EventoDAO

} // namspace
