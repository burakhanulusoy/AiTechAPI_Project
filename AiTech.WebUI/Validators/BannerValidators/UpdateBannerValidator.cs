using AiTech.WebUI.DTOs.BannerDto;
using FluentValidation;

namespace AiTech.WebUI.Validators.BannerValidators
{
    public class UpdateBannerValidator:AbstractValidator<UpdateBannerDto>
    {

        public UpdateBannerValidator()
        {

            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık adı boş geçilemez")
                                 .MinimumLength(5).WithMessage("Başlık adı minumun 5 karakterli olmak zorundadır.")
                                 .MaximumLength(100).WithMessage("Başlık adı maximum 100 karakterli olmaz zorundadır");


            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz.")
                                      .MinimumLength(20).WithMessage("Açıklama minumum 20 karakterli olmak zorundadır.")
                                      .MaximumLength(800).WithMessage("Açıklama maximum 800 kaarkterli olabilir");



            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Url boş bırakılamz");


        }




    }
}
