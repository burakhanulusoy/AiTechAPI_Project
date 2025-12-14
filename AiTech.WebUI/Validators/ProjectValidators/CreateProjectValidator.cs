using AiTech.WebUI.DTOs.ProjectDto;
using FluentValidation;

namespace AiTech.WebUI.Validators.ProjectValidators
{
    public class CreateProjectValidator : AbstractValidator<CreateProjectDto>
    {

        public CreateProjectValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez.")
                                .MinimumLength(6).WithMessage("Başlık alanı en az 6 karakter olmalıdır.")
                                .MaximumLength(100).WithMessage("Başlık alanı en fazla 100 karakter olmalıdır.");


            RuleFor(x => x.Subject).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.")
                                  .MinimumLength(20).WithMessage("Açıklama alanı en az 20 karakter olmalıdır.")
                                  .MaximumLength(1000).WithMessage("Açıklama alanı en fazla 1000 karakter olmalıdır.");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim URL alanı boş geçilemez.");

            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori alanı boş geçilemez.");





        }
    }
}
