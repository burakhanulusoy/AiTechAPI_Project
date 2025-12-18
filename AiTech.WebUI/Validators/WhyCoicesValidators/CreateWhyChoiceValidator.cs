using AiTech.WebUI.DTOs.WhyChoiseDtos;
using FluentValidation;

namespace AiTech.WebUI.Validators.WhyCoicesValidators
{
    public class CreateWhyChoiceValidator:AbstractValidator<CreateWhyChoiseDto>
    {
        public CreateWhyChoiceValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("*Başlık adı boş bırakılamaz !")
                         .MinimumLength(3).WithMessage("*Başlık adı minumum 3 karakterli olabilir");

            RuleFor(x => x.Description).NotEmpty().WithMessage("*Açıklama boş bırakılamaz");
            RuleFor(x => x.Item1).NotEmpty().WithMessage("*Özellik-1 boş bırakılamaz");
            RuleFor(x => x.Item2).NotEmpty().WithMessage("*Özellik-2 boş bırakılamaz");
            RuleFor(x => x.Item3).NotEmpty().WithMessage("*Özellik-3 boş bırakılamaz");



        }


    }
}
