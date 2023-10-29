using ContosoPizza.Date;
using ContosoPizza.Models;

namespace CRUD_ContosoPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }
        #region HELPER
        private void refresh()
        {
            using (ContosoPizzaContext db = new ContosoPizzaContext())
            {
                var lst = from d in db.Products
                          select d;
                dataGridView1.DataSource = lst.ToList();
            }

        }
        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD.AddForm addProduct = new CRUD.AddForm();
            addProduct.ShowDialog();

            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                CRUD.AddForm addProduct = new CRUD.AddForm(id);
                addProduct.ShowDialog();

                refresh();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using(ContosoPizzaContext db = new ContosoPizzaContext())
                {
                    Product product = db.Products.Find(id);
                    db.Products.Remove(product);
                    db.SaveChanges();

                } 
                refresh();

            }

        }
    }
}