public class Kata
{
    public static long FindNextSquare(long num){
        long sqRt = (long)System.Math.Sqrt(num);
        if(sqRt * sqRt == num)
        {
            long nxtSq = sqRt += 1;
            return nxtSq * nxtSq;
        }
        return -1;
    }
}