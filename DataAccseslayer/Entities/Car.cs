namespace DataAccseslayer.Entities
{
    public  class Car :BaseEntity
    {
        public string Model { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public double Price {  get; set; }
        public int BrandId {  get; set; }
        public Brand? Brand { get; set; }

    }
}
