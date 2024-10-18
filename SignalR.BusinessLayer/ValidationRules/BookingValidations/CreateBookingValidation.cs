using FluentValidation;
using SignalR.DtoLayer.BookingDto;


namespace SignalR.BusinessLayer.ValidationRules.BookingValidations
{
    public class CreateBookingValidation : AbstractValidator<CreateBookingDto>
    {
        public CreateBookingValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez.");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon Boş Geçilemez.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Boş Geçilemez.");
            RuleFor(x => x.PersonCount).NotEmpty().WithMessage("Kişi Sayısı Boş Geçilemez.");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Tarih Boş Geçilemez lütfen tarih seçimi yapınız.");

            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Lütfen isim alanına en az 5 karakter giriniz.").MaximumLength(50).WithMessage("Lütfen isim alanına en fazla 50 karakter giriniz.");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("Lütfen açıklama alanına en fazla 500 karakter giriniz.");

            RuleFor(x => x.Mail).EmailAddress().WithMessage("Lütfen geçerli bir email adresi giriniz");
        }
    }
}
