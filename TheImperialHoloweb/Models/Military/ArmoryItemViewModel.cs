namespace TheImperialHoloweb.Models.Military
{
    public class ArmoryItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Faction { get; set; } = string.Empty;
        public string Synopsis { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ImagePath { get; set; }
    }
}
