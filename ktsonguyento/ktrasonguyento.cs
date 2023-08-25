namespace ktsonguyento{
    class program{
        static void Main(string[] args){
            int number;
            Console.Write("enter the number : ");
            number = int.Parse(Console.ReadLine());
            if (number < 2){
                Console.WriteLine("khong phai so nguyen to ");
            }else{
                int i = 2 ;
                bool check = true;
                while ( i <= Math.Sqrt(number)){
                    if( i % i == 0){
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check){
                    Console.WriteLine(number + "la so nguyen to");
                }else{
                    Console.WriteLine(number + "khong phai la so nguyen to");
                }
            }
        }
    }
}