namespace Api.Features.Tables.Commands.CreateTable
{
    public class CreateTableRequest
    {
        public int SeatCount { get; set; }
        public string Description { get; set; }
        public int TableNumber { get; set; }
    }
}
