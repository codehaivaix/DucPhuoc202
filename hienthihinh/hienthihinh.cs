namespace hienthihinh
{
    class program{
        static void Main(string [] args){
            int choice;
            do{
                Console.WriteLine("");
                Console.WriteLine(" Menu");
                Console.WriteLine("1. in hinh chu nhat");
                Console.WriteLine("2. in hinh tam giac vuong");
                Console.WriteLine("3. in hinh tam giac ");
                Console.WriteLine("4. exit");
                Console.Write("enter your choice : ");
                choice = int.Parse(Console.ReadLine());
                switch(choice){
                    case 1 : 
                        Console.Write("nhap chieu dai : ");
                        int dai = int.Parse(Console.ReadLine());
                        int rong = int.Parse(Console.ReadLine());
                        for(int i = 1; i<=dai;i++){
                            Console.WriteLine("*");
                            for(int j = 1; j <= rong;j++){
                                Console.Write("*");
                            }
                        
                        }
                        break;   
                    case 2 :
                        Console.Write("nhap chieu dai : ");
                        dai = int.Parse(Console.ReadLine());
                        for(int i = 1 ; i<dai;i++){
                            Console.WriteLine("*");
                            for(int j  = 1; j <= i+1;j++){
                                Console.Write("*");
                            }
                        }
                        break;     
                    case 3 :
                        
                    case 4 :
                        Console.WriteLine("Thoat");
                        break;
                    default :
                        Console.WriteLine("moi ban nhap lai .");
                        break;
                }
            }while(choice !=4 );
            
        }
    } 
}