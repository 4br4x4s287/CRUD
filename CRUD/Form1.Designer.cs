namespace CRUD
{
    partial class CrudCervezas
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
            dgvcervezas = new DataGridView();
            groupBox1 = new GroupBox();
            btneliminar = new Button();
            btneditar = new Button();
            btnagregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvcervezas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvcervezas
            // 
            dgvcervezas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcervezas.Location = new Point(12, 12);
            dgvcervezas.Name = "dgvcervezas";
            dgvcervezas.RowHeadersWidth = 62;
            dgvcervezas.Size = new Size(369, 322);
            dgvcervezas.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btneliminar);
            groupBox1.Controls.Add(btneditar);
            groupBox1.Controls.Add(btnagregar);
            groupBox1.Location = new Point(387, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 209);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "acciones";
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(3, 138);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(112, 34);
            btneliminar.TabIndex = 2;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(2, 81);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(112, 34);
            btneditar.TabIndex = 1;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(3, 27);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(112, 34);
            btnagregar.TabIndex = 0;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // CrudCervezas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvcervezas);
            Name = "CrudCervezas";
            Text = "crudCervezas";
            Load += CrudCervezas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvcervezas).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvcervezas;
        private GroupBox groupBox1;
        private Button btneliminar;
        private Button btneditar;
        private Button btnagregar;
    }
}
