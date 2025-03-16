namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    public partial class SegmentData
    {
        public SegmentData(string ID, string value, string valueUnitOfMeasure) : this()
        {
            this.Id = Id;
            this.Value = value;
            this.ValueUnitOfMeasure = valueUnitOfMeasure;
        }
    }
}