using Builder.Models;

namespace Builder.Builder
{
    public class AlainProstHamburguerBuilder : HamburguerBuilder
    {
        public override HamburguerBuilder WithBread()
        {
            _hamburguer.Bread = "Brioche";
            return this;
        }

        public override HamburguerBuilder WithMeat()
        {
            _hamburguer.Meat = "200 gramas angus";
            return this;
        }

        public override HamburguerBuilder WithCheese()
        {
            _hamburguer.Cheese = string.Empty;
            return this;
        }

        public override HamburguerBuilder WithSalad()
        {
           _hamburguer.Salad = new Salad
           {
               HasLettuce = true,
               HasTomato = true,
               HasOnion = false,
               HasCucumber = true
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
