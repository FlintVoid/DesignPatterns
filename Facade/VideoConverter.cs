namespace DesignPatterns.Structural.Facade
{
    public class VideoConverter
    {
        public VideoFile Convert(string fileName, string format)
        {
            var file = new File(fileName);
            var sourceCodec = new CodecFactory().Extract(file);
            CompressionCodec compressionCodec;
            
            if (format == "mp4")
            {
                compressionCodec = new MPEG4CompressionCodec();
            }
            else
            {
                compressionCodec = new OggCompressionCodec();
            }

            var bitrateReader = new BitrateReader();
            var buffer = bitrateReader.Read(fileName, sourceCodec);
            var result = new AudioMixer().Fix(buffer, compressionCodec);
            
            return result;
        }
    }
}