namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Queries.DestinationQueries
{
    public class GetDestinationByIdQuery
    {
        public GetDestinationByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
