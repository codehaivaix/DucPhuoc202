namespace xoaphantukhoimangpt{
    class Program{
        
        public static void Xoa(int[] mang,int x){
            for(int i = x;i<mang.Length-1;i++){
                mang[i] = mang[i] + 1;
            }       
        }
        public static void hienthi(int[] mang){
            for(int i = 0;i<mang.Length;i++){
                Console.WriteLine(mang[i]);
            }
        }
        static void Main(string[] args){
        Console.WriteLine("nhap n so nguyen cho truoc : ");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];
        Random rand = new Random();
        for(int i =0 ; i<mang.Length;i++){
            mang[i] = rand.Next()%11;
        }
        hienthi(mang);
        Console.WriteLine("nhap x phan tu can xoa : ");
        int x = int.Parse(Console.ReadLine());
        Xoa(mang,x);
        hienthi(mang);
        }
}
}