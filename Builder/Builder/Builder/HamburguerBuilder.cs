using Builder.Models;

namespace Builder.Builder
{
    public abstract class HamburguerBuilder
    {

        protected readonly Hamburguer _hamburguer;

        public HamburguerBuilder()
        {
            _hamburguer = new Hamburguer();
        }

        public virtual HamburguerBuilder WithBread(string bread)
        {
            _hamburguer.Bread = bread;
            return this;
        }

        public virtual HamburguerBuilder WithBread()
        {
            return this;
        }

        public virtual HamburguerBuilder WithMeat(string meat)
        {
            _hamburguer.Meat = meat;
         
            return this;
        }

        public virtual HamburguerBuilder WithMeat()
        {
            return this;
        }


        public virtual HamburguerBuilder WithCheese(string cheese)
        {
            _hamburguer.Cheese = cheese;
            return this;
        }

        public virtual HamburguerBuilder WithCheese()
        {
            return this;
        }

        public virtual HamburguerBuilder WithSalad(bool hasLettuce, bool hasTomato, bool hasOnion, bool hasCucumber)
        {
            _hamburguer.Salad = new Salad
            {
                HasLettuce = hasLettuce,
                HasTomato = hasTomato,
                HasOnion = hasOnion,
                HasCucumber = hasCucumber
            };
            return this;
        }

        public virtual HamburguerBuilder WithSalad()
        {
            return this;
        }

        public virtual HamburguerBuilder WithSauce(string sauce)
        {
            _hamburguer.Sauce = sauce;
            return this;
        }

        public virtual HamburguerBuilder WithSauce()
        {
            return this;
        }

        public virtual HamburguerBuilder WithBacon(bool hasBacon)
        {
            _hamburguer.HasBacon = hasBacon;
            return this;
        }

        public virtual HamburguerBuilder WithBacon()
        {
            return this;
        }

        public virtual HamburguerBuilder WithEgg(bool hasEgg)
        {
            _hamburguer.HasEgg = hasEgg;
            return this;
        }

        public virtual HamburguerBuilder WithEgg()
        {
            return this;
        }

        public Hamburguer Build()
        {
            return _hamburguer;
        }
    }
}
