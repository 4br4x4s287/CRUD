namespace CRUD
{
    partial class CervezaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtEstilo = new TextBox();
            txtAlcohol = new TextBox();
            btncancelar = new Button();
            btnguardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 64);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 133);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Estilo";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 198);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 2;
            label3.Text = "Alcohol";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(287, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtEstilo
            // 
            txtEstilo.Location = new Point(287, 133);
            txtEstilo.Name = "txtEstilo";
            txtEstilo.Size = new Size(150, 31);
            txtEstilo.TabIndex = 4;
            // 
            // txtAlcohol
            // 
            txtAlcohol.Location = new Point(287, 198);
            txtAlcohol.Name = "txtAlcohol";
            txtAlcohol.Size = new Size(150, 31);
            txtAlcohol.TabIndex = 5;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(114, 318);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(112, 34);
            btncancelar.TabIndex = 6;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(325, 318);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(112, 34);
            btnguardar.TabIndex = 7;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // CervezaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnguardar);
            Controls.Add(btncancelar);
            Controls.Add(txtAlcohol);
            Controls.Add(txtEstilo);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CervezaForm";
            Text = "CervezaForm";
            Load += CervezaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtEstilo;
        private TextBox txtAlcohol;
        private Button btncancelar;
        private Button btnguardar;
    }
}