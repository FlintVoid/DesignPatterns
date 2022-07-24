namespace DesignPatterns.Structural.Bridge
{
    public class Remote
    {
        protected Device _device;

        public Remote(Device device)
        {
            _device = device;
        }

        public bool TogglePower()
        {
            if (_device.IsEnabled())
            {
                _device.Disable();
            }
            else
            {
                _device.Enable();
            }

            return _device.IsEnabled();
        }

        public int VolumeDown()
        {
            _device.SetVolume(_device.GetVolume() - 1);
            return _device.GetVolume();
        }
        
        public int VolumeUp()
        {
            _device.SetVolume(_device.GetVolume() + 1);
            return _device.GetVolume();
        }
        
        public int ChannelDown()
        {
            _device.SetChannel(_device.GetChannel() - 1);
            return _device.GetChannel();
        }
        
        public int ChannelUp()
        {
            _device.SetChannel(_device.GetChannel() + 1);
            return _device.GetChannel();
        }
    }
}