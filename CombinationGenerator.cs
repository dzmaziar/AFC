namespace AFC
{
    internal class CombinationGenerator
    {
        private int N;
        private const int K = 10;

        public CombinationGenerator(int n)
        {
            N = n;
        }

        public void SetN(int n)
        {
            N = n;
        }
        public int GetN()
        {
            return N;
        }

        public bool GenerrateCombination(int[] a)
        {
            for (int i = K - 1; i >= 0; --i)
                if (a[i] < N - K + i + 1)
                {
                    ++a[i];
                    for (int j = i + 1; j < K; ++j)
                        a[j] = a[j - 1] + 1;
                    return true;
                }
            return false;
        }
    }
}
