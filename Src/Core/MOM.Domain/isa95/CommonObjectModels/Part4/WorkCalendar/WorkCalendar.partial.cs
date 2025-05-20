namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkCalendar
{
    public partial class WorkCalendar
    {
        public void Delete()
        {
            foreach (var item in this.DefinedBy)
            {
                item.Target.Delete();
            }
            this.DefinedBy.Clear();
            foreach (var item in this.Contains)
            {
                item.Target.Delete();
            }
            this.Contains.Clear();
            foreach (var item in this.HasValuesOf)
            {
                item.Target.Delete();
            }
            this.HasValuesOf.Clear();
            this.HierarchyScopeRel.Clear();
            this.IsDelete = true;
        }
    }
}