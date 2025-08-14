using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.MaterialClass;
using MOM.Domain.isa95.CommonObjectModels.Part2.Material;

namespace MOM.Application.DTOs.MaterialClass.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class MaterialClassRequest
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
        /// 扩展属性
        /// </summary>
        public MaterialClassProperty Property { get; set; } = new MaterialClassProperty();

        /// <summary>
        /// 装配类型
        /// </summary>
        /// <remarks>
        /// 定义该物料类作为装配体时的类型，区分是物理连接还是逻辑组合。
        /// </remarks>
        public MaterialClassAssemblyType? AssemblyType { get; set; }
        /// <summary>
        /// 装配关系
        /// </summary>
        /// <remarks>
        /// 定义组件之间的装配关系性质，是永久性还是临时性的。
        /// </remarks>
        public MaterialClassAssemblyRelationship? AssemblyRelationship { get; set; }
        /// <summary>
        /// 线性分类 在物料主数据建设工程，往往分类采用线分类   https://zhuanlan.zhihu.com/p/496464306
        /// 当前分类包含的子分类
        /// </summary>
        /// <remarks>
        /// 父子关系
        /// <para>此物料类别包含其他物料类别的属性（即继承或复用其特性）。用于表达物料类之间的属性聚合或复用关系。</para>
        /// </remarks>
        public Guid? IncludesPropertiesOf_SourceDtId { get; set; }
        /// <summary>
        /// 面分类 又称平行分类 物料模板采用面分类 https://zhuanlan.zhihu.com/p/496464306
        /// 组成当前分类的类型
        /// </summary>
        /// <remarks>
        /// 表示父级物料类别由一个或多个子级物料类别作为组成部分构成。
        /// <para>例如：成品由半成品或原材料组装而成。</para>
        /// </remarks>
        public List<Guid> IsAssembledFrom_SourceDtId { get; set; } = new List<Guid>();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass ToMaterialClass()
        {
            var model = new Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass(this.Id!, this.Name, this.Description, this.AssemblyType, this.AssemblyRelationship);
            model.Property = this.Property;
            if (this.IncludesPropertiesOf_SourceDtId != null)
                model.IncludesPropertiesOf.Add(new MaterialClassIncludesPropertiesOfRelationship(this.IncludesPropertiesOf_SourceDtId.Value, model.DtId));
            foreach(var sourceDtId in this.IsAssembledFrom_SourceDtId)
            {
                model.IsAssembledFrom.Add(new MaterialClassIsAssembledFromRelationship(sourceDtId, model.DtId));
            }
            return model;
        }
    }
}