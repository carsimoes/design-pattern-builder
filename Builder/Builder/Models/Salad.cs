namespace Builder.Models
{
    public class Salad
    {
        public Salad()
        {
        }

        public bool HasLettuce { get; set; }
        public bool HasTomato { get; set; }
        public bool HasOnion { get; set; }
        public bool HasCucumber { get; set; }

        public override string ToString()
        {
            return $"HasLettuce: {HasLettuce}, HasTomato: {HasTomato}, HasOnion: {HasOnion}, HasCucumber: {HasCucumber}";
        }
    }
}
