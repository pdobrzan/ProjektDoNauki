namespace Website.Mapper.Interfaces
{
    public interface IMapperService
    {
        TTo Map<TTo>(object source);
    }
}