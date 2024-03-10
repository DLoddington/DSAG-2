using System;
using TaskBassessed.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBassessed
{
    public partial class Form1 : Form
    {
        StrQueue queue = new StrQueue();

        public Form1()
        {
            InitializeComponent();
        }

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            intErrorText.Text = ""; //remove any error messages when doing a new action
            if (queue.IsFull() == false)
            {
                queue.Enqueue(nameEnqueueTextBox.Text);
                confirmationText.Text = nameEnqueueTextBox.Text + " added";
                nameStackDisplay.Text = queue.Print();
                numNames();
            }
            else
            {
                confirmationText.Text = "Queue is full!";

            }
        }

        private void dequeueName_Click(object sender, EventArgs e)
        {
            intErrorText.Text = ""; //remove any error messages when doing a new action
            if (queue.IsEmpty() == false)
            {
                confirmationText.Text = queue.Dequeue() + " removed.";
                nameStackDisplay.Text = queue.Print();
                numNames();
            }
            else
            {
                confirmationText.Text = "Queue is empty!";
            }

        }
        
        public bool CheckInt() //checks the flipped value is an int
        {
            try
            {
                Convert.ToInt32(reverseVal.Text);
            }
            catch (FormatException e)
            {
                intErrorText.Text = "Error! value isnt a number";
                confirmationText.Text = "";
                return false;
            }
            return true;
        }

        public bool CheckQueue()
        {
            int numQueueItems = queue.getNumItems();
            int testInt = Convert.ToInt32(reverseVal.Text);
            if (testInt < 1 || testInt > numQueueItems)
            {
                intErrorText.Text = "Error! value doesn't exist in current queue";
                confirmationText.Text = "";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ReverseFromInputVal(int input)
        {
            int numItemsQueue = queue.getNumItems(); //establish number of items in current queue
            string[] queueFlip = new string[numItemsQueue]; //ensure new array lenght is same as old array


            for (int i = 0; i < numItemsQueue; i++) //dequeue everything into a new array
            {
                queueFlip[i] = queue.Dequeue(); 
            }

            for (int i=input-1;i>=0;i--) //enqueue in reverse order from input 'k' point
            {
                queue.Enqueue(queueFlip[i]);
            }
            for (int i=input;i<numItemsQueue;i++) //enqueue rest in normal order starting at input k, up until the origain number of items in queue
            {
                queue.Enqueue(queueFlip[i]);
            }
            nameStackDisplay.Text = queue.Print(); //print out new queue
        }

        private void reverseStack_Click(object sender, EventArgs e)
        {
            if (CheckInt() == true) 
            {
                if (CheckQueue() == true)
                {
                    ReverseFromInputVal(Convert.ToInt32(reverseVal.Text)); // only reverse the stacks when the value exists and its an int
                    intErrorText.Text = ""; //clear any error messages
                    confirmationText.Text = "Queue flipped from " + Convert.ToInt32(reverseVal.Text) + "!";
                }
            } 
        }

        private void numNames()
        {
            namesNumText.Text = queue.getNumItems().ToString();
        }

        private void clearQueue()
        {
            while (queue.getNumItems() > 0)
            {
                queue.Dequeue();
            }
        }

        private void dummyButton_Click(object sender, EventArgs e)
        {
            clearQueue();
            queue.Enqueue("Daniel");
            queue.Enqueue("David");
            queue.Enqueue("Amy");
            queue.Enqueue("Fred");
            queue.Enqueue("William");
            queue.Enqueue("Elaine");
            queue.Enqueue("Margaret");
            queue.Enqueue("June");
            queue.Enqueue("Lesley");
            queue.Enqueue("Ducky");
            queue.Enqueue("Liz");
            queue.Enqueue("Stevie");
            queue.Enqueue("Florence");
            queue.Enqueue("Teddy");
            queue.Enqueue("Ffion");
            queue.Enqueue("Tom");
            queue.Enqueue("Morpheus");
            queue.Enqueue("Ammar");
            queue.Enqueue("Shahab");
            queue.Enqueue("Wassim");
            nameStackDisplay.Text = queue.Print();
            numNames();
        }
    }
}
