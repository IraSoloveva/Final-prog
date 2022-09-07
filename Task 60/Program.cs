using System;

int[,,] nums = new int[2, 2, 2];



    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k=0; k<2; k++)
            {
                nums[i, j, k]= new Random().Next(10, 99);
                
            }
        }
    }


    Console.WriteLine("ТТрехмерный массив:  ");

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int l = 0; l < 2; l++)
            {
                Console.Write($"{nums[i, j, l]} ({i}, {l}, {j}) ");
                
            }
            Console.WriteLine();
        }
    }
    