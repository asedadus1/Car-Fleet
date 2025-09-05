public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        SortedDictionary<int, double> finishT = new SortedDictionary<int, double>();
        for(int i = 0; i < speed.Length; i++){
            int p = position[i];
            int s = speed[i];
            double Ftime = (double)(target-p)/s;
            finishT.Add( (p* -1 ), Ftime);
        }

        int ans = 0;
        double finishTime = (double)Int32.MinValue;
        foreach(var temp in finishT){
            if(finishTime < temp.Value){
                Console.WriteLine($"{temp.Key} {temp.Value}");
                finishTime = temp.Value;
                ans++;
            }
        }
        return ans;
    }
}
