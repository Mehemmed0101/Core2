using CinemaConsoleProjectNew.Models;
using Core.Models;
using Core.Services.Contracts;

namespace CinemaConsoleProjectNew.Services
{
    internal class SeansManager : IPrintService, ICrudservice
    {
        private Seans[] _seans = new Seans[4];
        private int _seansCount;

        public void Add(Entity entity)
        {
            if (_seansCount > 3)
            {
                Console.WriteLine("Yalniz 4 seans elave etmek olar!!");
            }
            _seans[_seansCount++] = (Seans)entity;

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _seans.Length; i++)
            {
                if (_seans[i] == null)
                    continue;

                if (id == _seans[i].Id)
                {
                    Console.WriteLine(_seans[i]);
                    return _seans[i];
                }
            }
            Console.WriteLine("Not Found!!");
            return null;
        }

        public void Print()
        {
            foreach (var item in _seans)
            {
                if (item == null)
                    continue;
                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
