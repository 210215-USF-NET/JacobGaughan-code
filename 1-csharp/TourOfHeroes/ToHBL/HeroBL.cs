using System;
using System.Collections.Generic;
using ToHDL;
using ToHModels;

namespace ToHBL
{
    public class HeroBL : IHeroBL
    {
        private IHeroRepository _repo;
        public HeroBL(IHeroRepository repo){
            _repo = repo;
        }
        public void AddHero(Hero newHero)
        {
            // TODO add Business Logic
            _repo.AddHero(newHero);
        }

        public List<Hero> GetHeroes()
        {
            // TODO add Business Logic
            return _repo.GetHeroes();
        }
    }
}
