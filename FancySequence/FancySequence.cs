public class Fancy
{

    private const long MOD = 1_000_000_007;

    private List<long> arr = new List<long>();
    private long mul = 1;
    private long add = 0;

    public Fancy() { }

    public void Append(int val)
    {
        long invMul = ModInverse(mul);
        long original = ((val - add) % MOD + MOD) % MOD;
        original = (original * invMul) % MOD;

        arr.Add(original);
    }

    public void AddAll(int inc)
    {
        add = (add + inc) % MOD;
    }

    public void MultAll(int m)
    {
        mul = (mul * m) % MOD;
        add = (add * m) % MOD;
    }

    public int GetIndex(int idx)
    {
        if (idx >= arr.Count) return -1;

        long val = (arr[idx] * mul % MOD + add) % MOD;
        return (int)val;
    }

    private long ModInverse(long x)
    {
        return ModPow(x, MOD - 2);
    }

    private long ModPow(long baseVal, long exp)
    {
        long result = 1;

        while (exp > 0)
        {
            if ((exp & 1) == 1)
                result = (result * baseVal) % MOD;

            baseVal = (baseVal * baseVal) % MOD;
            exp >>= 1;
        }

        return result;
    }
}