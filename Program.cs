static bool CanPlantFlower(int[] FlowerBed, int n)
{
    for (int i = 0; i < FlowerBed.Length && n > 0; i++)
    {
        if (FlowerBed[i] == 0)
        {
            bool LeftEmpty = (i == 0) || (FlowerBed[i - 1] == 0);
            bool RightEmpty = (i == 0) || (FlowerBed[i + 1] == 0);

            if (LeftEmpty && RightEmpty)
            {
                FlowerBed[i] = 1;
                n--;
                i++;
            }
            
        }
    }
    return n == 0;
}

int[] FlowerBed = { 1, 0, 0, 0, 1 };

Console.Write("Please input the number of flowers you would like to plant: ");
int n = Convert.ToInt32(Console.ReadLine());
bool result = CanPlantFlower(FlowerBed, n);
Console.WriteLine($"Can you plant {n} flower(s)? {result}");







