using FluentValidation;

namespace MOM.Application.Features.Permission.Commands.AddMenu
{
    public class AddMenuCommandValidator : AbstractValidator<AddMenuCommand>
    {
        public AddMenuCommandValidator()
        {
            RuleFor(m => m.Id).NotEmpty().WithMessage("菜单编号不能为空");
            RuleFor(m => m.Name).NotEmpty().WithMessage("菜单名称不能为空");
            RuleFor(m => m.Path).NotEmpty().WithMessage("菜单路径不能为空");
        }
    }
}
