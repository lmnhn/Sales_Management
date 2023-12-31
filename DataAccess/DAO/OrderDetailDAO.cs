﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDetailDAO
    {
        public static OrderDetailDAO instance = null;
        public static object instanceLock = new object();
        public static OrderDetailDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new OrderDetailDAO();
                }
                return instance;
            }
        }

        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            IEnumerable<OrderDetail> orderDetails = new List<OrderDetail>();
            try
            {
                var context = new MyStore();
                orderDetails = context.OrderDetails;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetails;
        }

        public void Create(OrderDetail orderDetail)
        {
            try
            {
                var context = new MyStore();
                context.OrderDetails.Add(orderDetail);
                context.SaveChanges();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(OrderDetail orderDetail)
        {
            try
            {
                var context = new MyStore();
                context.OrderDetails.Remove(orderDetail);
                context.SaveChanges();
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(OrderDetail orderDetail)
        {
            try
            {
                var context = new MyStore();
                context.OrderDetails.Update(orderDetail);
                context.SaveChanges();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<OrderDetail> findByProductId(int productId)
        {
            IEnumerable<OrderDetail> orderDetails = new List<OrderDetail>();
            try
            {
                var context = new MyStore();
                orderDetails = context.OrderDetails.Where(od => od.ProductId.Equals(productId));
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetails;
        }

        public OrderDetail findByOrderId(int orderId)
        {
            OrderDetail orderDetails = null;
            try
            {
                var context = new MyStore();
                orderDetails = context.OrderDetails.FirstOrDefault(od => od.OrderId.Equals(orderId));
            } catch(Exception ex)
            {
                throw new Exception(ex.Message );
            }
            return orderDetails;
        }
    }
}
