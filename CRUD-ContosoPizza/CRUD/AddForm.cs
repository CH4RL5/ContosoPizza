using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContosoPizza.Date;
using ContosoPizza.Models;

namespace CRUD_ContosoPizza.CRUD
{
    public partial class AddForm : Form
    {
        public int? id;
        Product product = null;
        public AddForm(int? id=null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                chargeData();
        }
        private void chargeData() {
            using (ContosoPizzaContext db = new ContosoPizzaContext())
            {
                product = db.Products.Find(id);
                txtName.Text = product.Name;
                txtPrice.Text = product.Price.ToString();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (ContosoPizzaContext db = new ContosoPizzaContext())
            {
                if (id == null) 
                     product = new Product();

                product.Name = txtName.Text;
                product.Price = Convert.ToDecimal(txtPrice.Text);
                if (id == null)
                    db.Products.Add(product);
                else
                {
                    //db.Entry(product).State = System.Data.Entity.EntityState;
                }
                db.SaveChanges();
                this.Close();
            }

        }
    }
}
