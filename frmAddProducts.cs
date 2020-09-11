using ShoppingCart.Models;
using System;
using System.Windows.Forms;
namespace ShoppingCart
{
    public partial class frmAddProducts : Form
    {
        
        public Products newPrd = new Products();
        public frmAddProducts()
        {
            InitializeComponent();
        }

        private void frmAddProducts_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            erpWarning.Clear();
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                erpWarning.SetError(txtProductName, "Bu Alan Boş Bırakılamaz!");
                return;
            }
            if (string.IsNullOrEmpty(txtProductUnitPrice.Text))
            {
                erpWarning.SetError(txtProductUnitPrice, "Bu Alan Boş Bırakılamaz!");
                return;
            }
            var frmNewAdd = new frmMainScreen();
            newPrd = new Products
            {
                productName = txtProductName.Text,
                productPrice = Convert.ToDouble(txtProductUnitPrice.Text),
                AmountInCart = 0
            };
            this.Close();

        }

        private void txtProductUnitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddNewProduct_Click(null, null);

            }
        }
    }
}
