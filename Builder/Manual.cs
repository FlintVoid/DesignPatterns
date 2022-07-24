using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class Manual
    {
        private StringBuilder _stringBuilder;

        public Manual()
        {
            _stringBuilder = new StringBuilder();
            _stringBuilder.Append("Manual has features ");
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