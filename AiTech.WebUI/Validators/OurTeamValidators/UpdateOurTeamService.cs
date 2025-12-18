using AiTech.WebUI.DTOs.OurTeamDtos;
using FluentValidation;

namespace AiTech.WebUI.Validators.OurTeamValidators
{
    public class UpdateOurTeamService:AbstractValidator<UpdateOurTeamDto>
    {
        public UpdateOurTeamService()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("*Ad kısımı boş bırakılamaz!");
            RuleFor(x => x.Job).NotEmpty().WithMessage("*İş kısımı boş bırakılamaz!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("*Resim kısımı boş bırakılamaz!");
            RuleFor(x => x.FacebookLink).NotEmpty().WithMessage("*Facebook kısımı boş bırakılamaz!");
            RuleFor(x => x.InstagramLink).NotEmpty().WithMessage("*Instagram kısımı boş bırakılamaz!");
            RuleFor(x => x.TwitterLink).NotEmpty().WithMessage("*Twitter kısımı boş bırakılamaz!");
            RuleFor(x => x.LinkedlnLink).NotEmpty().WithMessage("*Linkedln kısımı boş bırakılamaz!");

        }





    }
}
