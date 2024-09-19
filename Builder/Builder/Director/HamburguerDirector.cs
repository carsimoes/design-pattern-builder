using Builder.Builder;
using Builder.Models;

namespace Builder.Director
{
    public class HamburguerDirector
    {

        private HamburguerBuilder? _hamburguerBuilder;

        public HamburguerDirector()
        {
            _hamburguerBuilder = null;
        }

        public Hamburguer BuildAlainProstHamburguer()
        {
            _hamburguerBuilder = new AlainProstHamburguerBuilder();

            return _hamburguerBuilder
                .WithBread()
                .WithMeat()
                .WithCheese()
                .WithSalad()
                .WithSauce()
                .WithBacon()
                .WithEgg()
                .Build();
        }

        public Hamburguer BuildAyrtonSennaHamburguer()
        {
            _hamburguerBuilder = new AyrtonSennaHamburguerBuilder();

            return _hamburguerBuilder
                .WithBread()
                .WithMeat()
                .WithCheese()
                .WithSalad()
                .WithSauce()
                .WithBacon()
                .WithEgg()
                .Build();
        }

        public Hamburguer BuildNelsonPiquetHamburguer()
        {
            _hamburguerBuilder = new NelsonPiquetHamburguerBuilder();

            return _hamburguerBuilder
                .WithBread()
                .WithMeat()
                .WithCheese()
                .WithSalad()
                .WithSauce()
                .WithBacon()
                .WithEgg()
                .Build();
        }

        public Hamburguer BuildRubensBaricheloHamburguer()
        {
            _hamburguerBuilder = new RubensBaricheloHamburguerBuilder();

            return _hamburguerBuilder
                .WithBread()
                .WithMeat()
                .WithCheese()
                .WithSalad()
                .WithSauce()
                .WithBacon()
                .WithEgg()
                .Build();
        }

        public Hamburguer BuildSchumarHamburguer()
        {
            _hamburguerBuilder = new SchumarHamburguerBuilder();

            return _hamburguerBuilder
                .WithBread()
                .WithMeat()
                .WithCheese()
                .WithSalad()
                .WithSauce()
                .WithBacon()
                .WithEgg()
                .Build();
        }
    }
}
