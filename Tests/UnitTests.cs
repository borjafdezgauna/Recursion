namespace Tests
{
    public class UnitTests
    {
        [Fact]
        public void FactorialTests()
        {
            Assert.Equal(1, Recursion.Exercises.Factorial(1));
            Assert.Equal(2, Recursion.Exercises.Factorial(2));
            Assert.Equal(6, Recursion.Exercises.Factorial(3));
            Assert.Equal(24, Recursion.Exercises.Factorial(4));

            Assert.Equal(1, Recursion.Exercises.Factorial(0));

            Assert.Equal(0, Recursion.Exercises.Factorial(-1));
        }

        [Fact]
        public void FibonacciTests()
        {
            Assert.Equal(1, Recursion.Exercises.Fibonacci(1));
            Assert.Equal(1, Recursion.Exercises.Fibonacci(2));
            Assert.Equal(2, Recursion.Exercises.Fibonacci(3));
            Assert.Equal(3, Recursion.Exercises.Fibonacci(4));
            Assert.Equal(5, Recursion.Exercises.Fibonacci(5));
            Assert.Equal(8, Recursion.Exercises.Fibonacci(6));
            Assert.Equal(13, Recursion.Exercises.Fibonacci(7));

            Assert.Equal(0, Recursion.Exercises.Fibonacci(0));

            Assert.Equal(0, Recursion.Exercises.Fibonacci(-1));
        }

        [Fact]
        public void SumTests()
        {
            int[] array = new int[] { 1, 2, 4, 0, 10, 3 };
            Assert.Equal(20, Recursion.Exercises.Sum(array));

            array = new int [] { 1, 2, 4, 0, -10, 3 };
            Assert.Equal(0, Recursion.Exercises.Sum(array));

            array = new int[] { };
            Assert.Equal(0, Recursion.Exercises.Sum(array));
        }

        [Fact]
        public void MaxTests()
        {
            int[] array = new int[] { 1, 2, 4, 0, 10, 3 };
            Assert.Equal(10, Recursion.Exercises.Max(array));

            array = new int[] { 1, 2, 4, 0, -10, 3 };
            Assert.Equal(4, Recursion.Exercises.Max(array));

            array = new int[] { };
            Assert.Equal(0, Recursion.Exercises.Max(array));
        }
    }
}