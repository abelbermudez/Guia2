namespace Clase_practica
{
    partial class FormVentas
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
            dgvVentas = new DataGridView();
            btnCargar = new Button();
            btnprocesar = new Button();
            btnlimpiar = new Button();
            txtresultado = new RichTextBox();
            lblestado = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(139, 79);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(382, 359);
            dgvVentas.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(28, 40);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar Ventas";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnprocesar
            // 
            btnprocesar.Location = new Point(28, 111);
            btnprocesar.Name = "btnprocesar";
            btnprocesar.Size = new Size(94, 29);
            btnprocesar.TabIndex = 2;
            btnprocesar.Text = "Procesar";
            btnprocesar.UseVisualStyleBackColor = true;
            btnprocesar.Click += btnprocesar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(28, 179);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(94, 29);
            btnlimpiar.TabIndex = 3;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(719, 80);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(254, 358);
            txtresultado.TabIndex = 4;
            txtresultado.Text = "";
            // 
            // lblestado
            // 
            lblestado.AutoSize = true;
            lblestado.Location = new Point(297, 49);
            lblestado.Name = "lblestado";
            lblestado.Size = new Size(70, 20);
            lblestado.TabIndex = 5;
            lblestado.Text = "Sin datos";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(761, 444);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(125, 21);
            progressBar1.TabIndex = 6;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 506);
            Controls.Add(progressBar1);
            Controls.Add(lblestado);
            Controls.Add(txtresultado);
            Controls.Add(btnlimpiar);
            Controls.Add(btnprocesar);
            Controls.Add(btnCargar);
            Controls.Add(dgvVentas);
            Name = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private Button btnCargar;
        private Button btnprocesar;
        private Button btnlimpiar;
        private RichTextBox txtresultado;
        private Label lblestado;
        private ProgressBar progressBar1;
    }
}
