namespace CRUD
{
    public partial class CrudCervezas : Form
    {
        public List<Cerveza> Cervezas { get; set; }
        public CrudCervezas()
        {
            InitializeComponent();
            this.Cervezas = new List<Cerveza>();
        }

        private void CrudCervezas_Load(object sender, EventArgs e)
        {
            this.dgvcervezas.DataSource = Cervezas;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            CervezaForm cervezaForm = new CervezaForm();
            if (cervezaForm.ShowDialog() == DialogResult.OK)
            {
                this.Cervezas.Add(cervezaForm.Cerveza);
                this.dgvcervezas.DataSource = this.Cervezas.ToList();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Cerveza? seleccionada = (Cerveza)this.dgvcervezas.CurrentRow.DataBoundItem;
            CervezaForm cervezaForm = new CervezaForm();
            if (cervezaForm.ShowDialog() == DialogResult.OK)
            {
                Cerveza? editar = this.Cervezas.FirstOrDefault(c => c == seleccionada);
                editar = cervezaForm.Cerveza;
                this.dgvcervezas.DataSource = this.Cervezas.ToList();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Cerveza? seleccionada = (Cerveza)this.dgvcervezas.CurrentRow.DataBoundItem;
            this.Cervezas.Remove(seleccionada);
            this.dgvcervezas.DataSource=this.Cervezas.ToList();
        }
    }
}
