namespace DesignPatterns.Structural.Bridge
{
    public class TV : Device
    {
        private bool _isEnable;
        private int _volume;
        private int _channel;

        private const int _maxVolume = 20;
        private const int _maxChannel = 10;

        public TV()
        {
            _channel = 1;
            _volume = 0;
        }
        public bool IsEnabled()
        {
            return _isEnable;
        }

        public void Enable()
        {
            _isEnable = true;
        }

        public void Disable()
        {
            _isEnable = false;
        }

        public int GetVolume()
        {
            return _volume;
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
            if (_volume > _maxVolume)
            {
                _volume = _maxVolume;
            }

            if (_volume < 0)
            {
                _volume = 0;
            }
        }

        public int GetChannel()
        {
            return _channel;
        }

        public void SetChannel(int channel)
        {
            _channel = channel;
            if (_channel >= _maxChannel)
            {
                _channel = 1;
            }

            if (_channel <= 0)
            {
                _channel = _maxChannel;
            }
        }
    }
}