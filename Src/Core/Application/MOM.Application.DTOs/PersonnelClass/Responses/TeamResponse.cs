namespace MOM.Application.DTOs.PersonnelClass.Responses
{
    public class TeamResponse : PersonnelClassResponse
    {
        /// <summary>
        /// 负责人唯一标识
        /// </summary>
        public Guid? ResponsibleDtId { get; set; }

        /// <summary>
        /// 负责人姓名
        /// </summary>
        public string? ResponsibleName { get; set; }

        /// <summary>
        /// 所属班组唯一标识
        /// </summary>
        public Guid? SourceDtId { get; set; }

        /// <summary>
        /// 所属班组名称
        /// </summary>
        public string? SourceName { get; set; }
    }
}