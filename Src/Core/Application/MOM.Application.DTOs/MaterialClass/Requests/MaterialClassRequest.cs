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
        /// 
        /// </summary>
        /// <returns></returns>
        public Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass ToEquipmentClass()
        {
            var model = new Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass(this.Id!, this.Name, this.Description);
            model.Property = this.Property;
            return model;
        }
    }
}