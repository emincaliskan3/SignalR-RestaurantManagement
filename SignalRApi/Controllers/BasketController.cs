using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.BasketDto;
using SignalR.EntityLayer.Entities;
using SignalRApi.Models;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }
        [HttpGet("GetBasketByMenuTableNumber")]
        public IActionResult GetBasketByMenuTableNumber(int id)
        {
            var values = _basketService.TGetBasketByMenuTableNumber(id);
            return Ok(values);
        }
        [HttpGet("BasketListByMenuTableWithProductName")]
        public IActionResult BasketListByMenuTableWithProductName(int id)
        {
            using var context = new SignalRContext();
            var values = context.Baskets.Include(x => x.Product).Where(y => y.MenuTableID == id).Select(z => new ResultBasketListWithProducts
            {
                BasketID = z.BasketID,
                Count = z.Count,
                MenuTableID = z.MenuTableID,
                Price = z.Price,
                ProductID = z.ProductID,
                TotalPrice = z.TotalPrice,
                ProductName = z.Product.ProductName
            }).ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            using var context = new SignalRContext();
            _basketService.TAdd(new Basket()
            {
                ProductID = createBasketDto.ProductID,
                MenuTableID = createBasketDto.MenuTableID,
                Count = 1,
                Price = context.Products.Where(x => x.ProductID == createBasketDto.ProductID).Select(y => y.Price).FirstOrDefault(),
                TotalPrice = createBasketDto.TotalPrice,

            });
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.TGetByID(id);
            if (value != null)
            {
                _basketService.TDelete(value);

                // Sepetin boş olup olmadığını kontrol et
                var remainingItems = _basketService.TGetBasketByMenuTableNumber(value.MenuTableID);

                if (remainingItems.Count == 0)
                {
                    // Sepet boşsa, masa durumunu false yap
                    _basketService.TChangeMenuTableStatusToFalse(value.MenuTableID);
                }

                return Ok("Sepetteki Seçilen Ürün Silindi ve Masa Güncellendi");
            }

            return NotFound("Silinecek ürün bulunamadı");
        }



    }
}
