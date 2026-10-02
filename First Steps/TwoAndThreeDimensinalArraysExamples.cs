namespace First_Steps
{
    internal class TwoAndThreeDimensinalArraysExamples
    {
        public static void Run()
        {
            // Two-dimensional array example
            int[,] twoDimensionalArray = new int[3, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };
            Console.WriteLine("Two-Dimensional Array:");
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    Console.Write(twoDimensionalArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Three-dimensional array example
            int[,,] threeDimensionalArray = new int[2, 3, 4]
            {
                {
                    { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 9, 10, 11, 12 }
                },
                {
                    { 13, 14, 15, 16 },
                    { 17, 18, 19, 20 },
                    { 21, 22, 23, 24 }
                }
            };
            Console.WriteLine("\nThree-Dimensional Array:");
            for (int i = 0; i < threeDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < threeDimensionalArray.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDimensionalArray.GetLength(2); k++)
                    {
                        Console.Write(threeDimensionalArray[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            //Usage of Two-Dimensional Arrays:
            int[,] matrixA = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] matrixB = new int[3, 2] { { 7, 8 }, { 9, 10 }, { 11, 12 } };

            Console.WriteLine(matrixA[0, 0]); // 1
            Console.WriteLine(matrixA[0, 2]); // 3
            Console.WriteLine(matrixA[1, 1]); // 5

            matrixA[1, 2] = 100;

            Console.WriteLine(matrixA[1, 2]); // 100

            for (int row = 0; row < matrixA.GetLength(0); row++)
            {
                for (int col = 0; col < matrixA.GetLength(1); col++)
                {
                    Console.Write(matrixA[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
