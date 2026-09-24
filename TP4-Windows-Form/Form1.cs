using System.Collections.Generic; // <- Nos permite utilizar Listas, Diccionarios
namespace TP4_Windows_Form
{
    public partial class Form1 : Form
    {
        public List<Pelicula> peliculas;
        public Form1()
        {
            // LINQ - Sirve para hacer consultas de tablas
            // Languaje integrate query
            // Workbench - utilizada para sql
            // SQL (Structured Query Language)

            // Linq utiliza SQL Syntax y method Syntax de c#
            InitializeComponent();
            peliculas = CargarDatos();
            dataGridView1.DataSource = peliculas; // <- DataSource es la fuente de los datos. Sirve para modificar los datos
            // Datagridview
            // Agregar: SelectMode: FullRowSelect | AutoSizeRows: Fill
            // poner en false: allowUserAddRows - AllowUserDeleteRows - AllowUserOrderRows
        }

        public List<Pelicula> CargarDatos()
        {
            peliculas = new List<Pelicula>
            {
                new Pelicula(1, "El Padrino", "Francis Ford Coppola", 1972, "Crimen"),
                new Pelicula(2, "El Caballero Oscuro", "Christopher Nolan", 2008, "Acción"),
                new Pelicula(3, "Pulp Fiction", "Quentin Tarantino", 1994, "Crimen"),
                new Pelicula(4, "Forrest Gump", "Robert Zemeckis", 1994, "Drama"),
                new Pelicula(5, "Inception", "Christopher Nolan", 2010, "Ciencia ficción"),
                new Pelicula(6, "La La Land", "Damien Chazelle", 2016, "Musical"),
                new Pelicula(7, "Gladiador", "Ridley Scott", 2000, "Acción"),
                new Pelicula(8, "Titanic", "James Cameron", 1997, "Romance"),
                new Pelicula(9, "Matrix", "Lana y Lilly Wachowski", 1999, "Ciencia ficción"),
                new Pelicula(10, "El Señor de los Anillos: La Comunidad del Anillo", "Peter Jackson", 2001, "Fantasía")
            };


            return peliculas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        // FILTROS
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text.Trim().ToLower(); // <- Convertimos a minusculas para que no sea case sensitive
            var resultado = peliculas
                .Where(p => p.Nombre.ToLower().Contains(filtro) || p.Director.ToLower().Contains(filtro) || p.Genero.ToLower().Contains(filtro))
                .OrderBy(p => p.Anio)
                .ToList();
            dataGridView1.DataSource = resultado;
        }


        private void btnFiltroCrimen_Click(object sender, EventArgs e)
        {
            var resultado = peliculas
                 .Where(p => p.Genero.ToLower() == "crimen")
                 .OrderBy(p => p.Anio)
                 .ToList();
            dataGridView1.DataSource = resultado;
        }

        private void btnAccionFiltro_Click(object sender, EventArgs e)
        {
            var resultado = peliculas
                .Where(p => p.Genero.ToLower() == "acción" || p.Genero.ToLower() == "accion")
                .OrderBy(p => p.Anio)
                .ToList();
            dataGridView1.DataSource = resultado;
        }

        private void btnFiltroRomance_Click(object sender, EventArgs e)
        {
            var resultado = peliculas
     .Where(p => p.Genero.ToLower() == "romance")
     .OrderBy(p => p.Anio)
     .ToList();
            dataGridView1.DataSource = resultado;
        }

        private void btnDramaFiltro_Click(object sender, EventArgs e)
        {
            var resultado = peliculas
    .Where(p => p.Genero.ToLower() == "drama")
    .OrderBy(p => p.Anio)
    .ToList();
            dataGridView1.DataSource = resultado;
        }

        // =========================================0

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text;
            string director = txtDirector.Text;
            string genero = txtGenero.Text;
            int anio = int.Parse(txtAnio.Text);
            int id = peliculas.Count + 1;

            var nuevaPelicula = new Pelicula(id, nombre, director, anio, genero);
            peliculas.Add(nuevaPelicula);

            dataGridView1.DataSource = null; // <- Para que se refresque el datagridview
            dataGridView1.DataSource = peliculas;

            LimpiarFormulario();
        }

        public void LimpiarFormulario()
        {
            txtName.Clear();
            txtDirector.Clear();
            txtAnio.Clear();
            txtGenero.Clear();
        }

        public class Pelicula
        {
            public int Id { get; set; }
            public string Nombre { get; set; } = string.Empty; // La propiedad se inicilaliza vacia y no da error de nulos
            public string Director { get; set; } = string.Empty;
            public int Anio { get; set; }
            public string Genero { get; set; } = string.Empty;

            public Pelicula(int id, string nombre, string director, int anio, string genero)
            {
                Id = id;
                Nombre = nombre;
                Director = director;
                Anio = anio;
                Genero = genero;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}