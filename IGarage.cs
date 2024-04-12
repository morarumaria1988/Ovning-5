
namespace Övning_5
{
    internal interface IGarage<T> where T : Vehicle
    {
        IEnumerator<T> GetEnumerator();
    }
}