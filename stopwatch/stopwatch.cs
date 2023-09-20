namespace DucPhuoc{
    class Program{
        public class StopWatch{
          private DateTime startime = DateTime.Now;
          private DateTime endtime;
            public StopWatch(){

            }
            public DateTime GetStarTime(){
                return startime;
            }
            public DateTime GetEndTime(){
                return endtime;
            }
            public void Star(){
                startime = DateTime.Now;
            }
            public void Stop(){
                endtime = DateTime.Now;
            }
            public TimeSpan GetElapsedTime(){
                TimeSpan timePassed = endtime - startime;
                return timePassed;
            }
        }
            public static int[] SelectionSort(int[] array){
                for(int i = 0 ;i < array.Length;i++){
                    int minIndex = i;
                    for(int j = i;i < array.Length;j++ ){
                        if(array[j]<array[minIndex]){
                            minIndex=j;
                        }
                    }
                    int temp =array[i];
                    array[i]=array[minIndex];
                    array[minIndex] = temp;
                }
                return array;
            }
              static void Main(string[] args){
                int[] array = new int[100000];
                Random rd = new Random();
                StopWatch st = new StopWatch();
                for(int i = 0;i<array.Length;i++){
                    array[i]= rd.Next(0,1000);
                } 
                Console.WriteLine("thoi gian bat dau : "+st.GetStarTime());
                SelectionSort(array);
                Console.WriteLine("thoi gian ket thuc : "+st.GetEndTime());
                Console.WriteLine("thoi gian cho : "+st.GetElapsedTime());
            }
    }
}
       