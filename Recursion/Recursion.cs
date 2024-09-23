namespace Recursion
{
    public static class Exercises
    {
        public static int Factorial(int n)
        {
            //TODO #1 : Calculate the factorial of n using recursion
            return 0;
        }

        public static int Fibonacci(int n)
        {
            //TODO #2 : Calculate the n-th term of the Fibonacci series using recursion
            //https://es.wikipedia.org/wiki/Sucesi%C3%B3n_de_Fibonacci
            return 0;
        }

        private static int Sum(int [] A, int start, int end)
        {
            //TODO #3 : Calculate the sum of the elements in A[start,end]
            return 0;
        }

        public static int Sum(int[] A)
        {
            return Sum(A, 0, A.Length - 1);
        }

        private static int Max(int[] A, int start, int end)
        {
            //TODO #4 : Calculate the maximum of the elements in A[start,end]
            return 0;
        }

        public static int Max(int[] A)
        {
            return Max(A, 0, A.Length - 1);
        }
    }
}
