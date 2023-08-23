namespace phuongtrinhbac1{
    class program{
        static void Main(string[] args){
            double a,b;
            Console.WriteLine("giai phuong trinh a*x + b = 0");
            Console.WriteLine("moi nhap a : ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("moi nhap b :");
            b= double.Parse(Console.ReadLine());
            if(a!=0){
                double nghiem = -b/a;
                Console.WriteLine("phuong trinh co nghiem : 0 va" +nghiem);
            }
            else{
                if(b == 0){
                    Console.WriteLine("phuong trinh vo so nghiem");
                }
                else {
                    Console.WriteLine("phuong trinh vo nghiem");
                }
            }
        }
    }
}