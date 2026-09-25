namespace TP4_Windows_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEnviar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridView1 = new DataGridView();
            txtFiltro = new TextBox();
            label3 = new Label();
            txtDirector = new TextBox();
            label2 = new Label();
            btnFiltroRomance = new Button();
            txtName = new TextBox();
            btnAccionFiltro = new Button();
            label1 = new Label();
            label5 = new Label();
            btnFiltroCrimen = new Button();
            btnFiltrar = new Button();
            txtAnio = new TextBox();
            label6 = new Label();
            label4 = new Label();
            btnDramaFiltro = new Button();
            panel1 = new Panel();
            chkDestacado = new CheckBox();
            rbPelicula = new RadioButton();
            rbSerie = new RadioButton();
            btnBorrarFiltro = new Button();
            btnMostrarMas = new Button();
            panelMas = new Panel();
            btnLimpiar = new Button();
            cmbGenero = new ComboBox();
            txtTemporadas = new TextBox();
            txtDuracion = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panelCheckPelicula = new Panel();
            panelCheckSerie = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panelMas.SuspendLayout();
            panelCheckPelicula.SuspendLayout();
            panelCheckSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(221, 331);
            btnEnviar.Margin = new Padding(3, 2, 3, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(131, 39);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.SandyBrown;
            dataGridView1.Location = new Point(69, 396);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(676, 185);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(684, 331);
            txtFiltro.Margin = new Padding(3, 2, 3, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.PlaceholderText = "Buscar...";
            txtFiltro.Size = new Size(181, 23);
            txtFiltro.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 134);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(218, 207);
            txtDirector.Margin = new Padding(3, 2, 3, 2);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(176, 23);
            txtDirector.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 65);
            label2.Name = "label2";
            label2.Size = new Size(322, 23);
            label2.TabIndex = 2;
            label2.Text = "Sube tus Peliculas al Cátalogo";
            label2.Click += label2_Click;
            // 
            // btnFiltroRomance
            // 
            btnFiltroRomance.Location = new Point(2, 124);
            btnFiltroRomance.Margin = new Padding(3, 2, 3, 2);
            btnFiltroRomance.Name = "btnFiltroRomance";
            btnFiltroRomance.Size = new Size(94, 33);
            btnFiltroRomance.TabIndex = 17;
            btnFiltroRomance.Text = "Romance";
            btnFiltroRomance.UseVisualStyleBackColor = true;
            btnFiltroRomance.Click += btnFiltroRomance_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(218, 151);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(177, 23);
            txtName.TabIndex = 3;
            // 
            // btnAccionFiltro
            // 
            btnAccionFiltro.Location = new Point(2, 13);
            btnAccionFiltro.Margin = new Padding(3, 2, 3, 2);
            btnAccionFiltro.Name = "btnAccionFiltro";
            btnAccionFiltro.Size = new Size(94, 33);
            btnAccionFiltro.TabIndex = 15;
            btnAccionFiltro.Text = "Acción";
            btnAccionFiltro.UseVisualStyleBackColor = true;
            btnAccionFiltro.Click += btnAccionFiltro_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(372, 39);
            label1.TabIndex = 0;
            label1.Text = "Cátalogo De Peliculas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 135);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 10;
            label5.Text = "Genero";
            // 
            // btnFiltroCrimen
            // 
            btnFiltroCrimen.Location = new Point(2, 87);
            btnFiltroCrimen.Margin = new Padding(3, 2, 3, 2);
            btnFiltroCrimen.Name = "btnFiltroCrimen";
            btnFiltroCrimen.Size = new Size(94, 33);
            btnFiltroCrimen.TabIndex = 14;
            btnFiltroCrimen.Text = "Crimen";
            btnFiltroCrimen.UseVisualStyleBackColor = true;
            btnFiltroCrimen.Click += btnFiltroCrimen_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(574, 331);
            btnFiltrar.Margin = new Padding(3, 2, 3, 2);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(104, 25);
            btnFiltrar.TabIndex = 12;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(412, 207);
            txtAnio.Margin = new Padding(3, 2, 3, 2);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(177, 23);
            txtAnio.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 190);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 8;
            label6.Text = "Año";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 190);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Director";
            // 
            // btnDramaFiltro
            // 
            btnDramaFiltro.Location = new Point(2, 50);
            btnDramaFiltro.Margin = new Padding(3, 2, 3, 2);
            btnDramaFiltro.Name = "btnDramaFiltro";
            btnDramaFiltro.Size = new Size(94, 33);
            btnDramaFiltro.TabIndex = 16;
            btnDramaFiltro.Text = "Drama";
            btnDramaFiltro.UseVisualStyleBackColor = true;
            btnDramaFiltro.Click += btnDramaFiltro_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 116);
            panel1.TabIndex = 18;
            // 
            // chkDestacado
            // 
            chkDestacado.AutoSize = true;
            chkDestacado.Location = new Point(412, 247);
            chkDestacado.Name = "chkDestacado";
            chkDestacado.Size = new Size(81, 19);
            chkDestacado.TabIndex = 19;
            chkDestacado.Text = "Destacado";
            chkDestacado.UseVisualStyleBackColor = true;
            // 
            // rbPelicula
            // 
            rbPelicula.AutoSize = true;
            rbPelicula.Location = new Point(218, 246);
            rbPelicula.Name = "rbPelicula";
            rbPelicula.Size = new Size(66, 19);
            rbPelicula.TabIndex = 20;
            rbPelicula.TabStop = true;
            rbPelicula.Text = "Pelicula";
            rbPelicula.UseVisualStyleBackColor = true;
            rbPelicula.CheckedChanged += rbPelicula_CheckedChanged;
            // 
            // rbSerie
            // 
            rbSerie.AutoSize = true;
            rbSerie.Location = new Point(290, 247);
            rbSerie.Name = "rbSerie";
            rbSerie.Size = new Size(50, 19);
            rbSerie.TabIndex = 21;
            rbSerie.TabStop = true;
            rbSerie.Text = "Serie";
            rbSerie.UseVisualStyleBackColor = true;
            rbSerie.CheckedChanged += rbSerie_CheckedChanged;
            // 
            // btnBorrarFiltro
            // 
            btnBorrarFiltro.Location = new Point(574, 360);
            btnBorrarFiltro.Margin = new Padding(3, 2, 3, 2);
            btnBorrarFiltro.Name = "btnBorrarFiltro";
            btnBorrarFiltro.Size = new Size(171, 29);
            btnBorrarFiltro.TabIndex = 22;
            btnBorrarFiltro.Text = "Borrar Filtros";
            btnBorrarFiltro.UseVisualStyleBackColor = true;
            btnBorrarFiltro.Click += btnBorrarFiltro_Click;
            // 
            // btnMostrarMas
            // 
            btnMostrarMas.Location = new Point(766, 360);
            btnMostrarMas.Margin = new Padding(3, 2, 3, 2);
            btnMostrarMas.Name = "btnMostrarMas";
            btnMostrarMas.Size = new Size(99, 29);
            btnMostrarMas.TabIndex = 23;
            btnMostrarMas.Text = "Más...";
            btnMostrarMas.UseVisualStyleBackColor = true;
            btnMostrarMas.Click += btnMostrarMas_Click;
            // 
            // panelMas
            // 
            panelMas.Controls.Add(btnFiltroRomance);
            panelMas.Controls.Add(btnAccionFiltro);
            panelMas.Controls.Add(btnDramaFiltro);
            panelMas.Controls.Add(btnFiltroCrimen);
            panelMas.Location = new Point(766, 394);
            panelMas.Name = "panelMas";
            panelMas.Size = new Size(99, 165);
            panelMas.TabIndex = 24;
            panelMas.Visible = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(358, 341);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(87, 29);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(412, 151);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(177, 23);
            cmbGenero.TabIndex = 26;
            // 
            // txtTemporadas
            // 
            txtTemporadas.Location = new Point(3, 25);
            txtTemporadas.Name = "txtTemporadas";
            txtTemporadas.Size = new Size(177, 23);
            txtTemporadas.TabIndex = 27;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(3, 27);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(177, 23);
            txtDuracion.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 7);
            label7.Name = "label7";
            label7.Size = new Size(139, 15);
            label7.TabIndex = 29;
            label7.Text = "Cantidad De Temporadas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 9);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 30;
            label8.Text = "Duracion";
            // 
            // panelCheckPelicula
            // 
            panelCheckPelicula.Controls.Add(label8);
            panelCheckPelicula.Controls.Add(txtDuracion);
            panelCheckPelicula.Location = new Point(218, 271);
            panelCheckPelicula.Name = "panelCheckPelicula";
            panelCheckPelicula.Size = new Size(203, 53);
            panelCheckPelicula.TabIndex = 31;
            panelCheckPelicula.Visible = false;
            // 
            // panelCheckSerie
            // 
            panelCheckSerie.Controls.Add(txtTemporadas);
            panelCheckSerie.Controls.Add(label7);
            panelCheckSerie.Location = new Point(218, 271);
            panelCheckSerie.Name = "panelCheckSerie";
            panelCheckSerie.Size = new Size(203, 53);
            panelCheckSerie.TabIndex = 32;
            panelCheckSerie.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(701, -29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(889, 602);
            Controls.Add(panelCheckSerie);
            Controls.Add(panelCheckPelicula);
            Controls.Add(cmbGenero);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEnviar);
            Controls.Add(panelMas);
            Controls.Add(btnMostrarMas);
            Controls.Add(btnBorrarFiltro);
            Controls.Add(rbSerie);
            Controls.Add(rbPelicula);
            Controls.Add(chkDestacado);
            Controls.Add(panel1);
            Controls.Add(btnFiltrar);
            Controls.Add(txtFiltro);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(txtAnio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDirector);
            Controls.Add(txtName);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(905, 641);
            MinimumSize = new Size(905, 641);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMas.ResumeLayout(false);
            panelCheckPelicula.ResumeLayout(false);
            panelCheckPelicula.PerformLayout();
            panelCheckSerie.ResumeLayout(false);
            panelCheckSerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEnviar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
        private TextBox txtFiltro;
        private Label label3;
        private TextBox txtDirector;
        private Label label2;
        private Button btnDramaFiltro;
        private Label label4;
        private Label label6;
        private TextBox txtAnio;
        private Button btnFiltrar;
        private Button btnFiltroCrimen;
        private Label label5;
        private Label label1;
        private Button btnAccionFiltro;
        private TextBox txtName;
        private Button btnFiltroRomance;
        private Panel panel1;
        private CheckBox chkDestacado;
        private RadioButton rbPelicula;
        private RadioButton rbSerie;
        private Button btnBorrarFiltro;
        private Button btnMostrarMas;
        private Panel panelMas;
        private Button btnLimpiar;
        private ComboBox cmbGenero;
        private TextBox txtTemporadas;
        private TextBox txtDuracion;
        private Label label7;
        private Label label8;
        private Panel panelCheckPelicula;
        private Panel panelCheckSerie;
        private PictureBox pictureBox1;
    }
}
