using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class SeachMethods
    {
        public string linearSeach (int element, int[] _array, int pos) {
            if(_array.Length == 0){
                return "Sorry, but the array is empty!";
            }else{
                if (element == _array[0]) {
                    return "The element is at the "+ pos +"° position!";
                } else {
                    _array = _array.Skip(1).ToArray(); 
                    return linearSeach(element, _array, pos + 1);
                }
            }
        }

        public int binarySearch (int element, int[] _array) {
            return 1;
        }
    }
}
