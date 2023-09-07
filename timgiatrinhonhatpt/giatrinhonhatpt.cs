namespace giatrinhonhatpt{
    class Program{
        public static int MinValue(int []array){
            int Min = array[0];
            int index = 0;
            for(int i =0 ;i < array.Length;i++){
                if(array[i] < Min){
                    Min = array[i];
                    index = i;
                }
            }
            return index;
        }
        static void Main(string[] args){
            int []arr = {4,12,7,8,1,6,9};
            int index = MinValue(arr);
            Console.WriteLine("The samllest elements in the array is :" + array[index]);
        }
    }
}