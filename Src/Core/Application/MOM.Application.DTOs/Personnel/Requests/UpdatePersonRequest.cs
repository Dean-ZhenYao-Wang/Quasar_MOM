using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Application.DTOs.Personnel.Requests
{
    public class UpdatePersonRequest : AddPersonRequest
    {
        /// <summary>
        /// 人员的唯一标识
        /// </summary>
        public Guid DtId { get; set; }
    }
}