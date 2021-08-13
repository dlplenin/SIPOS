namespace SIPOS.Entities
{
    public class Order
    {
        public Guid Id {  get; set; }    
        public string Number {  get; set; }
        public DateTime OrderDate {  get; set; } = DateTime.UtcNow;

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
