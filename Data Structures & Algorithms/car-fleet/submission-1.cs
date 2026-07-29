public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        //Speed len = position len
        int n = position.Length;
        //Monotonic increasing (Top to bottom) in order of fleets
        // slowest fleet will always be at the top
        //Store slowest car in each fleet
        Stack<float> fleets = new();
        // Sort Cars by their positions and speed according to their positons
        Array.Sort(position, speed);

        // Evaluate from closest car to dest
        for (int i = n - 1; i >= 0; i --){
            float toa = (target - position[i])/(float)speed[i];
            if (fleets.TryPeek(out float fleetToa)){
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
