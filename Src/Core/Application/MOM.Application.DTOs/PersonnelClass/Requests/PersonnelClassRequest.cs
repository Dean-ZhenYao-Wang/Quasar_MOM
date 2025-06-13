using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Application.DTOs.PersonnelClass.Requests
{
    public class PersonnelClassRequest
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string? Remark { get; set; }
        /// <summary>
        /// 扩展属性
        /// </summary>
        public PersonnelClassProperty Property { get; set; }

        /// <summary>
        /// 转换成db模型
        /// </summary>
        /// <returns></returns>
        public virtual Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass ToPersonnelClass(string description)
        {
            Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass personnelClass = new Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass(this.Id,this.Id, description);
            personnelClass.Remark = this.Remark;
            personnelClass.Property = this.Property;
            return personnelClass;
        }
    }
}