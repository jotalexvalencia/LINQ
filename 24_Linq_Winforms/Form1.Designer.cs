namespace _24_Linq_Winforms
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
            txtXML = new TextBox();
            groupBox1 = new GroupBox();
            btnAdicionar = new Button();
            txtCurso = new TextBox();
            txtCalificacion = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            txtBCurso = new TextBox();
            label4 = new Label();
            btnCargar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtXML
            // 
            txtXML.BackColor = SystemColors.Window;
            txtXML.Location = new Point(23, 12);
            txtXML.Multiline = true;
            txtXML.Name = "txtXML";
            txtXML.ScrollBars = ScrollBars.Both;
            txtXML.Size = new Size(645, 217);
            txtXML.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtCurso);
            groupBox1.Controls.Add(txtCalificacion);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 242);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 146);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adición";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(92, 112);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(94, 41);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(100, 23);
            txtCurso.TabIndex = 5;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(94, 73);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(100, 23);
            txtCalificacion.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(94, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 81);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Calificación:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 49);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Curso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtBCurso);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(261, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 146);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Búsqueda";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(69, 45);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBCurso
            // 
            txtBCurso.Location = new Point(69, 16);
            txtBCurso.Name = "txtBCurso";
            txtBCurso.Size = new Size(100, 23);
            txtBCurso.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 24);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Curso:";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(478, 257);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 505);
            Controls.Add(btnCargar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtXML);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtXML;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtCurso;
        private TextBox txtCalificacion;
        private TextBox txtNombre;
        private TextBox txtBCurso;
        private Button btnAdicionar;
        private Button btnBuscar;
        private Button btnCargar;
    }
}