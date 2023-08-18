namespace ChuyenDoiTienTe{
    class Program{
        static void Main(string[] args){
            float rate = 23000;
            Console.Write("Dien vao USD : ");
            float usd = float.Parse(Console.ReadLine());
            float vnd = usd * rate ;
            Console.Write("VND : " + vnd);
        }
    }
}