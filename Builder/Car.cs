using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class Car
    {
        private StringBuilder _stringBuilder;

        public Car()
        {
            _stringBuilder = new StringBuilder();
            _stringBuilder.Append("Car has features ");
        }
        
        public void SetFeature(string feature)
        {
            _stringBuilder.Append(feature + " ");
        }

        public override string ToString()
        {
            return _stringBuilder.ToString();
        }
    }
}