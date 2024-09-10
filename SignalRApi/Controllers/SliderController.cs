﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;
using SignalR.DtoLayer.FeatureDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SliderController : ControllerBase
	{
		private readonly ISliderService _sliderService;
		private readonly IMapper _mapper;

		public SliderController(ISliderService sliderService, IMapper mapper)
		{
			_sliderService = sliderService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult SliderList()
		{
			var value = _mapper.Map<List<ResultFeatureDto>>(_sliderService.TGetListAll());
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateSlider(CreateFeatureDto createFeatureDto)
		{
			_featureService.TAdd(new Feature()
			{
				Description1 = createFeatureDto.Description1,
				Description2 = createFeatureDto.Description2,
				Description3 = createFeatureDto.Description3,
				Title1 = createFeatureDto.Title1,
				Title2 = createFeatureDto.Title2,
				Title3 = createFeatureDto.Title3,

			});
			return Ok("Öne Çıkan Bilgisi Eklendi");

		}
		[HttpDelete("{id}")]
		public IActionResult DeleteFeature(int id)
		{
			var value = _featureService.TGetByID(id);
			_featureService.TDelete(value);
			return Ok("Öne Çıkan Bilgisi Silindi");
		}
		[HttpGet("{id}")]
		public IActionResult GetFeature(int id)
		{
			var value = _featureService.TGetByID(id);

			return Ok(value);
		}
		[HttpPut]
		public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
		{
			_featureService.TUpdate(new Feature()
			{
				Description1 = updateFeatureDto.Description1,
				Description2 = updateFeatureDto.Description2,
				Description3 = updateFeatureDto.Description3,
				Title1 = updateFeatureDto.Title1,
				Title2 = updateFeatureDto.Title2,
				Title3 = updateFeatureDto.Title3,
				FeatureID = updateFeatureDto.FeatureID

			});
			return Ok("Öne Çıkan Alan Bilgisi Güncellendi");
		}
	}
}
