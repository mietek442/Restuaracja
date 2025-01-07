namespace Api.Domain.Models
{
    public class RestaurantTable
    {
        public Guid Id { get; set; }
        public int TableNumber { get; set; }    
        public int SeatCount { get; set; }
        // jak coś to jest taki opis że stolik przy Oknie, Stolik dla Palacych, Stolik dla Meneli itd.
        public string Description { get; set; }
        public bool HasReservation { get; set; }
        public List<TableReservation> TableReservations { get; set; } = new List<TableReservation>();
    }
}
