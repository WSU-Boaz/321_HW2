﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glassberg_HW2_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RunDistinctIntegers(this);
        }

        private static void setTextboxText(string text, Form1 form)
        {
            form.textBox1.Text = text;
        }
        private static void RunDistinctIntegers(Form1 form) // this is your method
        {
            /*
             
            Use the Random class to create a list (System.Collections.Generic.List) with 10,000 random
            integers in the range [0, 20,000] (give or take a few hundred in that range is fine). Then determine how
            many distinct integers are in the list with 3 different approaches. Also, have them run in the order listed
            below. Do not change the order.

            To be clear: You are not allowed to use ready implementations of Distinct. A note on what
            you’re doing: you’re taking an array of numbers and conceptually just removing duplicates and counting
            how many are left. If the input array was {1,1,3,5,6,6,7,7,7,9} then the distinct number set is
            {1,3,5,6,7,9}, implying 6 distinct numbers.



            1. Do not alter the list in any way and use a hash set to determine the number of distinct integers
            in the list. The result will be included in the output, which is discussed more below. Also, include
            in the output information about the time complexity of this method. Be careful with this and
            describe how you determined it. Use a good amount of detail, as a too sparse explanation might
            not be worth full points. Use the MSDN documentation to assist you.

            2. Do not alter the list in any way and determine the number of distinct items it contains while
            keeping the storage complexity (auxiliary) at O(1). This means that you cannot dynamically
            allocate any memory. If you have an algorithm that would require more storage if the list had
            more items, then it is not O(1) storage complexity. Moreover, you cannot allocate additional
            lists, arrays, or containers of any sort. There is some leniency on the time complexity
            requirements for this part. Due to the strict memory requirements your method may end up
            being quite slow next to the other 2, but it still should execute in a matter of a few seconds on
            any computer made within the last 5 years.

            3. Sort the list (use built-in sorting functionality) and then use a new algorithm to determine the
            number of distinct items with O(1) storage, no dynamic memory allocation, and O(n) time
            complexity. Do not alter the list further after sorting it. Determine the number of distinct items
            in O(n) time (not including the sorting time, which you can ignore), where n is the number of
            items in the list.

            Output:
            Use either a string or StringBuilder object to compile text results from all of your methods. Put
            this string in the text box after completion, so that it shows up when the app runs. Examine your results
            before submitting your code and make sure they make sense. Obviously all 3 methods should be giving
            you the same answer. It should look something like the following (but of course with more details filled
            in where I have neglected to give you the answer) when you’re finished

             */

            //use a hash set to determine how many unique numbers there are (then write about time complexity)

            //use O(1) storage (i.e. no dynamic memory like lists, arrays, etc) to determine

            //sort the list, then determine

            //Output: display all 3 methods with strings
            setTextboxText("Hello World",form);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
