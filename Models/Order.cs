public class Order
{
    public int Id { get; set; }
    public User User { get; set; }
    public Sandwich Sandwich { get; set; }
    public string Size { get; set; } 
    public bool IsTakeaway { get; set; }
    public DateTime OrderedAt { get; set; }
    public bool IsPaid { get; set; }
}