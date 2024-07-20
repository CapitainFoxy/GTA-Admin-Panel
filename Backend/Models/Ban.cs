namespace GTAServerAdmin.Models
{
    public class Ban
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string Reason { get; set; }
        public DateTime BanDate { get; set; }
    }
}
