namespace timgiatritrongmang
{
    class Program{
        static void Main(string[] args){
            string[] studen = {"Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};
            Console.Write("Enter a name's student : ");
            string input_name = Console.ReadLine();
            bool isExist = false;
            for(int i = 0 ;i< studen.Length; i++){
                if(studen[i].Equals(input_name)){
                    Console.WriteLine("Position of the student in the list " + input_name + "is " + (i+1));
                    isExist = true;
                    break;
                }
            }
        if (!isExist){
            Console.WriteLine("not found !" + input_name + "in the list");
        }
        }
    }
}