using System.IO;
namespace DucPhuoc{
    class Program{
        static void Main(){
            string filePath = "test.txt";
            StreamWriter writer = new StreamWriter(filePath);
            string[] title = {"A" , "B" , "C"};

            foreach(string letter in title){
                writer.WriteLine(title);
            }
            writer.Close();
        }
    }
}