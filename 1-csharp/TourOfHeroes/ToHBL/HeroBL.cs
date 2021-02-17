using System;
using System.Collections.Generic;
using ToHDL;
using ToHModels;

namespace ToHBL
{
    public class HeroBL : IHeroBL
    {
        private IHeroRepository repo = new HeroRepoSC();
        public void AddHero(Hero newHero)
        {
            // TODO add Business Logic
            repo.AddHero(newHero);
        }

        public List<Hero> GetHeroes()
        {
            // TODO add Business Logic
            return repo.GetHeroes();
        }
    }
}
