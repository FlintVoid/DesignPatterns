namespace DesignPatterns.Behavioral.Iterator
{
    public class VKIterator : ProfileIterator
    {
        private string _profileId;
        private SocialNetwork _socialNetwork;
        private Profile[] _cache;
        private int _currentPosition;
        
        public VKIterator(SocialNetwork socialNetwork, string profileId)
        {
            _socialNetwork = socialNetwork;
            _profileId = profileId;
        }

        public Profile GetNext()
        {
            if (!HasMore()) return null;
            return _cache[_currentPosition++];
        }

        public bool HasMore()
        {
            LazyInit();
            return _currentPosition < _cache.Length;
        }

        private void LazyInit()
        {
            if (_cache == null)
                _cache = _socialNetwork.GetSocialFriend(_profileId);
        }
    }
}