namespace tinhcannang{
    class program{
        static void Main(string[] atgs){
            double height,weight;
            Console.WriteLine("enter height :");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("enter weight : ");
            weight = float.Parse(Console.ReadLine());
            double bmi = weight / Math.Pow(height,2);
            bmi = Math.Round(bmi,1);
            Console.WriteLine("BMI : "+bmi);
            if(bmi < 18){
                Console.WriteLine("under weight");
            }else if(bmi<25.0){
                Console.WriteLine("normal");
            }else if(bmi < 30.0){
                Console.WriteLine("Over weight");
            }else {
                Console.WriteLine("Obse");
            }
        }
    }
}