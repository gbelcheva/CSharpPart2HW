using System;

public class Statistics
{
    public void PrintStatistics(double[] dataArray, int numberOfElements)
    {
        double maxElement;

        for (int i = 0; i < numberOfElements; i++)
        {
            if (dataArray[i] > maxElement)
            {
                maxElement = dataArray[i];
            }
        }

        PrintMax(maxElement);

        maxElement = 0;

        for (int i = 0; i < numberOfElements; i++)
        {
            if (dataArray[i] < maxElement)
            {
                maxElement = dataArray[i];
            }
        }

        PrintMin(maxElement);

        double sum = 0;

        for (int i = 0; i < numberOfElements; i++)
        {
            sum += dataArray[i];
        }

        PrintAvg(sum / numberOfElements);
    }
}
