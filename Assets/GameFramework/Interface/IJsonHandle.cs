
namespace Game.Framework.Interface
{
    public interface IJsonHandle<T>
    {
        string ToJson();

        T FromJson(string json);
    }

}
