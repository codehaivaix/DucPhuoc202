namespace thietke{
    class program{
        static void Main(string[] args){
            int choice;
            do{
                Console.WriteLine("Menu");
                Console.WriteLine("1.Draw triangle");
                Console.WriteLine("2.Draw square");
                Console.WriteLine("3.Draw rectangle");
                Console.WriteLine("4.exit");
                Console.Write("enter your choice : ");
                choice = int.Parse(Console.ReadLine());
                switch(choice){
                    case 1 :
                    Console.WriteLine("Draw the triangle : ");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");
                    break;
                    case  2 :
                    Console.WriteLine("Draw the square : ");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    break;
                    case  3 : 
                    Console.WriteLine("Draw the rectangle :");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    break;
                    default : 
                    Console.WriteLine("No choice !");
                    break;
                }
            }while(choice !=  4);
        }
    }
}