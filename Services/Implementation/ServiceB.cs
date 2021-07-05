
namespace Ex1.Services
{
    public class ServiceB : ICaculator
    {
        public float Add(float numberA, float numberB)
        {
            return numberA + numberB + 100;
        }
    }
}