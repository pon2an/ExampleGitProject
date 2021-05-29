using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            string imgData = @"TextFile1.txt";
            double[,] ImageDataFromFile = ReadImageDataFromFile(imgData);
            string Convolution = @"TextFile2.txt";
            double[,] ConvolutionDataFromFile = ReadImageDataFromFile(Convolution);

            double[,] InputArray = new double[7, 7];

            for (int i = 1; i <= ImageDataFromFile.GetLength(0); i++)
            {for (int j = 1; j <= ImageDataFromFile.GetLength(1); j++)
             {InputArray[i, j] = ImageDataFromFile[i - 1, j - 1];}}

            for (int i = 0; i < 7; i++)
            {for (int j = 0; j < 7; j++)
                {if (i == 6 && j == 1 || i == 6 && j == 6 || i == 1 && j == 6)
                       {InputArray[i, j] = InputArray[1, 1];}
                 if (i == 1 && j == 0 || i == 6 && j == 0 || i == 6 && j == 5)
                       {InputArray[i, j] = InputArray[1, 5];}
                 if (i == 5 && j == 6 || i == 0 && j == 1 || i == 0 && j == 6)
                       {InputArray[i, j] = InputArray[5, 1];}
                 if (i == 5 && j == 0 || i == 0 && j == 5 || i == 0 && j == 0)
                       {InputArray[i, j] = InputArray[5, 5];}

                 if (i == 0)
                    {for (int x = 2; x < 5; x++)
                        {InputArray[i, x] = InputArray[5, x];}}
                    if (i == 6)
                    {for (int x = 2; x < 5; x++)
                        {InputArray[i, x] = InputArray[1, x];}}
                    if (j == 0)
                    {for (int x = 2; x < 5; x++)
                        {InputArray[x, j] = InputArray[x, 5];}}
                    if (j == 6)
                    {for (int x = 2; x < 5; x++)
                        {InputArray[x, j] = InputArray[x, 1];}}}
            }

            double[,] convolution = new double[5, 5];
            int A = 0;
            for (int i = 0; i < 5; i++)
            {int M = 0;
                for (int j = 0; j < 5; j++)
                {int I = 0;
                    for (int x = 0 + A; x < 3 + A; x++) 
                    {int U = 0;
                        for (int N = 0 + M; N < 3 + M; N++) 
                        {convolution[i, j] += InputArray[A, N] * ConvolutionDataFromFile[I, U];
                            U++;}I++;}M++;}A++;}

            string output = @"TextFile3.txt";
            WriteImageDataToFile(output, convolution);
        }
        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }
        static void WriteImageDataToFile(string imageDataFilePath,
                                         double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i,
                                                imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }

            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }
    }
}

