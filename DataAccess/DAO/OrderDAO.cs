using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDAO
    {
        public static OrderDAO instance = null;
        public static object instanceLock = new object();
        
        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }

        public IEnumerable<Order> GetAllOrders()
        {
            IEnumerable<Order> orders = new List<Order>();
            try
            {
                var context = new MyStore();
                orders = context.Orders;

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public IEnumerable<Order> GetAllOrdersByMemberId(int memberId)
        {
            IEnumerable<Order> orders = new List<Order>();
            try
            {
                var context = new MyStore();
                orders = context.Orders.Where(o => o.MemberId.Equals(memberId));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public void AddOrder(Order order)
        {
            try
            {
                var context = new MyStore();
                context.Orders.Add(order);
                context.SaveChanges();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Order findById(int id)
        {
            Order order = null;
            try
            {
                var context = new MyStore();
                order = context.Orders.FirstOrDefault(o => o.OrderId.Equals(id));
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }

        public void RemoveOrder(Order order) { 
            try
            {
                var context = new MyStore();
                
                OrderDetail orderDetails = OrderDetailDAO.Instance.findByOrderId(order.OrderId);
              
                if(orderDetails != null)
                {
                    context.OrderDetails.Remove(orderDetails);
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateOrder(Order order)
        {
            try
            {
                var context = new MyStore();
                    context.Orders.Update(order);
                    context.SaveChanges();
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
