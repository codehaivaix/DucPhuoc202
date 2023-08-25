namespace docso{
    class Program{
        static void Main(string[] args){
            Console.Write("nhap so can doc : ");
            int number = int.Parse(Console.ReadLine());
            if(number < 10 && number >= 0){
                switch(number){
                    case 0 :
                        Console.Write("zero");
                        break;
                    case 1 :
                        Console.Write("one");
                        break;
                    case 2 :
                        Console.Write("two");
                        break;
                    case 3 :
                        Console.Write("three");
                        break;
                    case 4 :
                        Console.Write("four");
                        break;
                    case 5 :
                        Console.Write("five");
                        break;
                    case 6 :
                        Console.Write("six");
                        break;
                    case 7 :
                        Console.Write("seven");
                        break;
                    case 8 :
                        Console.Write("eight");
                        break;
                    case 9 :
                        Console.Write("nine");
                        break;
                    case 10 :
                        Console.Write("ten");
                        break;
                }
            }else if(number > 10 && number <20){
               int number2= number-10;
               switch(number2){
                case 1 :
                    Console.WriteLine("eleven");
                    break;
                case 2 :
                    Console.WriteLine("twelve");
                    break;
                case 3 :
                    Console.WriteLine("thirteen");
                    break;
                case 4 :
                    Console.WriteLine("fourteen");
                    break;
                case 5 :
                    Console.WriteLine("fifteen");
                    break;
                case 6 :
                    Console.WriteLine("sixteen");
                    break;
                case 7 :
                    Console.WriteLine("seventeen");
                    break;
                case 8 :
                    Console.WriteLine("eighteen");
                    break;
                 case 9 :
                    Console.WriteLine("nineteen");
                    break;
               }
             }else if(number >=20 && number <100 ){
                int x,y;
                x = number/10;
                y = number%10;
                    switch(number/10){
                        case 2 :
                            Console.Write("twenty");
                            break;
                        case 3 :
                            Console.Write("thirty");
                            break;
                        case 4 :
                            Console.Write("forty");
                            break;
                        case 5 :
                            Console.Write("fifty");
                            break;
                        case 6 :
                            Console.Write("sixty");
                            break;
                        case 7 :
                            Console.Write("seventies");
                            break;
                        case 8 :
                            Console.Write("eighty");
                            break;
                        case 9 :
                            Console.Write("ninety");
                        break;
                    }
                    switch(y){
                        case 0 :
                            Console.Write("");
                        break;
                        case 1 :
                            Console.Write(" one");
                        break;
                        case 2 :
                            Console.Write(" two");
                        break;
                        case 3 :
                            Console.Write(" three");
                        break;
                        case 4 :
                            Console.Write(" four");
                        break;
                        case 5 :
                            Console.Write(" five");
                        break;
                        case 6 :
                            Console.Write(" six");
                        break;
                        case 7 :
                            Console.Write(" seven");
                        break;
                        case 8 :
                            Console.Write(" eight");
                        break;
                        case 9 :
                            Console.Write(" nine");
                        break;
                }
             }else if(number >= 100 && number <1000)
                {
                    int x,y,z;
                    z = number/100;
                    x = number%100/10;
                    y = number%100%10;
                    switch(z){
                        case 1 :
                            Console.Write(" one" + "hundred");
                            break;
                        case 2 :
                            Console.Write(" two" + "hundred");
                            break;
                        case 3 :
                            Console.Write(" three" + "hundred");
                            break;
                        case 4 :
                            Console.Write(" four" + "hundred");
                            break;
                        case 5 :
                            Console.Write(" five" + "hundred");
                            break;
                        case 6 :
                            Console.Write(" six" + "hundred");
                            break;
                        case 7 :
                            Console.Write(" seven" + "hundred");
                            break;
                        case 8 :
                            Console.Write(" eight" + "hundred");
                            break;
                        case 9 :
                            Console.Write(" nine" + "hundred");
                            break;
                    }
                    switch(x){
                        case 0 :
                            Console.Write("");
                            break;
                        case 1 :
                            Console.Write(" ten");
                            break;
                        case 2 :
                            Console.Write(" twenty");
                            break;
                        case 3 :
                            Console.Write(" thirty");
                            break;
                        case 4 :
                            Console.Write(" forty");
                            break;
                        case 5 :
                            Console.Write(" fifty");
                            break;
                        case 6 :
                            Console.Write(" sixty");
                            break;
                        case 7 :
                            Console.Write(" seventies");
                            break;
                        case 8 :
                            Console.Write(" eighty");
                            break;
                        case 9 :
                            Console.Write(" ninety");
                        break;
                    }
                    switch(y){
                        case 0 :
                            Console.Write("");
                        break;
                        case 1 :
                            Console.Write(" one");
                        break;
                        case 2 :
                            Console.Write(" two");
                        break;
                        case 3 :
                            Console.Write(" three");
                        break;
                        case 4 :
                            Console.Write(" four");
                        break;
                        case 5 :
                            Console.Write(" five");
                        break;
                        case 6 :
                            Console.Write(" six");
                        break;
                        case 7 :
                            Console.Write(" seven");
                        break;
                        case 8 :
                            Console.Write(" eight");
                        break;
                        case 9 :
                            Console.Write(" nine");
                        break;
                }

                }
            }
            }

        }
