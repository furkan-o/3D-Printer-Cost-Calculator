using System;
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
            // 
            this.filamentPriceTextBox.Location = new System.Drawing.Point(175, 26);
            this.filamentPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filamentPriceTextBox.Name = "filamentPriceTextBox";
            this.filamentPriceTextBox.Size = new System.Drawing.Size(116, 25);
            this.filamentPriceTextBox.TabIndex = 0;
            // 
            // 
            this.electricityPriceTextBox.Location = new System.Drawing.Point(175, 65);
            this.electricityPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.electricityPriceTextBox.Name = "electricityPriceTextBox";
            this.electricityPriceTextBox.Size = new System.Drawing.Size(116, 25);
            this.electricityPriceTextBox.TabIndex = 1;
            // 
            // 
            this.printerPowerTextBox.Location = new System.Drawing.Point(175, 105);
            this.printerPowerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printerPowerTextBox.Name = "printerPowerTextBox";
            this.printerPowerTextBox.Size = new System.Drawing.Size(116, 25);
            this.printerPowerTextBox.TabIndex = 2;
            // 
            // 
            this.printWeightTextBox.Location = new System.Drawing.Point(175, 144);
            this.printWeightTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printWeightTextBox.Name = "printWeightTextBox";
            this.printWeightTextBox.Size = new System.Drawing.Size(116, 25);
            this.printWeightTextBox.TabIndex = 3;
            // 
            // 
            this.printTimeTextBox.Location = new System.Drawing.Point(175, 183);
            this.printTimeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printTimeTextBox.Name = "printTimeTextBox";
            this.printTimeTextBox.Size = new System.Drawing.Size(116, 25);
            this.printTimeTextBox.TabIndex = 4;
            // 
            // 
            this.printerCostTextBox.Location = new System.Drawing.Point(175, 222);
            this.printerCostTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printerCostTextBox.Name = "printerCostTextBox";
            this.printerCostTextBox.Size = new System.Drawing.Size(116, 25);
            this.printerCostTextBox.TabIndex = 5;
            // 
            // 
            this.calculateButton.Location = new System.Drawing.Point(338, 301);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(88, 30);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            // 
            // 
            this.filamentCostLabel.AutoSize = true;
            this.filamentCostLabel.Location = new System.Drawing.Point(23, 347);
            this.filamentCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filamentCostLabel.Name = "filamentCostLabel";
            this.filamentCostLabel.Size = new System.Drawing.Size(124, 17);
            this.filamentCostLabel.TabIndex = 7;
            this.filamentCostLabel.Text = "Filament Cost: ₺0.00";
            // 
            // 
            this.electricityCostLabel.AutoSize = true;
            this.electricityCostLabel.Location = new System.Drawing.Point(172, 347);
            this.electricityCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.electricityCostLabel.Name = "electricityCostLabel";
            this.electricityCostLabel.Size = new System.Drawing.Size(130, 17);
            this.electricityCostLabel.TabIndex = 8;
            this.electricityCostLabel.Text = "Electricity Cost: ₺0.00";
            // 
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(335, 347);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(104, 17);
            this.totalCostLabel.TabIndex = 9;
            this.totalCostLabel.Text = "Total Cost: ₺0.00";
            // 
            // 
            this.filamentPriceLabel.AutoSize = true;
            this.filamentPriceLabel.Location = new System.Drawing.Point(23, 34);
            this.filamentPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filamentPriceLabel.Name = "filamentPriceLabel";
            this.filamentPriceLabel.Size = new System.Drawing.Size(133, 17);
            this.filamentPriceLabel.TabIndex = 10;
            this.filamentPriceLabel.Text = "Filament Price per kg:";
            // 
            // 
            this.electricityPriceLabel.AutoSize = true;
            this.electricityPriceLabel.Location = new System.Drawing.Point(23, 73);
            this.electricityPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.electricityPriceLabel.Name = "electricityPriceLabel";
            this.electricityPriceLabel.Size = new System.Drawing.Size(150, 17);
            this.electricityPriceLabel.TabIndex = 11;
            this.electricityPriceLabel.Text = "Electricity Price per kWh:";
            // 
            // 
            this.printerPowerLabel.AutoSize = true;
            this.printerPowerLabel.Location = new System.Drawing.Point(23, 113);
            this.printerPowerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.printerPowerLabel.Name = "printerPowerLabel";
            this.printerPowerLabel.Size = new System.Drawing.Size(170, 17);
            this.printerPowerLabel.TabIndex = 12;
            this.printerPowerLabel.Text = "Printer Power Consumption:";
            // 
            // 
            this.printWeightLabel.AutoSize = true;
            this.printWeightLabel.Location = new System.Drawing.Point(23, 152);
            this.printWeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.printWeightLabel.Name = "printWeightLabel";
            this.printWeightLabel.Size = new System.Drawing.Size(101, 17);
            this.printWeightLabel.TabIndex = 13;
            this.printWeightLabel.Text = "Print Weight (g):";
            // 
            // 
            this.printTimeLabel.AutoSize = true;
            this.printTimeLabel.Location = new System.Drawing.Point(23, 191);
            this.printTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.printTimeLabel.Name = "printTimeLabel";
            this.printTimeLabel.Size = new System.Drawing.Size(126, 17);
            this.printTimeLabel.TabIndex = 14;
            this.printTimeLabel.Text = "Print Time (minutes):";
            // 
            // 
            this.printerCostLabel.AutoSize = true;
            this.printerCostLabel.Location = new System.Drawing.Point(23, 230);
            this.printerCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.printerCostLabel.Name = "printerCostLabel";
            this.printerCostLabel.Size = new System.Drawing.Size(135, 17);
            this.printerCostLabel.TabIndex = 15;
            this.printerCostLabel.Text = "Printer Purchase Cost:";
            // 
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 392);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D Printer Cost Calculator";
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
    }
}
