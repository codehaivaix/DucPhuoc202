namespace sudungtoantu{
    class Program{
        static void Main(string[] args){
            float width;
            float height;
            Console.WriteLine("enter width : ");
            width = float.Parse(Console.ReadLine());
            Console.WriteLine("enter height : ");
            height = float.Parse(Console.ReadLine());
            float area = width * height ;
            Console.WriteLine("khu vuc la : " + area);
        }
    }
}