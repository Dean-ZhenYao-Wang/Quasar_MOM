using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCalendar
{
    public partial class WorkCalendarEntry
    {
        public void Delete()
        {
            foreach (var item in MapsTo)
            {
                item.Target.Delete();
            }
            this.MapsTo.Clear();
            foreach (var item in HasValuesOf)
            {
                item.Target.Delete();
            }
            this.HasValuesOf.Clear();
            foreach (var item in IsMadeUpOf)
            {
                item.Target.Delete();
            }
            this.IsMadeUpOf.Clear();
            this.IsDelete = true;
        }
    }
}
