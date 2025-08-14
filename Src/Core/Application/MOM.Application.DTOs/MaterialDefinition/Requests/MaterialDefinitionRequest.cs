using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOM.Domain.isa95.CommonObjectModels.Part2.Material;

namespace MOM.Application.DTOs.MaterialDefinition.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class MaterialDefinitionRequest
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string? Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public required string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        /// <remarks>
        /// 关于该物料类别的补充说明信息，例如用途、工艺要求等。
        /// </remarks>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// 计量单位
        /// </summary>
        public required string Unity { get; set; }
        /// <summary>
        /// 当前物料定义的属于类别
        /// </summary>
        public List<Guid> IsMemberOfClass_TargetDtId { get; set; } = new List<Guid>();
        /// <summary>
        /// 当前物料定义的组成
        /// </summary>
        public List<Guid> IsAssembledFrom_TargetDtId { get; set; } = new List<Guid>();
        public Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty Property { get; set; }
        public MOM.Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition ToMaterialDefinition()
        {
            MOM.Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition model = new Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition(this.Id, this.Description);
            foreach(var targetDtId in this.IsMemberOfClass_TargetDtId)
            {
                model.IsMemberOfClass.Add(new Domain.Common.Relationship.isa95.MaterialDefinition.MaterialDefinitionIsMemberOfClassRelationship(model.DtId,targetDtId));
            }
            foreach(var targetDtId in this.IsAssembledFrom_TargetDtId)
            {
                model.IsAssembledFrom.Add(new Domain.Common.Relationship.isa95.MaterialDefinition.MaterialDefinitionIsAssembledFromRelationship(model.DtId, targetDtId));
            }
            model.Property = this.Property;
            return model;
        }
    }
}
