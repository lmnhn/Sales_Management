using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProduct : Form
    {
        IProductRepository productRepository = null;
        BindingSource bindingSource;
        bool InsertOrUpdate = true;
        IOrderDetailsRepository orderRepository = null;
        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void GetProductList(string search = "")
        {
           
            productRepository = new ProductRepository();
            IEnumerable<Product> products = productRepository.GetAllProducts().ToList().Where(s => s.ProductName.Contains(search.ToLower()));

            bindingSource = new BindingSource();

            bindingSource.DataSource = null;
            bindingSource.DataSource = products;

            dgvProductDetails.DataSource = null;
            dgvProductDetails.DataSource = bindingSource;

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
            btnUpdate.Enabled = true;
            GetProductList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            orderRepository = new OrderDetailsRepository();
            // Check if there is a selected row in the DataGridView
            if (dgvProductDetails.CurrentRow != null)
            {
                var product = productRepository.GetAllProducts().ToList()[dgvProductDetails.CurrentRow.Index];

                if (product != null)
                {
                    List<OrderDetail> orderDetail = orderRepository.findByProductID(product.ProductId).ToList();

                    if (orderDetail.Count >0)
                    {
                        MessageBox.Show("Cannot delete this product. It has been bought and has associated orders.", "Product Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to remove this product?", "Confirm Product Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            productRepository.Delete(product);
                            GetProductList();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Product not found", "Remove Product", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No product selected", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void btnCreate_Click(object sender, EventArgs e)
        {
            InsertOrUpdate = true;
            frmProductDetails frmProductDetails = new frmProductDetails()
            {
                Text = "Create product",
                _InsertOrUpdate = InsertOrUpdate,
                _productRepository = productRepository,
            };
            if (frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                GetProductList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var products = productRepository.GetAllProducts().ToList()[dgvProductDetails.CurrentRow.Index];
            InsertOrUpdate = false;
            if (products != null)
            {
                frmProductDetails frmProductDetails = new frmProductDetails()
                {
                    Text = "Update product",
                    ProductDetail = products,
                    _InsertOrUpdate = InsertOrUpdate,
                    _productRepository = productRepository
                };
            //    frmProductDetails.Show();
                if (frmProductDetails.ShowDialog() == DialogResult.OK)
                {
                    GetProductList();
                }
            }
            else
            {
                MessageBox.Show("Not found product", "Update product", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetProductList(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
