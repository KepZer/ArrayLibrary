using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ArrayParity
{
    public int CalcParity(Array array)
    {
        int res = 0;
        foreach(int num in array)
        {
            if (num % 2 == 0) res++;
        }
        return res;
    }
}
