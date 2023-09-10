namespace demsolanxuathienchuoi{
    class Program{
       
       static void Main(string[] args)
        {
        int width = 10;
        int height = 8;
        int[,] map= new int[width,height];
        int score = 0;

        Random rd = new Random();
        int X_food = rd.Next(1,width - 1);
        int Y_food = rd.Next(1,height);
        while(X_food == 2 && Y_food == 2){
             X_food = rd.Next(1,width - 1);
             Y_food = rd.Next(1,height);
        }
        int X_originsnake = 2;
        int Y_originsnake = 2;

        int X_temp = 0;
        int Y_temp = 0;

        bool play =true;
        while(play){
            Console.SetCursorPosition(15,4);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("your score :  "+score);

            Console.SetCursorPosition(X_originsnake,Y_originsnake);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");

            Console.SetCursorPosition(X_food,Y_food);
            Console.ResetColor();   
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("0");
            
            Console.BackgroundColor=ConsoleColor.Red;
              for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write('#');
            }
            //Ve hang duoi cung
            for (int i = 1; i < width; i++)
            {
                Console.SetCursorPosition(i, height);
                Console.Write('#');
            }
            //Ve hang ben trai
            for (int i = 1; i < height + 1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('#');
            }
            for (int i = 1; i < height + 1; i++)
            {
                Console.SetCursorPosition(width - 1, i);
                Console.Write('#');
            }
            ConsoleKeyInfo player_input = Console.ReadKey();

            Console.SetCursorPosition(X_originsnake,Y_originsnake);
            Console.BackgroundColor=ConsoleColor.Black;
            Console.Write(" ");
            
            
            switch(player_input.Key){
                case ConsoleKey.RightArrow :
                X_originsnake ++;
                break;
                case ConsoleKey.LeftArrow :
                X_originsnake --;
                break;
                case ConsoleKey.DownArrow :
                Y_originsnake ++;
                break;
                case ConsoleKey.UpArrow :
                Y_originsnake --;
                break;
            }
            Console.SetCursorPosition(X_originsnake,Y_originsnake);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("");

            while(X_originsnake == X_food && Y_originsnake ==Y_food){
             Console.SetCursorPosition(X_food,Y_food);
             Console.BackgroundColor = ConsoleColor.Black;
             Console.Write("");
             X_food = rd.Next(1,width - 1);
             Y_food = rd.Next(1,height);
             score++;
            }
            if(X_originsnake > width || X_originsnake < 0 ||Y_originsnake > height || Y_originsnake < 0 ){
               Console.SetCursorPosition(15,4);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("GameOver!");
               play = false;
            }    
            }
        } 
        }
    }