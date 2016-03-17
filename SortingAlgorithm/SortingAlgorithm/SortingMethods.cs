using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class SortingMethods
    {
        public void bubbleSort (int[] _array) {
            for (int i = 0; i < _array.Length; i++) {
                for (int j = i + 1; j < _array.Length; j++) {
                    if (_array[i] > _array[j]) {
                        int temp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = temp;
                    }
                }
            }
        }
    }
}
