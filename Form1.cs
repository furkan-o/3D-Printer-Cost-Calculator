﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrinterCostCalculator
{
    public partial class Form1 : Form
    {
        private TextBox filamentPriceTextBox;
        private TextBox electricityPriceTextBox;
        private TextBox printerPowerTextBox;
        private TextBox printWeightTextBox;
        private TextBox printTimeTextBox;
        private TextBox printerCostTextBox;
        private Button calculateButton;
        private Label filamentCostLabel;
        private Label electricityCostLabel;
        private Label totalCostLabel;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.filamentPriceTextBox = new System.Windows.Forms.TextBox();
            this.electricityPriceTextBox = new System.Windows.Forms.TextBox();
            this.printerPowerTextBox = new System.Windows.Forms.TextBox();
            this.printWeightTextBox = new System.Windows.Forms.TextBox();
            this.printTimeTextBox = new System.Windows.Forms.TextBox();
            this.printerCostTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.filamentCostLabel = new System.Windows.Forms.Label();
            this.electricityCostLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.filamentPriceLabel = new System.Windows.Forms.Label();
            this.electricityPriceLabel = new System.Windows.Forms.Label();
            this.printerPowerLabel = new System.Windows.Forms.Label();
            this.printWeightLabel = new System.Windows.Forms.Label();
            this.printTimeLabel = new System.Windows.Forms.Label();
            this.printerCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filamentPriceTextBox
            // 
            this.filamentPriceTextBox.Location = new System.Drawing.Point(245, 24);
            this.filamentPriceTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.filamentPriceTextBox.Name = "filamentPriceTextBox";
            this.filamentPriceTextBox.Size = new System.Drawing.Size(132, 22);
            this.filamentPriceTextBox.TabIndex = 0;
            // 
            // electricityPriceTextBox
            // 
            this.electricityPriceTextBox.Location = new System.Drawing.Point(245, 60);
            this.electricityPriceTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.electricityPriceTextBox.Name = "electricityPriceTextBox";
            this.electricityPriceTextBox.Size = new System.Drawing.Size(132, 22);
            this.electricityPriceTextBox.TabIndex = 1;
            // 
            // printerPowerTextBox
            // 
            this.printerPowerTextBox.Location = new System.Drawing.Point(245, 97);
            this.printerPowerTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.printerPowerTextBox.Name = "printerPowerTextBox";
            this.printerPowerTextBox.Size = new System.Drawing.Size(132, 22);
            this.printerPowerTextBox.TabIndex = 2;
            // 
            // printWeightTextBox
            // 
            this.printWeightTextBox.Location = new System.Drawing.Point(245, 135);
            this.printWeightTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.printWeightTextBox.Name = "printWeightTextBox";
            this.printWeightTextBox.Size = new System.Drawing.Size(132, 22);
            this.printWeightTextBox.TabIndex = 3;
            // 
            // printTimeTextBox
            // 
            this.printTimeTextBox.Location = new System.Drawing.Point(245, 171);
            this.printTimeTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.printTimeTextBox.Name = "printTimeTextBox";
            this.printTimeTextBox.Size = new System.Drawing.Size(132, 22);
            this.printTimeTextBox.TabIndex = 4;
            // 
            // printerCostTextBox
            // 
            this.printerCostTextBox.Location = new System.Drawing.Point(245, 208);
            this.printerCostTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.printerCostTextBox.Name = "printerCostTextBox";
            this.printerCostTextBox.Size = new System.Drawing.Size(132, 22);
            this.printerCostTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(386, 263);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(119, 35);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // filamentCostLabel
            // 
            this.filamentCostLabel.AutoSize = true;
            this.filamentCostLabel.Location = new System.Drawing.Point(26, 327);
            this.filamentCostLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.filamentCostLabel.Name = "filamentCostLabel";
            this.filamentCostLabel.Size = new System.Drawing.Size(125, 16);
            this.filamentCostLabel.TabIndex = 7;
            this.filamentCostLabel.Text = "Filament Cost: ₺0.00";
            // 
            // electricityCostLabel
            // 
            this.electricityCostLabel.AutoSize = true;
            this.electricityCostLabel.Location = new System.Drawing.Point(197, 327);
            this.electricityCostLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.electricityCostLabel.Name = "electricityCostLabel";
            this.electricityCostLabel.Size = new System.Drawing.Size(131, 16);
            this.electricityCostLabel.TabIndex = 8;
            this.electricityCostLabel.Text = "Electricity Cost: ₺0.00";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(383, 327);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(105, 16);
            this.totalCostLabel.TabIndex = 9;
            this.totalCostLabel.Text = "Total Cost: ₺0.00";
            // 
            // filamentPriceLabel
            // 
            this.filamentPriceLabel.AutoSize = true;
            this.filamentPriceLabel.Location = new System.Drawing.Point(26, 32);
            this.filamentPriceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.filamentPriceLabel.Name = "filamentPriceLabel";
            this.filamentPriceLabel.Size = new System.Drawing.Size(136, 16);
            this.filamentPriceLabel.TabIndex = 10;
            this.filamentPriceLabel.Text = "Filament Price per kg:";
            // 
            // electricityPriceLabel
            // 
            this.electricityPriceLabel.AutoSize = true;
            this.electricityPriceLabel.Location = new System.Drawing.Point(26, 69);
            this.electricityPriceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.electricityPriceLabel.Name = "electricityPriceLabel";
            this.electricityPriceLabel.Size = new System.Drawing.Size(154, 16);
            this.electricityPriceLabel.TabIndex = 11;
            this.electricityPriceLabel.Text = "Electricity Price per kWh:";
            // 
            // printerPowerLabel
            // 
            this.printerPowerLabel.AutoSize = true;
            this.printerPowerLabel.Location = new System.Drawing.Point(26, 105);
            this.printerPowerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.printerPowerLabel.Name = "printerPowerLabel";
            this.printerPowerLabel.Size = new System.Drawing.Size(208, 16);
            this.printerPowerLabel.TabIndex = 12;
            this.printerPowerLabel.Text = "Printer Power Consumption (kWh):";
            // 
            // printWeightLabel
            // 
            this.printWeightLabel.AutoSize = true;
            this.printWeightLabel.Location = new System.Drawing.Point(26, 143);
            this.printWeightLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.printWeightLabel.Name = "printWeightLabel";
            this.printWeightLabel.Size = new System.Drawing.Size(100, 16);
            this.printWeightLabel.TabIndex = 13;
            this.printWeightLabel.Text = "Print Weight (g):";
            // 
            // printTimeLabel
            // 
            this.printTimeLabel.AutoSize = true;
            this.printTimeLabel.Location = new System.Drawing.Point(26, 180);
            this.printTimeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.printTimeLabel.Name = "printTimeLabel";
            this.printTimeLabel.Size = new System.Drawing.Size(127, 16);
            this.printTimeLabel.TabIndex = 14;
            this.printTimeLabel.Text = "Print Time (minutes):";
            // 
            // printerCostLabel
            // 
            this.printerCostLabel.AutoSize = true;
            this.printerCostLabel.Location = new System.Drawing.Point(26, 216);
            this.printerCostLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.printerCostLabel.Name = "printerCostLabel";
            this.printerCostLabel.Size = new System.Drawing.Size(138, 16);
            this.printerCostLabel.TabIndex = 15;
            this.printerCostLabel.Text = "Printer Purchase Cost:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(534, 369);
            this.Controls.Add(this.filamentPriceTextBox);
            this.Controls.Add(this.electricityPriceTextBox);
            this.Controls.Add(this.printerPowerTextBox);
            this.Controls.Add(this.printWeightTextBox);
            this.Controls.Add(this.printTimeTextBox);
            this.Controls.Add(this.printerCostTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.filamentCostLabel);
            this.Controls.Add(this.electricityCostLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.filamentPriceLabel);
            this.Controls.Add(this.electricityPriceLabel);
            this.Controls.Add(this.printerPowerLabel);
            this.Controls.Add(this.printWeightLabel);
            this.Controls.Add(this.printTimeLabel);
            this.Controls.Add(this.printerCostLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D Printer Cost Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double filamentPrice = double.Parse(filamentPriceTextBox.Text);
                double electricityPrice = double.Parse(electricityPriceTextBox.Text);
                double printerPower = double.Parse(printerPowerTextBox.Text);
                double printWeightGrams = double.Parse(printWeightTextBox.Text);
                double printWeightKg = printWeightGrams / 1000;
                double printTime = double.Parse(printTimeTextBox.Text);
                double printerCost = double.Parse(printerCostTextBox.Text);

                double filamentCost = printWeightKg * filamentPrice;
                double electricityCost = (printerPower * printTime / 60) * electricityPrice;
                double totalCost = filamentCost + electricityCost + printerCost;

                filamentCostLabel.Text = $"Filament Cost: ₺{filamentCost:F2}";
                electricityCostLabel.Text = $"Electricity Cost: ₺{electricityCost:F2}";
                totalCostLabel.Text = $"Total Cost: ₺{totalCost:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid numbers in all fields.");
            }
        }

        private Label filamentPriceLabel;
        private Label electricityPriceLabel;
        private Label printerPowerLabel;
        private Label printWeightLabel;
        private Label printTimeLabel;
        private Label printerCostLabel;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
