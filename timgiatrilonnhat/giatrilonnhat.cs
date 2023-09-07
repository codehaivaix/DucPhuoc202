namespace giatrilonnhat{
    class Program {
        static void Main(string[] args){
            int size;
            int[] ds;
            do {
                Console.WriteLine("Enter a size ");
                size = int.Parse(Console.ReadLine());
                if(size >20){
                    Console.WriteLine("Size should not exced 20 ");
                }
            }while(size > 20);
            ds = new int[size];
            int i = 0 ;
            while(i < ds.Length){
                Console.WriteLine("Enter element " +  (i+ 1) + " :" );
                ds[i] = int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("property List : ");
            for (int j = 0; j < ds.Length;j ++){
                Console.WriteLine(ds[j] +  "/t");
            }
            int gtln = ds[0];
            int index = 1;
            for(int j = 0 ; j < ds.Length;j++){
                if(ds[j]> gtln){
                    gtln = ds[j];
                    index = j + 1;
                }
            }
            Console.WriteLine("gia tri lon nhat la : " + gtln + " tai vi tri " + index);
        }
        
    }
}