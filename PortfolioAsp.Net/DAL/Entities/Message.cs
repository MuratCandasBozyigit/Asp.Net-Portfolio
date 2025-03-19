namespace PortfolioAsp.Net.DAL.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string MessageText { get; set; }
        public DateTime Created { get; set; }=DateTime.Now;

        public bool IsRead { get; set; } = false;   

    }
}
