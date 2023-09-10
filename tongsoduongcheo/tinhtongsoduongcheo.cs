namespace tinhtongduongcheo{
    class Program{
        static void Main(string[] args){
        Console.WriteLine("nhap vao ma tran vuong : ");
        int matran = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matran,matran];
        /*Random rand = new Random();
        for(int i = 0 ;i < matrix.GetLength(0);i++){
            for(int j =0;j < matrix.GetLength(1);j++){
                Console.Write(matrix[i,j]+" ");
                }
            }*/
        for(int i = 0 ;i < matrix.GetLength(0);i++){
            for(int j =0;j < matrix.GetLength(1);j++){
                Console.Write("Moi nhap phan tu " +i);
                matrix[i,j] = int.Parse(Console.ReadLine());
                }
                }
        int total = 0;
        for(int i = 0 ;i < matrix.GetLength(0);i++){
            for(int j =0;j < matrix.GetLength(1);j++){
                if(i == j){
                   total += matrix[i,j];
                   Console.WriteLine(total);
                }
                }
            }        
        }
        }
    }
