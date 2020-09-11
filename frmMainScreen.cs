using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class frmMainScreen : Form
    {
        List<Products> products = new List<Products>();
        bool IsTheItemInproducts = false; // bu bayrağı ürünlerde olmayıpta sepette olan biri ürünü silmek için kulanıyoruz

        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            var Prd1 = new Products {productName = "Pilot Kalem", productPrice = 15.50};
            var Prd2 = new Products {productName = "Uçlu Kalem", productPrice = 7.50};
            var Prd3 = new Products {productName = "Kurşun Kalem", productPrice = 3};
            var Prd4 = new Products {productName = "Kırmızı Kurşun Kalem", productPrice = 4.50};

            products.AddRange(new Products[] { Prd1, Prd2, Prd3, Prd4 });
            lstProducts.DataSource = products;

            



        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItems.Count > 0)
            {
                
                //Sepete Ekleme İşlemi

                int prdAmount = Convert.ToInt32(txtDisplayAmount.Text); // faturalandırmada kullancağız
                foreach (var item in lstProducts.SelectedItems)
                {
                    foreach (var item2 in products)
                    {
                        if (item == item2)
                        {
                            item2.AmountInCart += prdAmount;
                        }
                    }
                    if (!(lstCart.Items.Contains(item)))
                    {
                        lstCart.Items.Add(item);
                        
                    }   
                }




                // Sepetteki Miktarı Belirtmek İçin

                RefreshTheAmountOfProductsInCartList();
                RefreshTheReceiptList();





                txtDisplayAmount.Text = "1"; // miktar sayacını tekrar bire getiriyorum
                lstProducts.SelectedIndex = -1; // bu seçili olma durumunu yok etmek içindi
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            int Amount = Convert.ToInt32(txtDisplayAmount.Text);
            if (Amount > 1)
            {
                Amount--;
                txtDisplayAmount.Text = Amount.ToString();
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            int Amount = Convert.ToInt32(txtDisplayAmount.Text);
            if (Amount < 100)
            {
                Amount++;
                txtDisplayAmount.Text = Amount.ToString();
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedItems.Count > 0)
            {
                Products[] selectedProducts = new Products[lstCart.SelectedItems.Count];
                lstCart.SelectedItems.CopyTo(selectedProducts, 0);
                foreach (var item in selectedProducts)
                {
                    foreach (var item2 in products)
                    {
                        if (item == item2)
                        {
                            if (item2.AmountInCart == 1)
                            {
                                lstCart.Items.Remove(item);
                            }
                            item2.AmountInCart--;
                            IsTheItemInproducts = true;
                        }
                    }
                    if (!IsTheItemInproducts)
                    {
                        lstCart.Items.Remove(item);
                        
                    }
                    
                }
                IsTheItemInproducts = false;
                RefreshTheAmountOfProductsInCartList();
                RefreshTheReceiptList();
            }
        }
        private void btnCLearAllCart_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Sepeti Temizlemek Üzeresiniz\nEmin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (var item in products)
                {
                    item.AmountInCart = 0;
                }
                lstCart.Items.Clear();
                RefreshTheAmountOfProductsInCartList();
                RefreshTheReceiptList();
            }
            
            
        }


        //Faturayı Yenilemek İçin Methodum
        private void RefreshTheReceiptList()
        {
            double AllTotalPrice = 0;

            txtSum.Clear();

            lstReceipt.Items.Clear();
            lstReceiptAmount.Items.Clear();
            lstReceiptUnitPrice.Items.Clear();
            Products[] productsInCart = new Products[lstCart.Items.Count];
            lstCart.Items.CopyTo(productsInCart, 0);
            foreach (var item in productsInCart)
            {
                lstReceipt.Items.Add(item.productName);
                lstReceiptAmount.Items.Add(item.AmountInCart);
                lstReceiptUnitPrice.Items.Add(item.productPrice);
                AllTotalPrice += item.CalculateTotalPrice();
            }
            txtSum.Text = $"{AllTotalPrice.ToString()} TL";
        }




        private void RefreshTheAmountOfProductsInCartList()
        {
            lstCartAmountOfProducts.Items.Clear();
            Products[] ItemsInCart = new Products[lstCart.Items.Count];
            lstCart.Items.CopyTo(ItemsInCart, 0);
            foreach (var item in ItemsInCart)
            {
                lstCartAmountOfProducts.Items.Add($"x {item.AmountInCart}");
            }
        }

        private void btnAddToProductsList_Click(object sender, EventArgs e)
        {
            
            var frmAddHelper = new frmAddProducts();
            frmAddHelper.ShowDialog();
            products.Add(frmAddHelper.newPrd);
            lstProducts.DataSource = null;
            lstProducts.DataSource = products;

        }

        private void btnRemoveFromProductList_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItems.Count > 0)
            {
                Products[] ItemsInProducts = new Products[lstProducts.Items.Count]; // ben burayı bir helperList adında liste ekleyip ve onu products'a eşitlediğimde yine liste değiştirildi hatası alıyorum halbuki products tan siliyorum ama anlık olarak helperListtende siliniyor ama CopyTo methodu ile bir dizizde tutarsam olay çözülüyor.
                products.CopyTo(ItemsInProducts, 0);
                
                foreach (var item in lstProducts.SelectedItems)
                {
                    foreach (var item2 in ItemsInProducts)
                    {
                        if (item == item2)
                        {
                            products.Remove(item2);
                        }
                    }
                }
                
                lstProducts.DataSource = null;
                lstProducts.DataSource = products;
            }
        }
    }
}
