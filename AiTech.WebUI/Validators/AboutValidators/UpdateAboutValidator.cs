using AiTech.WebUI.DTOs.AboutDtos;
using FluentValidation;

namespace AiTech.WebUI.Validators.AboutValidators
{
    public class UpdateAboutValidator:AbstractValidator<UpdateAboutDto>
    {
        public UpdateAboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("*Başlık adı boş bırakılamaz !")
                              .MinimumLength(3).WithMessage("*Başlık adı minumum 3 karakterli olabilir");

            RuleFor(x => x.Description).NotEmpty().WithMessage("*Açıklama boş bırakılamaz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("*Fotoğraf Url'i boş bırakılamaz");
            RuleFor(x => x.Skill1).NotEmpty().WithMessage("*Özellik-1 boş bırakılamaz");
            RuleFor(x => x.Skill2).NotEmpty().WithMessage("*Özellik-2 boş bırakılamaz");
            RuleFor(x => x.Skill3).NotEmpty().WithMessage("*Özellik-3 boş bırakılamaz");
            RuleFor(x => x.Skill4).NotEmpty().WithMessage("*Özellik-4 boş bırakılamaz");


        }



    }
}
