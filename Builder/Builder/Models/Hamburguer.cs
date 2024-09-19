namespace Builder.Models
{
    public class Hamburguer
    {
        public Hamburguer()
        {   
        }

        public string? Bread { get; set; }
        public string? Meat { get; set; }
        public  string? Cheese { get; set; }
        public Salad? Salad { get; set; }
        public  string? Sauce { get; set; }
        public  bool HasBacon { get; set; }
        public  bool HasEgg { get; set; }

        public override string ToString()
        {
            return $"Bread: {Bread}, Meat: {Meat}, Cheese: {Cheese}, Salad: {Salad}, Sauce: {Sauce}, HasBacon: {HasBacon}, HasEgg: {HasEgg}";
        }
    }
}
