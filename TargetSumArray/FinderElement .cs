namespace TargetSumArray;

public class FinderElement
{
    public static string Search(int[] originalMass, int target)
    {
        if(originalMass.Length <= 1)
        {
            return "the length of the array cannot be less than 2";
        }

        var answer = new int[2];

        for (int i = 0; i < originalMass.Length; i++)
        {
            for (int j = 0; j < originalMass.Length; j++)
            {
                if (originalMass[i] + originalMass[j] == target && i != j)
                {
                    answer[0] = i;
                    answer[1] = j;
                    return string.Join(" ", answer); ;
                }
            }
        }
        return "no indexes found";
    }
}