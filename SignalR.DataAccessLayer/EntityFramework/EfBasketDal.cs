using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repostories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(SignalRContext context) : base(context)
        {
        }

        public void ChangeMenuTableStatusToFalse(int menuTableId)
        {
            using var context = new SignalRContext();
            var table = context.MenuTables.FirstOrDefault(x => x.MenuTableID == menuTableId);
            if (table != null)
            {
                table.Status = false;
                context.SaveChanges();
            }
        }

        public void ChangeMenuTableStatusToTrue(int menuTableId)
        {
            using var context = new SignalRContext();
            var table = context.MenuTables.FirstOrDefault(x => x.MenuTableID == menuTableId);
            if (table != null)
            {
                table.Status = true;
                context.SaveChanges();
            }
        }

        public List<Basket> GetBasketByMenuTableNumber(int id)
        {
            using var context = new SignalRContext();
            var values = context.Baskets.Where(x => x.MenuTableID == id).Include(y => y.Product).ToList();
            return values;
        }
    }
}
