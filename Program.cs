﻿namespace GPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:\Users\valen\Documents\HTX 3\Programmerign\flyvning1.csv"))
            {
                while (!reader.EndOfStream)
                {
                    //Console.WriteLine(reader.ReadLine());
                    var line = reader.ReadLine();
                    string[] values = line.Split(';');
                    int i = values.Length;
                    for(int j = 0; j < i; j++)
                    {
                        if(j ==2 || j==3)
                        {
                            Console.WriteLine(values[j]);
                        }
                        //Console.WriteLine(values[j]);
                    }
                }
            }
        }
    }
}