public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        //Speed len = position len
        int n = position.Length;
        //Monotonic increasing (Bottom to top) in order of fleets' toa(s)
        // slowest fleet ahead will always be at the top
        //Store slowest car in each fleet
        Stack<double> fleets = new();
        // Sort Cars by their positions and speed according to their positons
        Array.Sort(position, speed);

        // Evaluate from closest car to dest
        for (int i = n - 1; i >= 0; i --){
            double toa = (target - position[i])/(double)speed[i];
            if (fleets.TryPeek(out double fleetToa)){
                // does incoming car arrive faster or the same time as slowest fleet
                if (toa <= fleetToa){
                    // faster or same? join the slowest fleet
                    continue;
                }
            }
            // no fleet available or toa slower than slowest fleet?
            // form a new
            fleets.Push(toa);
        }

        return fleets.Count;
    }
}
