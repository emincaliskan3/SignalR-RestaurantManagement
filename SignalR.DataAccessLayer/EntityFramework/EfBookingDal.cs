using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repostories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(SignalRContext context) : base(context)
        {
        }

        public void BookingStatusApproved(int id)
        {
            using var context = new SignalRContext();
            var values = context.Bookings.Find(id);
            values.Status = "Rezervasyon Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusCancelled(int id)
        {
            using var context = new SignalRContext();
            var values = context.Bookings.Find(id);
            values.Status = "Rezervasyon İptal Edildi";
            context.SaveChanges();
        }
        public void BookingStatusPending(int id)
        {
            using var context = new SignalRContext();
            var values = context.Bookings.Find(id);
            values.Status = "Rezervasyon Bekletiliyor";
            context.SaveChanges();
        }

        public List<Booking> GetBookingsByStatusApproved()
        {
            using var context = new SignalRContext();
            return context.Bookings
              .Where(b => b.Status == "Rezervasyon Onaylandı")
              .ToList();

        }

        public List<Booking> GetBookingsByStatusCancelled()
        {
            using var context = new SignalRContext();
            return context.Bookings
              .Where(b => b.Status == "Rezervasyon İptal Edildi")
              .ToList();
        }

        public List<Booking> GetBookingsByStatusPending()
        {
            using var context = new SignalRContext();
            return context.Bookings
              .Where(b => b.Status == "Rezervasyon Bekletiliyor")
              .ToList();
        }
    }
}
