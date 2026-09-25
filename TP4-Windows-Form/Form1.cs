// LINQ - Sirve para hacer consultas de tablas
// Languaje integrate query
// Workbench - utilizada para sql
// SQL (Structured Query Language)

// Linq utiliza SQL Syntax y method Syntax de c#

// Dock indica a que direccion queremos que se expanda las herramientas de la ventana. DockStyle.Fill indica que se expanda a toda la ventana
// Datagridview
// Agregar: SelectMode: FullRowSelect | AutoSizeRows: Fill
// poner en false: allowUserAddRows - AllowUserDeleteRows - AllowUserOrderRows
using System.Collections.Generic; // <- Nos permite utilizar Listas, Diccionarios
using System.Text.RegularExpressions;
namespace TP4_Windows_Form
{
    public partial class Form1 : Form
    {
        public List<ContenidoAudioVisual> contenidos;
        public Form1()
        {

            InitializeComponent();
            contenidos = CargarDatos();

            dataGridView1.AutoGenerateColumns = false;
            ConfigurarColumnas();
            dataGridView1.DataSource = contenidos; // <- DataSource es la fuente de los datos. Sirve para modificar los datos
            cmbGenero.DataSource = Enum.GetValues(typeof(Genero));
            cmbGenero.SelectedIndex = -1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbPelicula.Checked = true;
            ActualizarCamposPorTipo();
        }

        private void ActualizarCamposPorTipo()
        {
            panelCheckPelicula.Visible = rbPelicula.Checked;
            panelCheckSerie.Visible = rbSerie.Checked;
        }

