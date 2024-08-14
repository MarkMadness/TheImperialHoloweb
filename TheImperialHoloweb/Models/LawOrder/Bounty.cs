namespace TheImperialHoloweb.Models.LawOrder
{
    public class Bounty
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal PriceOfBounty { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool IsBountyActive { get; set; }
        public bool IsBountyComplete { get; set; }
    }
}