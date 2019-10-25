public class Solution {
    public int Reverse(int x) {
        int ret = 0;
        while(x != 0)
        {
            //Console.WriteLine(x);
            int nextDigit = x % 10;
            //Console.WriteLine(nextDigit);
            x = x / 10;
            //Console.WriteLine(x);

            // c# way to check for int overflow
            try
            {
                ret = checked ((ret * 10) + nextDigit);
            }
            catch(System.OverflowException)
            {
                // overflow
                return 0;
            }
            //Console.WriteLine("-----");
        }

        return ret;
    }
}