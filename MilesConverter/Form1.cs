﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesConverter
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            const double MilesCoef = 1.60934;
            try
            {
                double miles = double.Parse(MilesTextBox.Text);
                double kilimeters  = miles* MilesCoef;
                AnswerLabel.Text = miles+ " миль это " + kilimeters + " километров";
                AnswerLabel.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {
                AnswerLabel.ForeColor = System.Drawing.Color.Red;
                AnswerLabel.Text ="Ошибка: " + ex.Message;
            }
        }
    }
}
