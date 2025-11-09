namespace Kazka.Application.Requests.Queries
{
    public class GetStorySummaryQuery
    {
        public int? CategorId { get; set; }
        public int? Limit { get; set; }
        public int? Offset { get; set; }
    }
}
