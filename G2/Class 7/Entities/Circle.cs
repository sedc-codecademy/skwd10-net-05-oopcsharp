namespace CSharp_G2_C7_Inheritance.Entities
{
    public class Circle : Shape
    {
        public decimal Radius { get; set; }

        public Circle(decimal radius, string color) : base(color)
        {
            Radius = radius;
        }
    }
}
