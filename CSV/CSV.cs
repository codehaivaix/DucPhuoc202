
using System.IO;
namespace DucPhuoc
{  
    class Program{
        static void Main(string[] args){
        string filePath = "test.csv";
        string filePath2 = "output.txt";
        StreamReader reader = new StreamReader(filePath);
        StreamWriter write = new StreamWriter(filePath2);
        string line = "";
        while((line = reader.ReadLine()) !=null){
            string[] read_test = line.Split(',');
            for(int i = 1;i < read_test[5].Length - 1;i++ ){
                write.Write(read_test[5][i]);
            }
            write.WriteLine("");
        }      
        reader.Close();
        write.Close();
        }
    }
}