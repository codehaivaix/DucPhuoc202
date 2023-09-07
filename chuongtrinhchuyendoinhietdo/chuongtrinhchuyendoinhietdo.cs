namespace chuongtrinhchuyendoinhietdo{
    class Program{
        public static double CToF(double C){
            double F = (9.0/5) * C +32;
            return F;
            }
        public static double FToC(double F){
            double C = (5.0 / 9 )*(F - 32);
            return C;
        }
        static void Main(string[] args){
            int choice;
            double C;
            double F;
            do {
                Console.WriteLine("Menu");
                Console.WriteLine("1 . Fahrenheit to celsius");
                Console.WriteLine("2 . celisius to fahrenheit");
                Console.Write("moi nhap lua chon : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice){
                    case 1:
                    Console.WriteLine("enter F :");
                    F = double.Parse(Console.ReadLine());
                    Console.WriteLine("F to C :" + FToC(F));
                     break;
                    case 2:
                    Console.WriteLine("enter F :");
                    C = double.Parse(Console.ReadLine());
                    Console.WriteLine("C to F :" + CToF(C));
                     break;
                    default :
                    Console.Write("Loi !");
                    break;
                }
            }while(choice != 0);
        }
    }
}
