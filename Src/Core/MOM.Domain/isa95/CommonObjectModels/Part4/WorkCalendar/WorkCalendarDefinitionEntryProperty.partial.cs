using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCalendar
{
    public partial class WorkCalendarDefinitionEntryProperty
    {
        public void Delete()
        {
            foreach(var item in this.Contains)
            {
                item.Target.Delete();
            }
            this.Contains.Clear();
            this.IsDelete = true;
        }
    }
}
