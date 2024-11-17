/*
Grading ID SS340
CIS 199-50
Program 3 
Due: 03/31/2023
Purpose: create a form that calculates the price of a car after discounts, downpayments and loans using loops to search arrayssequencial search and range match parallel arrays

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class Prog3 : Form
    {
       
        public Prog3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void calculate_Click(object sender, EventArgs e) //event handler, doesn't take any of these actions until after the calculate button has been clicked 
        {
            string[] carType = { "PreOwned", "Certified-PreOwned", "New"}; //car type array
            double[] discount = { .20, .15, .10};//discount amount array

            string[] carName = { "Chevy Volt", "Mclaren 720S", "Subaru Outback", "Toyota Camry", "Saturn Sky", "Ford Mustang GT", "Honda Civic" }; //car name array
            double[] carPrice = { 27495, 305000, 28395, 30771, 11583, 27770, 25050}; //car prices

            double[] creditLimit = { 0,501, 601, 701 }; //limits for credit score
            double[] loanAmount = {0, 500, 1500, 2500 }; //loan amount array

            double downPayment = 0 ; //down payment to obtain text value from form
            int creditScore = 0; //credit score to obtain the value from the form
            double carDiscount = 0; //car discount for variable for the for loop
            double carCost = 0 ; //variable for the car price
            double creditLoan = 0; //loan amount based on credit score  
            bool carTypeFound = false; //bool to test whether the value given matched one from the array
            bool carNameFound   = false; //bool to test whether the value given matches the one from the array
            int creditRange; //the credit range for the range match
           
            double total = 0; //grand total

            if (carTypeCB.SelectedIndex >= 0) //tests whether a value was selected from the combo box
            {
                if(carCB.SelectedIndex >= 0) // //tests whether a value was selected from the combo box
                {
                    if(double.TryParse(downPaymentInput.Text, out downPayment) && downPayment >= 0 ) //tests whether the value is greater than 0
                    {
                        if (int.TryParse(creditScoreInput.Text, out creditScore) && (creditScore >= 0 && creditScore <= 800)) // test whether the value is a valid credit score
                        { //using sequential searching 
                            for(int x = 0; x < carType.Length; ++x) //loop for the cartype array, searches theough it looking for the value from the combo box
                            {
                                if (carTypeCB.Text == carType[x]) //if the value is found
                                {
                                    carTypeFound = true; //it will convert the cartypefound bool to true 
                                    carDiscount = discount[x]; //and the car discount equals the matching index value from the second array
                                }
                            } //using sequencial searching 
                            for(int x = 0; x < carName.Length; ++x) //loops through the carnmae array, searches through it looking for the value from the combo box
                            {
                                if(carCB.Text == carName[x]) //if the value in the combo box matches one in the carName array
                                {
                                    carNameFound = true; //sets the carNameFound array to true
                                    carCost = carPrice[x]; //and set the carCost value to the matching index in the car price array 
                                    
                                }
                            }
                            
                            creditRange = creditLimit.Length - 1; //gets the number of indexes in the array
                            //using range matching
                            while( creditRange >= 0 && (int.TryParse(creditScoreInput.Text, out creditScore) && creditScore < creditLimit[creditRange]))//loops through the credit limit array until the condition is no longer true(until the credit score value is less than the next index value
                                --creditRange; //controls the loop so it doesn't become an infinite loop
                                creditLoan = loanAmount[creditRange]; //once its found, creditloan will use the credit range index to find the matching index in the loan amount array
                            



                            DownPaymentOutput.Text = $"{downPayment:C}"; //outputs the down payment in currency format
                            discountOutput.Text = $"{carDiscount:P}"; //outputs the discount in percentage format
                            loanOutput.Text = $"{creditLoan:C}"; //outputs the loan amount in currency format
                            carPriceOutput.Text = $"{carCost:C}"; //outputs the car price in currency format
                            total = carCost - (carDiscount * carCost) - downPayment - creditLoan; //calculates the total they owe using the other variables(carCost-discount - downpayment-loan) 
                            grandTotalOutput.Text = $"{total:C}"; //outputs the total they owe in currency format

                        }
                        else
                            MessageBox.Show("You must enter a valid Credit Score"); //if the if statement conditions aren't met, this message box shows

                     }
                      else
                        MessageBox.Show("You must enter a valid down payment! "); //if the if statement conditions aren't met, this message box shows

                   
                }
                else
                    MessageBox.Show("You MUST Select a Car"); //if the if statement conditions aren't met, this message box shows
            }
            else
                MessageBox.Show("You Must Select a Car Type!! "); //if the if statement conditions aren't met, this message box shows


        }
    }
}
