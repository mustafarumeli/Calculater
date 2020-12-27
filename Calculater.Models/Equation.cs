namespace Calculater.Models
{
    public class Equation :RabbitMesseagable
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public string GetResult()
        {
            throw new System.NotImplementedException();
        }
    }
}