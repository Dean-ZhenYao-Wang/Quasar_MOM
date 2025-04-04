using FluentValidation;
using MOM.Application.Wrappers;

namespace MOM.Application.DTOs.Account.Requests
{
    public class ChangePasswordRequest
    {
        /// <summary>
        /// 旧密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 新密码
        /// </summary>
        public string ConfirmPassword { get; set; }
    }
    public class ChangePasswordRequestValidator : AbstractValidator<ChangePasswordRequest>
    {
        public ChangePasswordRequestValidator(ITranslator translator)
        {
            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .MinimumLength(6)
                .Matches(Regexs.Password)
                .WithName(p => translator[nameof(p.Password)]);

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password)
                .Matches(Regexs.Password)
                .WithName(p => translator[nameof(p.ConfirmPassword)]);
        }
    }
}
