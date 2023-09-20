namespace DucPhuoc{
    class Program{
        public class student{
            private int rollno;
            private string name;
            private static string college = "BBDT";
            public student(int r, string n){
                rollno = r;
                name = n;
            }
            public static void Change(){
                college = "CODEGYM";
            }
            public void display(){
            Console.WriteLine(rollno+ " " + name + " " +college);
            }
        }

        static void Main(string[] args){
            student.Change();
            student s1 = new student(111,"hoang");
            student s2 = new student(222,"khanh");
            student s3 = new student(333,"nam");
            s1.display();
            s2.display();
            s3.display();        
            }
    }
}