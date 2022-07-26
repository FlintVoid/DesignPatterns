namespace DesignPatterns.Behavioral.Iterator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var network = new VK();
            var spammer = new SocialSpammer();
            
            spammer.Send(network.createFriendsIterator("current_id"), "hello");
        }
    }
}