        private void ConfigurarColumnas()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Director",
                HeaderText = "Director"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Anio",
                HeaderText = "Año"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Genero",
                HeaderText = "Género"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TipoContenido",
                HeaderText = "Tipo"
            });

            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Destacado",
                HeaderText = "Destacado",
                ReadOnly = true
            });

            //  Columna de Ver info 
            dataGridView1.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colVerMas",
                HeaderText = "Ver Más",
                Text = "👁",
                UseColumnTextForButtonValue = true,
                Width = 40
            });

            //  Columna de eliminar 
            dataGridView1.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colEliminar",
                HeaderText = "Eliminar",
                Text = "🗑",
                UseColumnTextForButtonValue = true,
                Width = 40
            });



        }

        public List<ContenidoAudioVisual> CargarDatos()
        {
            contenidos = new List<ContenidoAudioVisual>
            {
                new Pelicula(1, "El Padrino", "Francis Ford Coppola", 1972,  Genero.Crimen, true, 175),
                new Pelicula(2, "El Caballero Oscuro", "Christopher Nolan", 2008, Genero.Accion, false, 152),
                new Pelicula(3, "Pulp Fiction", "Quentin Tarantino", 1994, Genero.Crimen, true, 154),
                new Pelicula(4, "Forrest Gump", "Robert Zemeckis", 1994, Genero.Drama, false, 142),
                new Pelicula(5, "Inception", "Christopher Nolan", 2010, Genero.CienciaFiccion, true, 148),
                new Pelicula(6, "La La Land", "Damien Chazelle", 2016, Genero.Drama, false, 135),
                new Pelicula(7, "Gladiador", "Ridley Scott", 2000, Genero.Accion, false, 155),
                new Pelicula(8, "Titanic", "James Cameron", 1997, Genero.Romance, false, 194),
                new Pelicula(9, "Matrix", "Lana y Lilly Wachowski", 1999, Genero.CienciaFiccion, false, 136),
                new Pelicula(10, "El Señor de los Anillos: La Comunidad del Anillo", "Peter Jackson", 2001, Genero.CienciaFiccion, false, 179),
                new Serie(11, "Breaking Bad", "Vince Gilligan", 2008, Genero.Crimen, true, 5),
                new Serie(12, "Stranger Things", "Duffer Brothers", 2016, Genero.CienciaFiccion, false, 4)
            };


            return contenidos;
        }



        // FILTROS
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text.Trim().ToLower(); // <- Convertimos a minusculas para que no sea case sensitive

            if (filtro == string.Empty)
            {
                MessageBox.Show("Tenes que agregar un nombre para el filtro", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            var resultado = contenidos
                .Where(p => p.Nombre.ToLower().Contains(filtro) || p.Director.ToLower().Contains(filtro) || p.Genero.ToString().ToLower().Contains(filtro))
                .OrderBy(p => p.Anio)
                .ToList();

            dataGridView1.DataSource = resultado;
        }


        private void btnFiltroCrimen_Click(object sender, EventArgs e)
        {
            var resultado = contenidos
                 .Where(p => p.Genero == Genero.Crimen)
                 .OrderBy(p => p.Anio)
                 .ToList();
            dataGridView1.DataSource = resultado;
        }

        private void btnAccionFiltro_Click(object sender, EventArgs e)
        {
            var resultado = contenidos
                .Where(p => p.Genero == Genero.Accion)
                .OrderBy(p => p.Anio)
                .ToList();
            dataGridView1.DataSource = resultado;
        }

        private void btnFiltroRomance_Click(object sender, EventArgs e)
        {
            var resultado = contenidos
     .Where(p => p.Genero == Genero.Romance)
     .OrderBy(p => p.Anio)
     .ToList();
            dataGridView1.DataSource = resultado;
        }

        private void btnDramaFiltro_Click(object sender, EventArgs e)
        {
            var resultado = contenidos
    .Where(p => p.Genero == Genero.Drama)
    .OrderBy(p => p.Anio)
    .ToList();
            dataGridView1.DataSource = resultado;
        }

        private void btnBorrarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            dataGridView1.DataSource = contenidos;
        }

        // =========================================

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Falta completar el campo: Nombre", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDirector.Text))
            {
                MessageBox.Show("Falta completar el campo: Director", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDirector.Focus();
                return;
            }

            if (cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar el Género", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGenero.DroppedDown = true;
                return;
            }

            if (!int.TryParse(txtAnio.Text, out int anio) || anio <= 0 || anio > 2026)
            {
                MessageBox.Show("Año inválido o vacío. Complete con un número válido.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnio.Focus();
                return;
            }

            if (rbPelicula.Checked)
            {
                if (!int.TryParse(txtDuracion.Text, out int duracion) || duracion <= 0 || duracion > 54000)
                {
                    MessageBox.Show("Duración inválida o vacía. Complete con un número de minutos válido.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDuracion.Focus();
                    return;
                }
            }
            else
            {
                if (!int.TryParse(txtTemporadas.Text, out int temporadas) || temporadas <= 0)
                {
                    MessageBox.Show("Cantidad de temporadas inválida o vacía. Complete con un número válido.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTemporadas.Focus();
                    return;
                }
            }

            // aca todos los campos son válidos
            string nombre = txtName.Text.Trim();
            string director = txtDirector.Text.Trim();
            Genero genero = (Genero)cmbGenero.SelectedItem;
            int id = contenidos.Count + 1;
            bool destacado = chkDestacado.Checked;

            ContenidoAudioVisual nuevo;

            if (rbPelicula.Checked)
                nuevo = new Pelicula(id, nombre, director, anio, genero, destacado, int.Parse(txtDuracion.Text));
            else
                nuevo = new Serie(id, nombre, director, anio, genero, destacado, int.Parse(txtTemporadas.Text));

            contenidos.Add(nuevo);
            dataGridView1.DataSource = null; // <- Para que se refresque el datagridview
            dataGridView1.DataSource = contenidos;

            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        public void LimpiarFormulario()
        {
            txtName.Clear();
            txtDirector.Clear();
            txtAnio.Clear();
            cmbGenero.SelectedIndex = -1; // <- Para que no quede seleccionado ningun genero
            txtDuracion.Clear();
            txtTemporadas.Clear();
            chkDestacado.Checked = false;
            rbPelicula.Checked = true;
            ActualizarCamposPorTipo();
            dataGridView1.ClearSelection();
        }

        private void btnMostrarMas_Click(object sender, EventArgs e)
        {
            panelMas.Visible = !panelMas.Visible; // <- Si esta visible lo oculta y si esta oculto lo muestra
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void rbPelicula_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCamposPorTipo();

        }

        private void rbSerie_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCamposPorTipo();

        }


        // Permite el formateo de las celdas asi por ejemplo si el genero es
        // "CienciaFiccion" lo muestra como "Ciencia Ficcion" y si el tipo de contenido
        // es "TipoContenido" lo muestra como "Tipo Contenido"
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;

            if ((colName == "Genero" || colName == "TipoContenido") && e.Value != null)
            {
                e.Value = Regex.Replace(e.Value.ToString(), "(?<!^)([A-Z])", " $1");
                e.FormattingApplied = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colEliminar" && e.RowIndex >= 0)
            {
                var item = (ContenidoAudioVisual)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                if (MessageBox.Show($"¿Está seguro que desea eliminar {item.Nombre}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    contenidos.Remove(item);
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = contenidos;
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "colVerMas" && e.RowIndex >= 0)
            {
                var item = (ContenidoAudioVisual)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                string mensaje = $"Nombre: {item.Nombre}\nDirector: {item.Director}\nAño: {item.Anio}\nGénero: {item.Genero}\nTipo: {item.TipoContenido}\nDestacado: {(item.Destacado ? "✔" : "✖")}";
                if (item is Pelicula pelicula)
                {
                    mensaje += $"\nDuración: {pelicula.DuracionMinutos} minutos";
                }
                else if (item is Serie serie)
                {
                    mensaje += $"\nTemporadas: {serie.Temporadas}";
                }
                MessageBox.Show(mensaje, "Información del contenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}