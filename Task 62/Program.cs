

int[,] nums = new int[4, 4];


int i = 0;
int j = 0;
int k = 0;

while (k <= 16)
{
    nums[i, j] = k;
    if (i <= j + 1 && i + j < 3)
    {
        j++;
    }
    else
    {
        if (i < j && i + j >= 3)
        {
            i++;
        }
        else
        {
            if (i >= j && i + j > 3)
            {
                j--;
            }
            else
                i--;
        }
    }
    k++;
} 
        Console.WriteLine("Матрица заполненная по спирали: ");

        for (int m = 0; m < 4; m++)
        {
            for (int l = 0; l < 4; l++)
            {
                Console.Write($"{nums[m, l]} ");
            }
            Console.WriteLine();
        }

