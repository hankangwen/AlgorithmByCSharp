using System;

namespace Algorithm
{
    public abstract class BaseClass
    {
        protected BaseClass()
        {
            Start();
        }

        protected abstract void Start();

        protected void Print<T>(T result)
        {
            Console.WriteLine(result);
        }
        
        protected void Print(int[] result)
        {
            Console.Write("[ ");
            for (int i = 0; i < result.Length - 1; i++)
            {
                Console.Write(result[i] + ", ");
            }
            Console.WriteLine("{0} ]", result[result.Length-1]);
        }
    }
}