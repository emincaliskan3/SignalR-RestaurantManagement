﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(_mapper.Map<List<ResultBookingDto>>(values));
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            var value = _mapper.Map<Booking>(createBookingDto);
            _bookingService.TAdd(value);
            return Ok("Rezervasyon Yapıldı");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon Silindi");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            var value = _mapper.Map<Booking>(updateBookingDto);
            _bookingService.TUpdate(value);
            return Ok("Rezervasyon Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok(_mapper.Map<GetBookingDto>(value));
        }

        [HttpGet("BookingStatusApproved/{id}")]
        public IActionResult BookingStatusApproved(int id)
        {
            _bookingService.TBookingStatusApproved(id);
            return Ok("Rezervasyon Açıklaması Değiştirildi");
        }

        [HttpGet("BookingStatusCancelled/{id}")]
        public IActionResult BookingStatusCancelled(int id)
        {
            _bookingService.TBookingStatusCancelled(id);
            return Ok("Rezervasyon Açıklaması Değiştirildi");
        }
        [HttpGet("BookingStatusPending/{id}")]
        public IActionResult BookingStatusPending(int id)
        {
            _bookingService.TBookingStatusPending(id);
            return Ok("Rezervasyon Beklemeye Alındı");
        }

        [HttpGet("GetBookingsByStatusApproved")]
        public IActionResult GetBookingsByStatusApproved()
        {
            var values = _bookingService.TGetBookingsByStatusApproved();
            return Ok(_mapper.Map<List<ResultBookingDto>>(values));
        }

        [HttpGet("GetBookingsByStatusCancelled")]
        public IActionResult GetBookingsByStatusCancelled()
        {
            var values = _bookingService.TGetBookingsByStatusCancelled();
            return Ok(_mapper.Map<List<ResultBookingDto>>(values));
        }

        [HttpGet("GetBookingsByStatusPending")]
        public IActionResult GetBookingsByStatusPending()
        {
            var values = _bookingService.TGetBookingsByStatusPending();
            return Ok(_mapper.Map<List<ResultBookingDto>>(values));
        }

    }
}