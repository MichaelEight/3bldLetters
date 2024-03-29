﻿using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;       //Microsoft Excel 14 object in references-> COM tab

namespace _3bldLetters
{
    public partial class mainWindow : Form
    {
        /// TECHNICAL
        int rowCount = 24; // row count of excel file
        int colCount = 24; // column count of excel file

        // array <memos> used to hold memo labels 
        Control[] memos = new Control[5];

        // array <inputs> used to hold input boxes
        Control[] inputs = new Control[5];

        // array <words> contains all letter pairs combinations (24 x 24) (row x columns)   *** TO EDIT ***
        string[,] words;
        

        public mainWindow()
        {
            InitializeComponent();

            // load all input boxes to array <inputs>
            inputs[0] = this.Controls["letterBox1"];
            inputs[1] = this.Controls["letterBox2"];
            inputs[2] = this.Controls["letterBox3"];
            inputs[3] = this.Controls["letterBox4"];
            inputs[4] = this.Controls["letterBox5"];

            // load all memo labels to array <memos>
            memos[0] = this.Controls["memo1"];
            memos[1] = this.Controls["memo2"];
            memos[2] = this.Controls["memo3"];
            memos[3] = this.Controls["memo4"];
            memos[4] = this.Controls["memo5"];

            // Create matrix of words
            words = new string[rowCount, colCount];

            // Excel File
            // Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(Application.StartupPath + @"\WordsDatabase.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int row = 0, col = 0; // current row / column

            // load to <words>
            for (int i = 2; i <= rowCount + 1; i++) // rows, move by 1 to ignore 1st row
            {
                for (int j = 2; j <= colCount + 1; j++) // columns, move by 1 to ignore 1st col
                {
                    // if not empty
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        words[row, col] = xlRange.Cells[i, j].Value2.ToString(); // add word to <words>
                    col++; // go to next column
                }
                col = 0; // reset column count
                row++; // go to next row
            }

            // delete objects after using
            xlApp = null;
            xlWorkbook = null;
            xlWorksheet = null;
            xlRange = null;
        }

