namespace timphantulonnhat{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("moiw nhap vao so dong cua ma tran :");
            int dong = int.Parse(Console.ReadLine());
            Console.WriteLine("moiw nhap vao so cot cua ma tran :");
            int cot = int.Parse(Console.ReadLine());
            int[,] matrix = new int[dong,cot];
            for (int row = 0;row < matrix.GetLength(0);row++){
                for(int column = 0;column < matrix.GetLength(1);column ++){
                    Console.WriteLine("nhap gai tri phan tu :");
                    matrix[row,column] = int.Parse(Console.ReadLine());
                }
            }
           /* Random rand = new Random();
            for (int row = 0;row < matrix.GetLength(0);row++){
                for(int column = 0;column < matrix.GetLength(1);column ++){
                    matrix[row,column] = rand.Next() %11;
                }
            }*/
            for (int row = 0;row < matrix.GetLength(0);row++){
                for(int column = 0;column < matrix.GetLength(1);column ++){
                    Console.Write(matrix[row,column]+" ");
                }
            }
            int max = 0;
            for (int row = 0;row < matrix.GetLength(0);row++){
                for(int column = 0;column < matrix.GetLength(1);column ++){
                    if(matrix[row,column] > max){
                        max = matrix[row,column];
                    }
                }
            }
            Console.WriteLine("gia tri lon nhat la` : " + max);
        }
    }
}