namespace DataAccseslayer.Entities
{
    public  class Brand : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public List<Brand> Brands { get; set; } = new List<Brand>();

    }
}
