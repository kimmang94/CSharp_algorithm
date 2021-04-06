using System;

namespace CSharp
{
    class Program
    { 
        public int Add4(int N)
        {
            int sum = 0;

            for (int i = 0; i < N; i++)
                sum += i;

            for (int i = 0; i < 2 * N; i++)
                for (int j = 0; j < 2 * N; j++)
                    sum += 1;

            sum += 1234567;

            return sum;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
