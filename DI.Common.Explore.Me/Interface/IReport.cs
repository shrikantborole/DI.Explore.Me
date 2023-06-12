namespace DI.Common.Explore.Me.Interface
{
    public interface IReport<T> 
    {
        public void Extract(string path, T inputParameter);
    }
}
