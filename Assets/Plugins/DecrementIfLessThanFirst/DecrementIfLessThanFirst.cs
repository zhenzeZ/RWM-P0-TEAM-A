using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecrementIfLessThanFirst
{
    public static int decrement(int num)
    {
        return num - 1; 
    }

    public static int[] answerList(int[] numList)
    {
        int[] result = new int[numList.Length];
        for (int i = 0; i < numList.Length ; i++)
        {
            if (numList[0] > numList[i])
            {
                result[i] = decrement(numList[i]);
            }
            else
            {
                result[i] = numList[i];
            }
        }

        return result;
    }
}

public class ModuloFirst
{
    public static int modulo(int first, int num)
    {
        return num % first;
    }

    public static int[] answerList(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = modulo(xs[0], xs[i]);
        }
        return result;
    }

}

public class CubeFilter
{
    public static int cube(int x)
    {
        return x * x * x;
    }

    public static int[] cubes(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = cube(xs[i]);
        }
        return result;
    }

}