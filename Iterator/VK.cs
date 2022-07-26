namespace DesignPatterns.Behavioral.Iterator
{
    public class VK : SocialNetwork
    {
        public ProfileIterator createFriendsIterator(string profileId)
        {
            return new VKIterator(this, profileId);
        }

        public Profile[] GetSocialFriend(string profileId)
        {
            return new[]
            {
                new Profile("Vasia Pupkin"),
                new Profile("Igor Nikolaev"),
                new Profile("Vyacheslav Porebrik")
            };
        }
    }
}