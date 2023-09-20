namespace DucPhuoc{
    class Program{
        public class Fan{
            public const int slow = 1;
            public const int medium = 2;
            public const int fast = 3;
            private int speed {get ; set;}
            private bool on {get ; set ;}
            private double radius {get ; set;}
            private string color {get ; set;}
            public void FanDefault(){
                this.on = false;
                this.speed = slow;
                this.radius = 5 ;
                this.color = "blue";  
            }
            public void Fan1(){
                this.on = true;
                this.speed = fast;
                this.radius = 10 ;
                this.color = "yellow";  
            }
            public void Fan2(){
                this.on = true;
                this.speed = medium;
                this.radius = 5 ;
                this.color = "blue";  
            }
            public void toString(){
                if(on == true){
                    Console.WriteLine("speed : "+speed);
                    Console.WriteLine("radius : "+radius);
                    Console.WriteLine("color : "+color);
                }else{
                    Console.WriteLine("Fan is off");
                }
            }
           
        }
        static void Main(string[]args){
            Fan f = new Fan();
            Console.WriteLine("chose option : ");
            int chose = int.Parse(Console.ReadLine());
            switch(chose){
                case 1 :
                f.Fan1();
                f.toString();
                break;
                case 2:
                f.Fan2();
                f.toString();    
                break;
                default:
                f.FanDefault();
                f.toString();
                break;
            }
        }
    }
}