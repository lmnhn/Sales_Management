﻿using BusinessObject.Models;
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
    public partial class frmOrdersUpdate : Form
    {
        public Order OrderPresenter { get; set; }
        public IOrderRepository orderRepository { get; set; }
        public IOrderDetailsRepository orderDetailsRepository { get; set; }
        public frmOrdersUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            orderRepository = new OrderRepository();
            orderDetailsRepository = new OrderDetailsRepository();
            Order order = new Order()
            {
                OrderId = OrderPresenter.OrderId,
                OrderDate = OrderPresenter.OrderDate,
                MemberId = OrderPresenter.MemberId,
                RequiredDate = Convert.ToDateTime(dtPRequiredDate.Text),
                ShippedDate = Convert.ToDateTime(dtPShippedDate.Text),
                Freight = Convert.ToInt32(txtFreight.Text),
            };

            orderRepository.UpdateOrder(order);
            MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmOrdersUpdate_Load(object sender, EventArgs e)
        {
            dtPRequiredDate.Text = OrderPresenter.RequiredDate.ToString();
            dtPShippedDate.Text = OrderPresenter.ShippedDate.ToString();
            txtFreight.Text = OrderPresenter.Freight.ToString();
        }
    }
}
