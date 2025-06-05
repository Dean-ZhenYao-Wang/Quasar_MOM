namespace MOM.Application.DTOs.PersonnelClass.Requests
{
    public class PersonnelClassRequest
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string? Remark { get; set; }

        /// <summary>
        /// 转换成db模型
        /// </summary>
        /// <returns></returns>
        public virtual Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass ToPersonnelClass(string description)
        {
            Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass personnelClass = new Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass(this.Id,this.Name, description);
            personnelClass.Remark = this.Remark;
            return personnelClass;
        }
    }
}