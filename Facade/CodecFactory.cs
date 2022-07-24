namespace DesignPatterns.Structural.Facade
{
    public class CodecFactory
    {
        public SourceCodec Extract(File file)
        {
            return new SourceCodec();
        }
    }
}