namespace MOM.Domain.isa95.CommonObjectModels
{
    using Microsoft.EntityFrameworkCore;
    using System.Text.Json.Serialization;
    /// <summary>
    /// 空间定义提供了一种沟通零维点、一维线、二维形状或三维固体地理空间位置数据的方法，用于规划/调度、实际、资源和分析
    /// </summary>
    [Owned]
    public class SpatialDefinition
    {
        /// <summary>
        /// 唯一标识空间定义的字符串。<br/>
        /// UN/CEFACT CCTS: （TextType）的地理空间信息，格式由format属性指定。
        /// </summary>
        public string? Value { get; set; }
        /// <summary>
        /// 确定 value 属性格式的枚举数。例如GPX， WKT，…
        /// </summary>

        public string? Format { get; set; }
        /// <summary>
        /// SRID是空间参考标识符（Spatial Reference Identifier），它通过识别坐标参考系统来识别一个预定义的坐标。
        /// </summary>
        public string? SRID { get; set; }
        /// <summary>
        /// SRID授权机构标识定义SRID标识的坐标参考系的授权机构。
        /// </summary>
        public string? SRIAuthority { get; set; }
    }
}