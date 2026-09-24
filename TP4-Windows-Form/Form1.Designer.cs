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
            label1 = new Label();
            btnEnviar = new Button();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtDirector = new TextBox();
            label5 = new Label();
            txtGenero = new TextBox();
            label6 = new Label();
            txtAnio = new TextBox();
            dataGridView1 = new DataGridView();
            btnFiltrar = new Button();
            txtFiltro = new TextBox();
            btnFiltroCrimen = new Button();
            btnAccionFiltro = new Button();
            btnFiltroRomance = new Button();
            btnDramaFiltro = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 3);
            label1.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(352, 16);
            label1.Name = "label1";
            label1.Size = new Size(437, 54);
            label1.TabIndex = 0;
            label1.Text = "Cátalogo De Peliculas";
            label1.Click += label1_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(763, 319);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(136, 47);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 3);
            label2.Location = new Point(468, 107);
            label2.Name = "label2";
            label2.Size = new Size(206, 20);
            label2.TabIndex = 2;
            label2.Text = "Sube tus Peliculas al Cátalogo";
            label2.Click += label2_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(763, 573);
            txtName.Name = "txtName";
            txtName.Size = new Size(202, 27);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 140);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(763, 590);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 6;
            label4.Text = "Director";
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(3, 143);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(202, 27);
            txtDirector.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 550);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 10;
            label5.Text = "Genero";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(383, 319);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(202, 27);
            txtGenero.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 590);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 8;
            label6.Text = "Año";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(383, 553);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(202, 27);
            txtAnio.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(763, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(321, 170);
            dataGridView1.TabIndex = 11;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(383, 573);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(132, 14);
            btnFiltrar.TabIndex = 12;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(383, 613);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(239, 27);
            txtFiltro.TabIndex = 13;
            // 
            // btnFiltroCrimen
            // 
            btnFiltroCrimen.Location = new Point(3, 573);
            btnFiltroCrimen.Name = "btnFiltroCrimen";
            btnFiltroCrimen.Size = new Size(94, 14);
            btnFiltroCrimen.TabIndex = 14;
            btnFiltroCrimen.Text = "Crimen";
            btnFiltroCrimen.UseVisualStyleBackColor = true;
            btnFiltroCrimen.Click += btnFiltroCrimen_Click;
            // 
            // btnAccionFiltro
            // 
            btnAccionFiltro.Location = new Point(383, 593);
            btnAccionFiltro.Name = "btnAccionFiltro";
            btnAccionFiltro.Size = new Size(94, 14);
            btnAccionFiltro.TabIndex = 15;
            btnAccionFiltro.Text = "Acción";
            btnAccionFiltro.UseVisualStyleBackColor = true;
            btnAccionFiltro.Click += btnAccionFiltro_Click;
            // 
            // btnFiltroRomance
            // 
            btnFiltroRomance.Location = new Point(3, 319);
            btnFiltroRomance.Name = "btnFiltroRomance";
            btnFiltroRomance.Size = new Size(94, 29);
            btnFiltroRomance.TabIndex = 17;
            btnFiltroRomance.Text = "Romance";
            btnFiltroRomance.UseVisualStyleBackColor = true;
            btnFiltroRomance.Click += btnFiltroRomance_Click;
            // 
            // btnDramaFiltro
            // 
            btnDramaFiltro.Location = new Point(763, 553);
            btnDramaFiltro.Name = "btnDramaFiltro";
            btnDramaFiltro.Size = new Size(94, 14);
            btnDramaFiltro.TabIndex = 16;
            btnDramaFiltro.Text = "Drama";
            btnDramaFiltro.UseVisualStyleBackColor = true;
            btnDramaFiltro.Click += btnDramaFiltro_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 3);
            tableLayoutPanel1.Controls.Add(txtDirector, 1, 2);
            tableLayoutPanel1.Controls.Add(btnDramaFiltro, 2, 4);
            tableLayoutPanel1.Controls.Add(label4, 2, 7);
            tableLayoutPanel1.Controls.Add(label6, 1, 6);
            tableLayoutPanel1.Controls.Add(txtAnio, 2, 4);
            tableLayoutPanel1.Controls.Add(txtFiltro, 1, 8);
            tableLayoutPanel1.Controls.Add(btnFiltrar, 0, 5);
            tableLayoutPanel1.Controls.Add(btnFiltroCrimen, 2, 4);
            tableLayoutPanel1.Controls.Add(label5, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAccionFiltro, 1, 7);
            tableLayoutPanel1.Controls.Add(txtName, 0, 6);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(btnEnviar, 0, 3);
            tableLayoutPanel1.Controls.Add(txtGenero, 0, 3);
            tableLayoutPanel1.Controls.Add(btnFiltroRomance, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.272728F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.72727F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 176F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 234F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1142, 651);
            tableLayoutPanel1.TabIndex = 18;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 651);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1160, 698);
            MinimumSize = new Size(1160, 698);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnEnviar;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private TextBox txtDirector;
        private Label label5;
        private TextBox txtGenero;
        private Label label6;
        private TextBox txtAnio;
        private DataGridView dataGridView1;
        private Button btnFiltrar;
        private TextBox txtFiltro;
        private Button btnFiltroCrimen;
        private Button btnAccionFiltro;
        private Button btnFiltroRomance;
        private Button btnDramaFiltro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
