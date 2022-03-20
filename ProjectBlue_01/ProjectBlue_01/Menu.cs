using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using DevExpress.XtraEditors;

namespace CoffeeShopForms
{
    public partial class MenuGrv : Form
    {


        public CoffeeShop CurrentShop { get; set; }
        public BindingSource bsProduct { get; set; }
        public MenuGrv()
        {
            InitializeComponent();
            bsProduct = new BindingSource();
        }

        private void MenuGrv_Load(object sender, EventArgs e)
        {
            bsProduct.DataSource = CurrentShop.Products;
            grdProduct.DataSource = bsProduct;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            CurrentShop.Products.Add(product);
            bsProduct.ResetBindings(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentShop.SaveProduct();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
