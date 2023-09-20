namespace DucPhuoc{
    class Program{
        static void Main(string[] args){
            Circle circle = new Circle();
            Console.WriteLine(circle);
            circle = new Circle(3,"red");
            Console.WriteLine(circle);
            Cylinder cylinder = new Cylinder();
            Console.WriteLine(cylinder);
            cylinder = new Cylinder(2,3,"red");
            Console.WriteLine(cylinder);
        }
    }
}