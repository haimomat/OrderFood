using OnlineFood.Core.Domain;
using System;
using System.Collections.Generic;

namespace OrderFood
{
    public class SessionData
    {
        public static Employee empCurrent { get; set; }

        public static void SetEmpCurrent(Employee _empCurrent)
        {
            empCurrent = _empCurrent;
        }

        public static List<FoodOrder> lstChoosed { get; set; }
        public static void SetListOrder(List<FoodOrder> _lstChoosed)
        {
            lstChoosed = _lstChoosed;
        }
        public static List<TransactionLunch> lstTransaction { get; set; }
        public static void SetListTransaction(List<TransactionLunch> _lstTransaction)
        {
            lstTransaction = _lstTransaction;
        }
        public static List<OrderDetail> lstOrderDetail { get; set; }
        public static void SetListOrderDetail(List<OrderDetail> _lstOrderDetail)
        {
            lstOrderDetail = _lstOrderDetail;
        }
        public static List<TransactionLunch> lstTransactionLunch { get; set; }
        public static List<Transaction_detail> lstTransactionDetail { get; set; }
        public static void SetListTransactionLunch(List<TransactionLunch> _lstTransactionLunch)
        {
            lstTransactionLunch = _lstTransactionLunch;
        }

        public static void SetListTransactionDetail(List<Transaction_detail> _lstTransactionDetail)
        {
            lstTransactionDetail = _lstTransactionDetail;
        }

        public static int restaurant_id { get; set; }
        public static void SetRestaurantId(int _restaurant_id)
        {
            restaurant_id = _restaurant_id;
        }

        public static Restaurant restaurant { get; set; }
        public static void SetRestaurant(Restaurant _restaurant)
        {
            restaurant = _restaurant;
        }
        public static string money { get; set; }
        public static void SetMoney(string _money)
        {
            money = _money;
        }

    }
}
