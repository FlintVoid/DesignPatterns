namespace DesignPatterns.Structural.Facade
{
    public class AudioMixer
    {
        public VideoFile Fix(Buffer buffer, CompressionCodec compressionCodec)
        {
            return new VideoFile(buffer.Name, compressionCodec);
        }
    }
}