        /// <summary>
        /// Load text from input boxes, split it into pairs, then convert into specific words
        /// </summary>
        private void inputButton_Click(object sender, EventArgs e)
        {
            // temporary string holder : input
            string temp = "";
            // temporary char holder : input
            char ch = ' ';

            // go through all 5 fields
            for(int i = 0; i < 5; i++) 
            {
                // make every input lowercased
                inputs[i].Text = inputs[i].Text.ToLower();

                // clear memo text
                memos[i].Text = "";

                // clear temporary
                temp = "";

                // make sure there aren't any spaces
                for(int j = 0; j < inputs[i].Text.Length; j++)
                {
                    // get a char from string
                    ch = inputs[i].Text[j];

                    // if it's valid char
                    if (ch == 'a' || ch == 'b' || ch == 'c' || ch == 'd' || ch == 'e' || ch == 'f' || ch == 'g' || ch == 'h' || ch == 'i' || ch == 'j' || ch == 'k' || ch == 'l'
                         || ch == 'm' || ch == 'n' || ch == 'o' || ch == 'p' || ch == 'q' || ch == 'r' || ch == 's' || ch == 't' || ch == 'u' || ch == 'v' || ch == 'w' || ch == 'z')
                    {
                        temp += inputs[i].Text[j].ToString(); // add that char to <temp> string
                    }
                }

                // swap original for valid string
                inputs[i].Text = temp;
            }

            // array <pairs> holds divided letters from input box
            string[] pairs;

            int k = 0; // determines, in which pair letter should go

            for(int i = 0; i < 5; i++) // loop : go through all input boxes
            {
                if (inputs[i].Text.Length > 0) // if input isn't null
                {
                    k = 0; // reset pair counter

                    pairs = new string[inputs[i].Text.Length]; // specify length of array <pairs>

                    for (int j = 0; j < inputs[i].Text.Length; j++) // go through all letters in box [i]
                    {
                        if (j % 2 == 0) // if 1st letter
                        {
                            pairs[k] += inputs[i].Text[j]; // add 1st letter to pair string
                        }
                        else // if 2nd letter
                        {
                            pairs[k] += inputs[i].Text[j]; // add 2nd letter to pair string
                            
                            if(pairs[k][0] != pairs[k][1]) // if letters in pair are different
                            {
                                // Pair >> Word, then add it to memo[i] label
                                memos[i].Text += PairToWord(pairs[k].ToLower()) + ", ";
                            }
                            else // if letters in pair are the same
                            {
                                // just add them as they are
                                memos[i].Text += pairs[k].ToLower() + ", ";
                            }

                            k++; // select next pair
                        }

                        // if single letter 
                        if(j == inputs[i].Text.Length - 1)
                        {
                            memos[i].Text += pairs[k]; // add it to pair
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Finds word in matrix 'words' correspodning to pair of letters using vars 'x' and 'y', so "coordinates" of the word
        /// </summary>
        /// <param name="pair"> Pair of letters to be converted into the word </param>
        /// <returns> Found word from matrix 'words' </returns>
        private string PairToWord(string pair)
        {
            int x, y = 0; // coordinates of word

            // convert letters to coords
            x = LetterToNumber(pair[0]);
            y = LetterToNumber(pair[1]);

            if(x == 99 || y == 99) // if func returned 'invalid' code
            {
                return pair; // return input
            }

            return words[x,y]; // return specific word
        }

        /// <summary>
        /// Convert letter to specific number
        /// </summary>
        /// <param name="v"> Var holding letter to be converted </param>
        /// <returns> Specific number </returns>
        private int LetterToNumber(char v)
        {
            // get ASCII value of 'v' and subtrack const 97 to zero it, to make it the beginning
            int x = unchecked(v & 0xFF) - 97;

            // return value ( if v != 'z', then true(return x), else false(return x-2) )
            return v != 'z' ? x : x-2; 
        }

        /// <summary>
        /// Detect key press ; move to higher / lower box or simulate pressing 'inputButton'
        /// </summary>
        /// <param name="e"> Var to hold keypress </param>

        private void letterBox1_KeyPress(object sender, KeyPressEventArgs e)
        {  
            // if [enter] is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // mute sound
                inputButton.PerformClick(); // sim. click / proceed
            }
        }

        private void letterBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // if [down_arrow] is pressed
            if (e.KeyCode == Keys.Down)
            {
                letterBox2.Focus(); // set focus on 2nd box
            }
        }

        private void letterBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if [enter] is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // mute sound
                inputButton.PerformClick(); // sim. click / proceed
            }
        }

        private void letterBox2_KeyDown(object sender, KeyEventArgs e)
        {
            // if [up_arrow] is pressed
            if (e.KeyCode == Keys.Up)
            {
                letterBox1.Focus(); // set focus on 1st box
            }
            // if [down_arrow] is pressed
            else if (e.KeyCode == Keys.Down)
            {
                letterBox3.Focus(); // set focus on 3rd box
            }
        }

        private void letterBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if [enter] is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // mute sound
                inputButton.PerformClick(); // sim. click / proceed
            }
        }

        private void letterBox3_KeyDown(object sender, KeyEventArgs e)
        {
            // if [up_arrow] is pressed
            if (e.KeyCode == Keys.Up)
            {
                letterBox2.Focus(); // set focus on 2nd box
            }
            // if [down_arrow] is pressed
            else if (e.KeyCode == Keys.Down)
            {
                letterBox4.Focus(); // set focus on 4th box
            }
        }

        private void letterBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if [enter] is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // mute sound
                inputButton.PerformClick(); // sim. click / proceed
            }
        }

        private void letterBox4_KeyDown(object sender, KeyEventArgs e)
        {
            // if [up_arrow] is pressed
            if (e.KeyCode == Keys.Up) 
            {
                letterBox3.Focus(); // set focus on 3rd box
            }
            // if [down_arrow] is pressed
            else if (e.KeyCode == Keys.Down) 
            {
                letterBox5.Focus(); // set focus on 5th box
            }
        }

        private void letterBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if [enter] is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // mute sound
                inputButton.PerformClick(); // sim. click / proceed
            }
        }

        private void letterBox5_KeyDown(object sender, KeyEventArgs e)
        {
            // if [up_arrow] is pressed
            if (e.KeyCode == Keys.Up) // if up arrow, change focus
            {
                letterBox4.Focus(); // set focus on 4th box
            }
        }
    }
}
