using AppDiscografica.Negocios;
using AppDiscografica.Clases;
namespace AppDiscograficaUI
{
    public partial class FrmPrincipal : Form
    {

        // Creamos la instancia del  (BO)
        private EventoNegocio negocio = new EventoNegocio();


        public FrmPrincipal()
        {
            InitializeComponent();

        }


        // Este evento se dispara apenas se abre la ventana
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            RefrescarGrilla();
        }

        // Creamos un método aparte para poder usarlo varias veces
        private void RefrescarGrilla()
        {
            // Traemos la lista desde el BO y la pegamos en el DataGridView
            dgvEventos.DataSource = null;
            dgvEventos.DataSource = negocio.ObtenerListaEventos();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (dgvEventos.SelectedRows.Count > 0)
            {
                // Capturamos el ID de la fila seleccionada (fundamental para SQL)
                int idSeleccionado = Convert.ToInt32(dgvEventos.CurrentRow.Cells["ID"].Value);

                // Creamos el objeto con los datos MODIFICADOS
                var eventoEditado = new Evento
                {
                    ID = idSeleccionado,
                    Nombre = txtNombre.Text,
                    ArtistaPrincipal = txtArtista.Text,
                    Fecha = dtpFecha.Value,
                    Precio = numPrecio.Value
                };

                // Llamamos al negocio
                string resultado = negocio.ActualizarEvento(eventoEditado);

                if (resultado == "OK")
                {
                    MessageBox.Show("Evento actualizado con éxito");
                    RefrescarGrilla();
                    LimpiarCampos();
                }
                else { MessageBox.Show(resultado); }
            }
            else { MessageBox.Show("Seleccione un evento para actualizar"); }
        }



        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que no sea el encabezado de la tabla
            if (e.RowIndex >= 0)
            {
                // Tomamos la fila actual
                DataGridViewRow fila = dgvEventos.Rows[e.RowIndex];

                // "Subimos" los datos de la grilla a los controles
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtArtista.Text = fila.Cells["ArtistaPrincipal"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);
                numPrecio.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // "Empaquetamos" los datos de los cuadritos en un objeto Evento
            var nuevoEvento = new AppDiscografica.Clases.Evento
            {
                Nombre = txtNombre.Text,
                ArtistaPrincipal = txtArtista.Text,
                Fecha = dtpFecha.Value,
                Precio = numPrecio.Value
            };

            // Le pasamos el paquete al Negocio
            string resultado = negocio.RegistrarEvento(nuevoEvento);

            if (resultado == "OK")
            {
                MessageBox.Show("¡Evento guardado con éxito!", "Sistema");
                RefrescarGrilla();
                LimpiarCampos();
            }
            else
            {
                // Si el precio era 0 o el nombre vacío, aquí saldrá el error
                MessageBox.Show(resultado, "Validación");
            }
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Aquí es donde el usuario hace clic para borrar todo
            LimpiarCampos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

            // Verificamos que el usuario haya seleccionado una fila
            if (dgvEventos.SelectedRows.Count > 0)
            {
                // Preguntamos por seguridad (Confirmación de usuario)
                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este evento?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    // Capturamos el ID de la fila seleccionada
                    int idEliminar = Convert.ToInt32(dgvEventos.CurrentRow.Cells["ID"].Value);

                    // Llamamos al negocio para que ejecute la baja
                    negocio.BorrarEvento(idEliminar);

                    // Actualizamos la interfaz
                    MessageBox.Show("Evento eliminado correctamente.");
                    RefrescarGrilla();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila de la tabla para eliminar.");
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            string textoNombre = txtNombre.Text; 
            string textoArtista = txtArtista.Text;

            string textoBusqueda = "";

            if (!string.IsNullOrWhiteSpace(textoNombre))
            {
                textoBusqueda = textoNombre;
            }
            // Si el Nombre está vacío, revisamos si escribió en el Artista
            else if (!string.IsNullOrWhiteSpace(textoArtista))
            {
                textoBusqueda = textoArtista;
            }

            // Ahora sí, hacemos la búsqueda con el texto que hayamos encontrado
            if (!string.IsNullOrWhiteSpace(textoBusqueda))
            {
                var resultados = negocio.BuscarEventos(textoBusqueda);
                dgvEventos.DataSource = resultados;
            }
            else
            {
                MessageBox.Show("Por favor, escribe algo en el campo Nombre o Artista para buscar.");
                dgvEventos.DataSource = negocio.ObtenerListaEventos();
            }
        }


        // -------------------------------
        //      Otros Métodos
        // -------------------------------


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtArtista.Clear();
            numPrecio.Value = numPrecio.Minimum;
            dtpFecha.Value = DateTime.Now;
            txtNombre.Focus();
        }


    }//class
}//namespace
