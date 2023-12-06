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
    public partial class frmOrderDetails : Form
    {
        public int orderId { get; set; }
        public IOrderDetailsRepository orderDetailsRepository { get; set; }
        public frmOrderDetails()
        {
            InitializeComponent();
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            orderDetailsRepository = new OrderDetailsRepository();
            OrderDetail orderDetail = orderDetailsRepository.findById(orderId);
            txtOrderId.Text = orderId.ToString();
            txtProductId.Text = orderDetail.ProductId.ToString();
            txtQuantity.Text = orderDetail.Quantity.ToString();
            txtUPrice.Text = orderDetail.UnitPrice.ToString();
            txtTotal.Text = (orderDetail.Quantity * orderDetail.UnitPrice).ToString();
        }
    }
}
