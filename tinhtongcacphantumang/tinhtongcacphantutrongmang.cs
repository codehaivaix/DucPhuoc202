namespace tinhtongcacphantutrongmang{
    class Program{
        static void Main(string[] args){
            int[] number = new int [5];
            number[0]=2;
            number[1]=5;
            number[2]=9;
            number[3]=6;
            number[4]=7;
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);
            int total = 0;
            for(int i = 0;i < number.Length;i++){
                total = total + number[i];
            }
            Console.WriteLine(total.ToString());
        }
    }
}