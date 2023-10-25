using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LL1_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            Parser parser = new Parser(input);
            parser.Parse();
            
            // MessageBox.Show(parser.currentPosition + " ");
            if (parser.currentPosition == input.Length)
            {
                ResultLabel.Text = "The input is valid.";
            }
            else
            {
                ResultLabel.Text = "The input is invalid.";
            }
        }
    }

    public class Parser
    {
        private readonly string input;
        public int currentPosition;

        public Parser(string input)
        {
            this.input = input;
            currentPosition = 0;
        }

        public void Parse()
        {
            S();
        }

        private void S()
        {
            E();
            Match('$');
        }

        private void E()
        {
            T();
            EPrime();
        }

        private void EPrime()
        {
            if (Match('+'))
            {
                T();
                EPrime();
            }
        }

        private void T()
        {
            F();
            TPrime();
        }

        private void TPrime()
        {
            if (Match('*'))
            {
                F();
                TPrime();
            }
        }

        private void F()
        {
            if (Match('('))
            {
                E();
                Match(')');
            }
            else
            {
                Match('i');
                Match('d');
            }
        }

        private bool Match(char expected)
        {
            // MessageBox.Show(currentPosition + " " + input[currentPosition]  + " " + expected);
            if (currentPosition >= input.Length)
            {
                return false;
            }

            if (input[currentPosition] == expected)
            {
                currentPosition++;
                return true;
            }

            return false;
        }
    }

}
