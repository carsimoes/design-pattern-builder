using Builder.Models;

namespace Builder.Builder
{
    public class SchumarHamburguerBuilder : HamburguerBuilder
    {
        public override HamburguerBuilder WithBread()
        {
            _hamburguer.Bread = "Australiano";
            return this;
        }

        public override HamburguerBuilder WithMeat()
        {
            _hamburguer.Meat = "200 gramas angus";
            return this;
        }

        public override HamburguerBuilder WithCheese()
        {
            _hamburguer.Cheese = "Chedddar";
            return this;
        }

        public override HamburguerBuilder WithSalad()
        {
           _hamburguer.Salad = new Salad
           {
               HasLettuce = false,
               HasTomato = false,
               HasOnion = false,
               HasCucumber = false
           };
            return this;
        }

        public override HamburguerBuilder WithSauce()
        {
            _hamburguer.Sauce = "Maionese de cebolinha";
            return this;
        }

        public override HamburguerBuilder WithBacon()
        {
            _hamburguer.HasBacon = false;
            return this;
        }

        public override HamburguerBuilder WithEgg()
        {
            _hamburguer.HasEgg = false;
            return this;
        }
    }
}
