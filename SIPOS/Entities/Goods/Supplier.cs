namespace SIPOS.Entities.Goods
{
    public class Supplier : EntityBase<Guid>
    {
        public string Name {  get; set; }
        public string Phone {  get; set; }  
        public string Email {  get; set; }

        public virtual ICollection<GoodsOrder> GoodsOrder { get; set; }
    }
}
