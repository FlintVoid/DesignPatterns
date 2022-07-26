using System;

namespace DesignPatterns.Behavioral.Iterator
{
    public class SocialSpammer
    {
        public void Send(ProfileIterator iterator, string message)
        {
            while (iterator.HasMore())
            {
                var profile = iterator.GetNext();
                Console.WriteLine(profile.Name + " " + message);
            }
        }
    }
}