namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    public partial class OperationsResponse
    {
        public OperationsResponse(string ID, DateTime startTime, DateTime endTime) : this()
        {
            this.Id = Id;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }
    }
}