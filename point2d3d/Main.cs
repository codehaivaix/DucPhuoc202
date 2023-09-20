namespace DucPhuoc{
    class Program{
        static void Main(string[] args){
           Point2D point2D = new Point2D();
           Console.WriteLine(point2D);
           point2D = new Point2D(5,10);
           Console.WriteLine(point2D);
           Point3D point3D = new Point3D();
           Console.WriteLine(point3D);
           point3D = new Point3D(3,5,10);
           Console.WriteLine(point3D);
        }
    }
}