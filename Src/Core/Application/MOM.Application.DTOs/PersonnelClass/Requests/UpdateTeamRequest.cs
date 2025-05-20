namespace MOM.Application.DTOs.PersonnelClass.Requests
{
    public class UpdateTeamRequest : AddTeamRequest
    {
        /// <summary>
        /// 班组的数据库唯一标识
        /// </summary>
        public Guid DtId { get; set; }
    }
}