namespace themphantuvaomang{
    class Program{
        static void Main(string[] args){
        int[] mang = {10,4,6,7,8};
        Console.Write("nhap gia tri can chen : ");
        int X = int.Parse(Console.ReadLine());
        Console.Write("nhap vi tri can chen trong mang : ");
        int index = int.Parse(Console.ReadLine());
        if(index <= 1 && index >= mang.Length - 1){
            Console.WriteLine("Khong chen vao duoc !");
        }else{
            mang[index] = X; 
        }
        for(int i=0; i < mang.Length ; i++){
            Console.WriteLine(mang[i]);
        }
    }
}
}