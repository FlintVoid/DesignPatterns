namespace DesignPatterns.Behavioral.Iterator
{
    public interface SocialNetwork
    {
        ProfileIterator createFriendsIterator(string profileId);
        Profile[] GetSocialFriend(string profileId);
    }
}