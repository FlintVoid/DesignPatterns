namespace DesignPatterns.Structural.Facade
{
    public class OggCompressionCodec : CompressionCodec
    {
        public string GetCodec()
        {
            return "OGG";
        }
    }
}