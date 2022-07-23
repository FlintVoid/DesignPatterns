using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Creational.Singleton
{
    public class Database
    {
        private static Database _instance;

        private Stack<string> _entities;
        
        public static Database GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Database();
            }

            return _instance;
        }
        
        public IEnumerable<string> SelectALL()
        {
            return _entities;
        }

        public void RemoveLast()
        {
            _entities.Pop();
        }

        private Database()
        {
            _entities = new Stack<string>();
            _entities.Push("c#");
            _entities.Push("java");
            _entities.Push("kotlin");
            _entities.Push("phyton");
            _entities.Push("js");
            _entities.Push("prolog");
        }
    }
}