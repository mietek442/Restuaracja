namespace Api.Features.TableReservations.Helpers
{
    public class ReservationRequest
    {
        public string ClientName { get; set; }
        public Guid TableId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}