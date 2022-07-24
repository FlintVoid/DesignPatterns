namespace DesignPatterns.Structural.Bridge
{
    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(Device device) : base(device)
        {
        }

        public void Mute()
        {
            _device.SetVolume(0);
        }
    }
}