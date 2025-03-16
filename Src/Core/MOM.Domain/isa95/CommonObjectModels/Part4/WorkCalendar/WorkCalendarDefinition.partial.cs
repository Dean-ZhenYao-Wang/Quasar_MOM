using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCalendar
{
    /// <summary>
    /// 工作日程定义
    /// </summary>
    public partial class WorkCalendarDefinition
    {
        /// <summary>
        /// 日历定义类型<br></br>
        /// 定义工作日历定义的类型。没有定义标准日历定义类型。
        /// </summary>
        [JsonPropertyName("definitionType")]
        public string DefinitionType { get; set; }
        public string? Description { get; set; }
        public WorkCalendarDefinition(string ID,string? description,string definitionType)
        {
            this.Id= Id;
            Description = description;
            DefinitionType = definitionType;
        }
        public void Update(string ID, string? description, string definitionType)
        {
            this.Id = Id;
            Description = description;
            DefinitionType = definitionType;
        }

        public void Delete()
        {
            foreach (var item in Contains)
            {
                item.Target.Delete();
            }
            foreach(var item in HasPropertiesOf)
            {
                item.Target.Delete();
            }
            this.Contains.Clear();
            this.HasPropertiesOf.Clear();
            this.HierarchyScopeRel.Clear();
            this.IsDelete = true;
        }
    }
}
