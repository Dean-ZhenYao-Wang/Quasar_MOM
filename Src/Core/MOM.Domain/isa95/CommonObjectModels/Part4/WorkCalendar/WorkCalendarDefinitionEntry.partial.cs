using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCalendar
{
    public partial class WorkCalendarDefinitionEntry
    {
        public string? Description { get; set; }
        public WorkCalendarDefinitionEntry(string ID, string? description, string startRule, string recurrenceTimeIntervalRule, string durationRule, string entryType)
        {
            this.Id = Id;
            Description = description;
            StartRule = startRule;
            RecurrenceTimeIntervalRule = recurrenceTimeIntervalRule;
            DurationRule = durationRule;
            EntryType = entryType;
        }
        public void Update(string ID, string? description, string startRule, string recurrenceTimeIntervalRule, string durationRule, string entryType)
        {
            this.Id = Id;
            Description = description;
            StartRule = startRule;
            RecurrenceTimeIntervalRule = recurrenceTimeIntervalRule;
            DurationRule = durationRule;
            EntryType = entryType;
        }

        public void Delete()
        {
            foreach(var item in this.IsMadeUpOf)
            {
                item.Target.Delete();
            }
            foreach(var item in this.HasPropertiesOf)
            {
                item.Target.Delete();
            }
            this.IsMadeUpOf.Clear();
            this.HasPropertiesOf.Clear();
            this.IsDelete = true;
        }
    }
}
