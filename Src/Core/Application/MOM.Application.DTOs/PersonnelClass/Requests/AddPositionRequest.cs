using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.PersonnelClass.Requests
{
    public class AddPositionRequest:PersonnelClassRequest
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 转换成db模型
        /// </summary>
        /// <param name="description">说明-系统内部做业务区分使用的</param>
        /// <returns></returns>
        public Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass ToPersonnelClass(string description)
        {
            Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass personnelClass = new Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass(this.Id, description);
            personnelClass.Remark = this.Remark;
            return personnelClass;
        }
    }
}
