using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int a, int b){ 
            return a + b;
        }
        public int Subtract(int a, int b){
            return a - b;
        }
        public int Multiply(int a, int b){
            return a * b;
        }
        public int Divide(int a, int b){
            return a / b;
        }
        public int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        public bool CheckPrime(int n)
        {
            for (int i = 2; i < n; i++){
                if (n % i == 0){
                    return false;
                }
            }
            return true;
        }

        public bool EquationBalanced(string equation){
            return true;
        }
    }
}