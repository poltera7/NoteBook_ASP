using NoteBook.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteBook.Domain.Entity;

namespace NoteBook.Domain.Concrete
{
    public class EFRepository : IRepository
    {
        private EFDbContext db = new EFDbContext();

        //private NoteBookEntities db = new NoteBookEntities();

        public IQueryable<State> States { get { return db.States; } }
        public IQueryable<AnOrder> Orders { get { return db.AnOrders; } }

        public AnOrder SaveOrder(AnOrder _order)
        {
            AnOrder result = null;
            try
            {
                AnOrder dbEntry = db.AnOrders.Find(_order.id);
                //Если запись о проекте существует - обновляем ее данные
                if (dbEntry != null)
                {
                    dbEntry.customer_name = _order.customer_name;
                    dbEntry.description = _order.description;
                }
                //Если нет - создаем запись
                else
                {
                    db.AnOrders.Add(_order);
                }
                db.SaveChanges();
                result = db.AnOrders.Find(_order.id);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        public void DelOrder(int _orderId)
        {
            try
            {
                AnOrder anOrder = db.AnOrders.Find(_orderId);
                db.AnOrders.Remove(anOrder);
                db.SaveChanges();
            }

            catch (Exception ex)
            {

            }
        }
    }
}

