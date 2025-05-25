using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BinarySearch
{
    internal static class Binarysearch
    {
       
        internal static int GetBinarySearch(int[] binarySearch, int target)
        {
              int left = 0;
              int right = binarySearch.Length - 1;

              while (left <= right)
              {
                  int mid = left + (right - left) / 2;

                  if (binarySearch[mid] == target)
                      return mid;

                  if (binarySearch[mid] < target)
                      left = mid + 1;
                  else
                      right = mid - 1;
              }
              return -1; 
        }









        
        
        
    }
}
