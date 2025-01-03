namespace Api.Domain.Models
{
    public class Table
    {
        Guid Id { get; set; }
        public int SeatNumber { get; set; }
        // jak coś to jest taki opis że stolik przy Oknie, Stolik dla Palacych, Stolik dla Meneli itd.
        public string Description { get; set; }
        public bool IsReservate { get; set; }
    }
}
