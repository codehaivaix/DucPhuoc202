namespace  timphantulonnhattrongmang2chieu
{
    class Program{
        static void Main(string[] args){
            int[,] matrix = new int[2,2];
            Console.Write("Enter "+ matrix.GetLength(0) +"row and " + matrix.GetLength(1) + "colums" );
            for(int row = 0 ; row < matrix.GetLength(0); row++){
                for(int column = 0;column < matrix.GetLength(1);column++){
                    matrix[row , column]= int.Parse(Console.ReadLine());
                }
            }
            for(int row = 0;row < matrix.GetLength(0);row++ ){
                for(int column = 0;column < matrix.GetLength(1);column++){
                    Console.Write(matrix[row, column] + " ");
                }
            }
        }
    }
    }