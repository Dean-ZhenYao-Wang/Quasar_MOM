namespace MOM.Application.DTOs.Personnel.Requests
{
    /// <summary>
    ///
    /// </summary>
    public class UpdatePersonRequest : AddPersonRequest
    {
        /// <summary>
        /// 人员的唯一标识
        /// </summary>
        public Guid DtId { get; set; }
    }
}