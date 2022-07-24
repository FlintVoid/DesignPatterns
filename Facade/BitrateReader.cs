namespace DesignPatterns.Structural.Facade
{
    public class BitrateReader
    {
        public Buffer Read(string fileName, SourceCodec sourceCodec)
        {
            return new Buffer(fileName);
        }
    }
}