namespace DesignPatterns.Structural.Facade
{
    public class VideoFile
    {
        public string Name { get; }

        private CompressionCodec _codec;
        public VideoFile(string name, CompressionCodec codec)
        {
            Name = name;
            _codec = codec;
        }

        public string Save()
        {
            return $"{Name} {_codec.GetCodec()}";
        }
    }
}