using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace SortingAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1 () {
            InitializeComponent ();
        }

        #region variables

        static int size = 5;
        Random r = new Random ();
        Stopwatch elapsed = new Stopwatch();
        SortingMethods sort = new SortingMethods ();
        int[] array;

        #endregion
    
        void fillArray (int _size) {
            array = new int[size];
            for (int i = 0; i < _size; i++) {
                array[i] = r.Next (size);
            }
        }

        private void bubbleSort_Button (object sender, EventArgs e) {

            while (size != 2000) {
                
                fillArray (size);

                elapsed.Start ();
                sort.bubbleSort (array);
                elapsed.Stop ();

                long w = elapsed.ElapsedMilliseconds;
                chart1.Series["BubbleSort"].Points.AddXY(size, w);

                chart1.Update();

                size += 5;
                
            }
            
        }
    }

}
