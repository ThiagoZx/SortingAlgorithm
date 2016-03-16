using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithm
{
    public partial class Form1 : Form
    {

        static int size = 10;
        Random r = new Random ();
        Stopwatch elapsed = new Stopwatch();
        int[] array;

        public Form1 () {
            InitializeComponent ();
        }

        void fillArray (int _size) {
            array = new int[size];
            for (int i = 0; i < _size; i++) {
                array[i] = r.Next (size);
            }
        }

        void printArray () {
            for (int i = 0; i < size; i++) {
                Console.WriteLine (array[i]);
            }
        }

        void bubbleSort (int[] _array) {
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

        private void button1_Click (object sender, EventArgs e) {
            while (size != 2000) {
                
                fillArray (size);

                elapsed.Restart ();
                bubbleSort (array);
                elapsed.Stop ();

                long w = elapsed.ElapsedMilliseconds;
                Console.WriteLine (w);

                size += 5;
                
            }
            
        }
    }
}
