namespace PIX.Models.Domain
{
    public class Service
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }
        public DateTime DateOfTransaction { get; set; }
        public long Amount { get; set; }
    }
}
