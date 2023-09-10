namespace DucPhuoc{
    class Program {
            static void Main(string[] args){
                string str ;
                char a;
                Console.Write("nhap chuoi ky tu :");
                str = Console.ReadLine();
                Console.WriteLine("nhap ky tu can xoa :");
                a =  char.Parse(Console.ReadLine());
                Console.Write(count(str,a));
            }
            static int count(string str , char a){
                int count = 0;
                for(int i = 0;i < str.Length;i++){
                    if(str[i] == a){
                        count ++;
                    }
                }
                return count;
            }
    }
}