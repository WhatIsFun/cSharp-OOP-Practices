
namespace cSharp_OOP_Practices
{
    class Circle
    {
        public double radius;
        public double PI = 3.14;
        public double circleArea = 0;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double getArea()
        {
            return circleArea = PI * radius * radius;
        }
    }
}
