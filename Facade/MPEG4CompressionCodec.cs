namespace DesignPatterns.Structural.Facade
{
    public class MPEG4CompressionCodec : CompressionCodec
    {
        public string GetCodec()
        {
            return "MP4";
        }
    }
}