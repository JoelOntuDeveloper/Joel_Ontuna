namespace Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
