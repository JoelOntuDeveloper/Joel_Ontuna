namespace Data.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string relevance { get; set; } 
        public int? userId { get; set; }
        public virtual User User { get; set; } = null;
    }
}
