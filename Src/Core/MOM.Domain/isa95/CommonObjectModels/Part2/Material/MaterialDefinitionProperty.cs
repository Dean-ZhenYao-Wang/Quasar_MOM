namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    [Owned]
    public partial class MaterialDefinitionProperty
    {

        /// <summary>
        /// 物料编码
        /// </summary>
        [Required]
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [Required]
        [JsonPropertyName("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 材质
        /// </summary>
        [JsonPropertyName("texture")]
        public string? Texture { get; set; }

        /// <summary>
        /// 型号
        /// </summary>
        [Required]
        [JsonPropertyName("modelNumber")]
        public string ModelNumber { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        [JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [JsonPropertyName("unitPrice")]
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        [Required]
        [JsonPropertyName("unitOfMeasurement")]
        public string UnitOfMeasurement { get; set; }

    }
}