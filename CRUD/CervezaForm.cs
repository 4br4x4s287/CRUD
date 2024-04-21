using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class CervezaForm : Form
    {
        public Cerveza Cerveza { get; set; }
        public CervezaForm()
        {
            InitializeComponent();
            this.Cerveza = new Cerveza();
        }
        public CervezaForm(Cerveza Cerveza) : this()
        {
            this.Cerveza = Cerveza;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CervezaForm_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = this.Cerveza.Nombre;
            this.txtEstilo.Text = this.Cerveza.Estilo;
            this.txtAlcohol.Text = this.Cerveza.Alcohol.ToString();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            this.Cerveza.Nombre = this.txtNombre.Text;
            this.Cerveza.Estilo = this.txtEstilo.Text;
            this.Cerveza.Alcohol = double.Parse(this.txtAlcohol.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
