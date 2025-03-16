using MOM.Domain.Common.EnumType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    public partial class OperationsDefinition
    {
        /// <summary>
        /// 工艺名称
        /// </summary>
        [JsonPropertyName("name")]
        required public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        public OperationsDefinition(string number, string name, string description, string? version, OperationsDefinitionOperationsType? operationsType, OperationsDefinitionDefinitionType? definitionType) : this()
        {
            this.Id = Id;
            this.Name = name;
            this.Description = description;
            this.Version = version;
            this.OperationsType = operationsType;
            this.DefinitionType = definitionType;
        }
        /// <summary>
        /// todo 待BOM功能完成后使用
        /// </summary>
        [JsonPropertyName("bomKey")]
        public string? BomKey { get; set; }
        /// <summary>
        /// todo 待文件上传限制功能添加完成后，限制才有效果
        /// 附件名称 文件大小不能超过5MB，格式为doc/xls/xlsx/pdf/jpg/png/txt的文件
        /// </summary>
        [JsonPropertyName("fileName")]
        public string? FileName { get; set; }
        /// <summary>
        /// 状态 True：启用 False：禁用
        /// </summary>
        [JsonPropertyName("status")]
        public bool Status { get; set; }

        public void Update(string number, string name, string? description, string? version, OperationsDefinitionOperationsType? operationsType, OperationsDefinitionDefinitionType? definitionType, string? bomKey, string? fileName, bool status)
        {
            this.Id = number;
            this.Name= name;
            this.Description = description;
            this.Version = version;
            this.OperationsType = operationsType;
            this.DefinitionType = definitionType;
            this.BomKey = bomKey;
            this.FileName = fileName;
            this.Status = status;
        }

        public void Delete()
        {
            //todo 删除相关数据
            this.Contains.Clear();
            this.IncludesPropertiesOf.Clear();
            this.HasAssociated.Clear();
            this.HierarchyScopeRel.Clear();
            this.IsDelete = true;
        }
    }
}
