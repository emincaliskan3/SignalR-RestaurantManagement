﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessageController : ControllerBase
	{
		private readonly IMessageService _messageService;

		public MessageController(IMessageService messageService)
		{
			_messageService = messageService;
		}
		[HttpGet]
		public IActionResult MessageList()
		{
			var values = _messageService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateMessage(CreateMessageDto createMessageDto)
		{
			Message message = new Message()
			{
				NameSurname = createMessageDto.NameSurname,
				Mail = createMessageDto.Mail,
				MessageContent = createMessageDto.MessageContent,
				Phone = createMessageDto.Phone,
				Status = false,
				Subject = createMessageDto.Subject,
				MessageSendDate = DateTime.Now
			};
			_messageService.TAdd(message);
			return Ok("Mesaj Başarılı Bir Şekilde Gönderildi");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteMessage(int id)
		{
			var value = _messageService.TGetByID(id);
			_messageService.TDelete(value);
			return Ok("Mesaj Alanı Silindi");
		}
		[HttpPut]
		public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
		{
			Message message = new Message()
			{
				MessageID = updateMessageDto.MessageID,
				NameSurname = updateMessageDto.NameSurname,
				Mail = updateMessageDto.Mail,
				MessageContent = updateMessageDto.MessageContent,
				Phone = updateMessageDto.Phone,
				Status = false,
				Subject = updateMessageDto.Subject,
				MessageSendDate = updateMessageDto.MessageSendDate

			};
			_messageService.TUpdate(message);
			return Ok("Mesaj Başarılı Bir Şekilde Güncellendi");

		}
		[HttpGet("{id}")]
		public IActionResult GetMessage(int id)
		{
			var value = _messageService.TGetByID(id);
			return Ok(value);
		}
	}
}
