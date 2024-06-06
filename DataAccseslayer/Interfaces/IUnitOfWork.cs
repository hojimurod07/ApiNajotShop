namespace DataAccseslayer.Interfaces
{
    public interface IUnitOfWork
    {
        public IUserInterface User { get; }
        public IBrandInterface  Brand { get; }
        public  ICarInterface Cars { get; }

    }
}
