using AiTech.WebUI.DTOs.TestimonialsDtos;
using FluentValidation;

namespace AiTech.WebUI.Validators.TestimonailValidators
{
    public class UpdateTestimonailValidator:AbstractValidator<UpdateTestimonialDto>
    {
        public UpdateTestimonailValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("*İsim boş bırakılamaz!")
                              .MinimumLength(3).WithMessage("*İsim minumum 3 karakterli olmak zorundadır!");
            RuleFor(x => x.Title).NotEmpty().WithMessage("*Meslek adı boş bırakılamaz!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("*Resim Url'i boş bırakılamaz!");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("*Yorum içeriği boş bırakılamaz!");




        }


    }
}
