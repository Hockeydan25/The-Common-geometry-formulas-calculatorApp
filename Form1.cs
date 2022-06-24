using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Common_geometry_formulas_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double length = 0;
        double width = 0;
        double height = 0;
        double radious = 0;
        double perimeter = 0;
        double area = 0;
        string msg = "";
        private void btnCalcualate_Click(object sender, EventArgs e) //Calculate button, labeled as button1    
        {
            if (btnCalcualate.Text == "Calculate") 
            {
                btnCalcualate.Text = "Anwser";

                if (RdoBtnRect.Checked == true)
                {
                    pictureBox1.Image = Properties.Resources.rectangle;//makes visible for user w/selection, RdoBtnRect.
                    label5.Visible = true;  //makes visible for user w/selection, RdoBtnRect.
                    label1.Visible = true;  //makes visible for user w/selection, RdoBtnRect.
                    label3.Visible = true;  //makes visible for user w/selection, RdoBtnRect.
                    txtBoxL.Visible = true; //makes visible for user w/selection, RdoBtnRect.
                    txtBoxW.Visible = true;     //makes visible for user w/selection, RdoBtnRect.
                    TxtBXAnswer.Visible = true; //makes visible for user w/selection, RdoBtnRect.
                }
                else if (RdoBtnTri.Checked == true)
                {
                    pictureBox1.Image = Properties.Resources.Triangle; //makes visible for user w/selection, RdoBtnTri.
                    label5.Visible = true;  //makes visible for user w/selection, RdoBtnTri.
                    label1.Visible = true;   //makes visible for user w/selection, RdoBtnTri.
                    label3.Visible = true;       //makes visible for user w/selection, RdoBtnTri.
                    label2.Visible = true;   //makes visible for user w/selection, RdoBtnTri.
                    txtBoxL.Visible = true;  //makes visible for user w/selection, RdoBtnTri.
                    txtBoxW.Visible = true;  //makes visible for user w/selection, RdoBtnTri.
                    txtBoxH.Visible = true;  //makes visible for user w/selection, RdoBtnTri.
                    TxtBXAnswer.Visible = true;  //makes visible for user w/selection, RdoBtnTri.
                }
                else if (RdoBtnSq.Checked == true)
                {
                    pictureBox1.Image = Properties.Resources.Square;  //makes visible for user w/selection, RdoBtnSq.
                    label1.Visible = true; //makes visible for user w/selection, RdoBtnSq.
                    label5.Visible = true;  //makes visible for user w/selection, RdoBtnSq.
                    txtBoxL.Visible = true;  //makes visible for user w/selection, RdoBtnSq.
                    TxtBXAnswer.Visible = true;  //makes visible for user w/selection, RdoBtnSq.
                }
                else if (RdoBtnPara.Checked == true)
                {
                    pictureBox1.Image = Properties.Resources.Parallelogram_gif; //makes visible for user w/selection, RdoBtnPara.
                    label5.Visible = true;  //makes visible for user w/selection, RdoBtnPara.
                    label1.Visible = true;  //makes visible for user w/selection, RdoBtnPara.
                    label3.Visible = true;  //makes visible for user w/selection, RdoBtnPara.
                    label2.Visible = true;  //makes visible for user w/selection, RdoBtnPara.
                    txtBoxL.Visible = true;  //makes visible for user w/selection, RdoBtnPara.
                    txtBoxW.Visible = true;  //makes visible for user w/selection, RdoBtnPara.
                    txtBoxH.Visible = true;  //makes visible for user w/selection, RdoBtnPara.
                    TxtBXAnswer.Visible = true;  //makes visible for user w/selection, RdoBtnPara.
                }
                else if (RdoBtnRhom.Checked == true)
                {
                    pictureBox1.Image = Properties.Resources.Rhombus;//makes visible for user w/selection, RdoBtnRhom.
                    label3.Visible = true;  //makes visible for user w/selection, RdoBtnRhom.
                    label5.Visible = true;  //makes visible for user w/selection, RdoBtnPara.
                    txtBoxW.Visible = true;  //makes visible for user w/selection, RdoBtnRhom.
                    TxtBXAnswer.Visible = true;  //makes visible for user w/selection, RdoBtnRhom.
                }
                else if (RdoBtnTrap.Checked == true)
                {
                    pictureBox1.Image = Properties.Resources.Trapezoid;//makes visible for user w/selection, RdoBtnTrap.
                    label5.Visible = true;  //makes visible for user w/selection, RdoBtnTrap.
                    label1.Visible = true;  //makes visible for user w/selection, RdoBtnTrap.
                    label3.Visible = true;  //makes visible for user w/selection, RdoBtnTrap.
                    label2.Visible = true;  //makes visible for user w/selection, RdoBtnTrap.
                    label4.Visible = true;  //makes visible for user w/selection, RdoBtnTrap.
                    txtBoxR.Visible = true;  //makes visible for user w/selection, RdoBtnTrap.
                    txtBoxL.Visible = true;  //makes visible for user w/selection, RdoBtnTrap.
                    txtBoxW.Visible = true;  //makes visible for user w/selection, RdoBtnTrap.
                    txtBoxH.Visible = true;  //makes visible for user w/selection, RdoBtnTrap.
                    TxtBXAnswer.Visible = true;  //makes visible for user w/selection, RdoBtnTrap.
                }
                else //if (RdoBtnCir.Checked == true)
                {
                    pictureBox1.Image = Properties.Resources.Circle; //makes visible for user w/selection, RdoBtnCir.
                    label4.Visible = true;      //makes visible for user w/selection, RdoBtnCir.
                    txtBoxR.Visible = true;     //makes visible for user w/selection, RdoBtnCir.
                    label5.Visible = true;      //makes visible for user w/selection, RdoBtnCir.
                    TxtBXAnswer.Visible = true;     //makes visible for user w/selection, RdoBtnCir.
                }
            }
            else
            {
                if (RdoBtnRect.Checked == true) // (btnCalcualate.Text == "Answer") ;
                {

                    if (RdoBtnAreaCalc.Checked == true) //validates box is checked or not

                    {
                        length = Convert.ToDouble(txtBoxL.Text);  //getting data from txtbox, users entry. 
                        width = Convert.ToDouble(txtBoxW.Text);   //getting data from txtbox, users entry.
                        area = length * width;                  //calculation.
                        msg = "Area = " + Convert.ToString(area);
                        TxtBXAnswer.Text = msg;
                    }
                    else if (RdoBtnPerim.Checked == true) //validates box is checked or not.
                    {
                        length = Convert.ToDouble(txtBoxL.Text); //getting data from txtbox, users entry. 
                        width = Convert.ToDouble(txtBoxW.Text);  //getting data from txtbox, users entry .
                        perimeter = (2 * length) + (2 * width);  //calculation.
                        msg = "  Perimeter = " + Convert.ToString(perimeter);
                        TxtBXAnswer.Text = msg;
                    }
                    else //if (RdoBtnAP.Checked == true)
                    {
                        length = Convert.ToDouble(txtBoxL.Text); //getting data from txtbox, users entry. 
                        width = Convert.ToDouble(txtBoxW.Text);  //getting data from txtbox, users entry .
                        area = length * width;                   //calculation.
                        perimeter = (2 * length) + (2 * width);  //calculation.
                        msg = "Area = " + Convert.ToString(area) + "  Perimeter = " + Convert.ToString(perimeter);
                        TxtBXAnswer.Text = msg;
                    }
                }        
                   
                else if (RdoBtnSq.Checked == true) //validates box is checked or not
                {
                    //if (txtBoxL.Text == "" | txtBoxH.Text == "")  // checking text box for data.
                    //{
                    //    MessageBox.Show         //this is to Display an error message box.                                                           
                    //    ("Length field is a requirement for this program", " Entry error");
                    //}
                    if (RdoBtnAreaCalc.Checked == true) //validates box is checked or not.
                    {
                        length = Convert.ToDouble(txtBoxL.Text); //getting data from txtbox, users entry. 
                        area = length * length;                      //calculation.
                        msg = "Area = " + Convert.ToString(area);
                        TxtBXAnswer.Text = msg;

                    }
                    else if (RdoBtnPerim.Checked == true) //validates box is checked or not.
                    {
                        length = Convert.ToDouble(txtBoxL.Text); //getting data from txtbox, users entry. 
                        perimeter = length * 4;                      //calculation.
                        msg = "  Perimeter = " + Convert.ToString(perimeter);
                        TxtBXAnswer.Text = msg;
                    }
                    else //if (RdoBtnAP.Checked == true)
                    {
                        length = Convert.ToDouble(txtBoxL.Text); //getting data from txtbox, users entry. 
                        area = length * length;       //calculation.   
                        perimeter = length * 4;      //calculation.
                        msg = "Area = " + Convert.ToString(area) + "  Perimeter = " + Convert.ToString(perimeter);
                        TxtBXAnswer.Text = msg;
                    }
                }
                else if (RdoBtnTri.Checked == true) //validates box is checked or not
                {
                    //if (txtBoxL.Text == "" | txtBoxH.Text == "" | txtBoxW.Text == "")  // checking text box for data.
                    //{
                    //    MessageBox.Show         //this is to Display an error message box.                                                           
                    //    ("Length, Height, and Width fields are required for this program", " Entry error");
                    //}
                    if (RdoBtnAreaCalc.Checked == true) //validates box is checked or not.
                    {
                        height = Convert.ToDouble(txtBoxH.Text); //getting data from txtbox, users entry. 
                        width = Convert.ToDouble(txtBoxW.Text); //getting data from txtbox, users entry. 
                        area = (width * height)/2;               //calculation.
                        msg = "Area = " + Convert.ToString(area);
                        TxtBXAnswer.Text = msg;
                    }
                    else if (RdoBtnPerim.Checked == true)//validates box is checked or not.
                    {
                        height = Convert.ToDouble(txtBoxH.Text);  //getting data from txtbox, users entry. 
                        width = Convert.ToDouble(txtBoxW.Text);  //getting data from txtbox, users entry .
                        length = Convert.ToDouble(txtBoxL.Text); //getting data from txtbox, users entry .
                        perimeter = length + width + height;         //calculation.
                        msg = "  Perimeter = " + Convert.ToString(perimeter);
                        TxtBXAnswer.Text = msg;
                    }
                    else //if (RdoBtnAP.Checked == true)
                    {
                        height = Convert.ToDouble(txtBoxH.Text);  //getting data from txtbox, users entry .
                        width = Convert.ToDouble(txtBoxW.Text);   //getting data from txtbox, users entry .
                        length = Convert.ToDouble(txtBoxL.Text);  //getting data from txtbox, users entry. 
                        area = (width * height) / 2;                 //calculation.
                        perimeter = length + width + height;         //calculation.
                        msg = "Area = " + Convert.ToString(area) + "  Perimeter = " + Convert.ToString(perimeter);
                        TxtBXAnswer.Text = msg;
                    }
                }
                else if (RdoBtnPara.Checked == true)
                {
                    //if (txtBoxL.Text == "" | txtBoxH.Text == "")  // checking text box for data.
                    //{
                    //    MessageBox.Show         //this is to Display an error message box.                                                           
                    //    ("Length and Width fields are required for this program", " Entry error");
                    //}
                    if (RdoBtnAreaCalc.Checked == true)//validates box is checked or not.
                    {
                        height = Convert.ToDouble(txtBoxH.Text);  //getting data from txtbox, users entry .
                        width = Convert.ToDouble(txtBoxW.Text);   //getting data from txtbox, users entry. 
                        area = width * height;                       //calculation.
                        msg = "Area = " + Convert.ToString(area);
                        TxtBXAnswer.Text = msg;
                    }
                    else if (RdoBtnPerim.Checked == true)//validates box is checked or not.
                    {
                        height = Convert.ToDouble(txtBoxH.Text);   //getting data from txtbox, users entry. 
                        width = Convert.ToDouble(txtBoxW.Text);    //getting data from txtbox, users entry. 
                        perimeter = (2 * width) + (2 * height);      //calculation.
                        msg = "  Perimeter = " + Convert.ToString(perimeter);
                        TxtBXAnswer.Text = msg;
                    }
                    else // if (RdoBtnAP.Checked == true)
                    {
                        height = Convert.ToDouble(txtBoxH.Text);   //getting data from txtbox, users entry. 
                        width = Convert.ToDouble(txtBoxW.Text);    //getting data from txtbox, users entry. 
                        length = Convert.ToDouble(txtBoxL.Text);   //getting data from txtbox, users entry. 
                        area = width * height;                   //calculation.
                        perimeter = (2 * length) + (2 * width);      //calculation.
                        msg = "Area = " + Convert.ToString(area) + "  Perimeter = " + Convert.ToString(perimeter);
                        TxtBXAnswer.Text = msg;
                    }
                }
                else if (RdoBtnRhom.Checked == true)
                {
                    //if (txtBoxW.Text == "")  // checking text box for data.
                    //{
                    //    MessageBox.Show         //this is to Display an error message box.                                                           
                    //    ("Length and Width fields are required for this program", " Entry error");
                    //}
                    if (RdoBtnAreaCalc.Checked == true)//validates box is checked or not.
                    {
                        width = Convert.ToDouble(txtBoxW.Text); //getting data from txtbox, users entry. 
                        area = width * width;                    //calculation.
                        msg = "Area = " + Convert.ToString(area);
                        TxtBXAnswer.Text = msg;

                    }
                    else if (RdoBtnPerim.Checked == true)//validates box is checked or not.
                    {
                        width = Convert.ToDouble(txtBoxW.Text);  //getting data from txtbox, users entry. 
                        perimeter = width * 4;                   //calculation.
                        msg = "  Perimeter = " + Convert.ToString(perimeter);
                        TxtBXAnswer.Text = msg;
                    }
                    else //if (RdoBtnAP.Checked == true)
                    {
                        width = Convert.ToDouble(txtBoxW.Text); //getting data from txtbox, users entry. 
                        area = width * width;                    //calculation.
                        perimeter = (width * 4);                 //calculation.
                        msg = "Area = " + Convert.ToString(area) + "  Perimeter = " + Convert.ToString(perimeter);
                        TxtBXAnswer.Text = msg;
                    }
                }
                else if (RdoBtnTrap.Checked == true)//validates box is checked or not
                {
                    //if (txtBoxL.Text == "" | txtBoxH.Text == "" | txtBoxW.Text == "")  // checking text box for data.
                    //{
                    //    MessageBox.Show         //this is to Display an error message box.                                                           
                    //    ("Length, Height, and Width fields are required for this program", " Entry error");
                    //}
                    if (RdoBtnAreaCalc.Checked == true)//validates box is checked or not.
                    {
                        height = Convert.ToDouble(txtBoxH.Text);  //getting data from txtbox, users entry. 
                        width = Convert.ToDouble(txtBoxW.Text);   //getting data from txtbox, users entry .
                        length = Convert.ToDouble(txtBoxL.Text);  //getting data from txtbox, users entry.  
                        area = (length + width/2) * height;          //calculation.
                        msg = "Area = " + Convert.ToString(area);
                        TxtBXAnswer.Text = msg;
                    }
                    else if (RdoBtnPerim.Checked == true)//validates box is checked or not.
                    {
                        height = Convert.ToDouble(txtBoxH.Text);  //getting data from txtbox, users entry .
                        width = Convert.ToDouble(txtBoxW.Text);   //getting data from txtbox, users entry .
                        length = Convert.ToDouble(txtBoxL.Text);  //getting data from txtbox, users entry .
                        radious = Convert.ToDouble(txtBoxR.Text);  //getting data from txtbox, users entry .
                        perimeter = length + width + height + radious;  //calculation.
                        msg = "  Perimeter = " + Convert.ToString(perimeter);
                        TxtBXAnswer.Text = msg;
                    }
                    else //if (RdoBtnAP.Checked == true)
                    {
                        height = Convert.ToDouble(txtBoxH.Text); //getting data from txtbox, users entry. 
                        width = Convert.ToDouble(txtBoxW.Text);  //getting data from txtbox, users entry. 
                        length = Convert.ToDouble(txtBoxL.Text);  //getting data from txtbox, users entry. 
                        radious = Convert.ToDouble(txtBoxR.Text);  //getting data from txtbox, users entry. 
                        area = (length + width / 2) * height;        //calculation.
                        perimeter = length + width + height + radious;   //calculation.
                        msg = "Area = " + Convert.ToString(area) + "  Perimeter = " + Convert.ToString(perimeter);
                        TxtBXAnswer.Text = msg;
                    }
                }
                else // if (RdoBtnCir.Checked == true)
                {
                    //if (txtBoxR.Text == "")  // checking text box for data.
                    //{
                    //    MessageBox.Show         //this is to Display an error message box.                                                           
                    //    ("Radious field is required for this program", " Entry error");
                    //}
                    if (RdoBtnAreaCalc.Checked == true)//validates box is checked or not.
                    {
                        radious = Convert.ToDouble(txtBoxR.Text);  //getting data from txtbox, users entry. 
                        area =  Math.PI * radious * radious;         //calculation.
                        msg = "Area = " + Convert.ToString(Math.Round(area, 2));
                        TxtBXAnswer.Text = msg;
                    }
                    else if (RdoBtnPerim.Checked == true)//validates box is checked or not.
                    {
                        
                        radious = Convert.ToDouble(txtBoxR.Text);  //getting data from txtbox, users entry. 
                        perimeter = 2 * Math.PI * radious;           //calculation.
                        msg = "  Perimeter = " + Convert.ToString(Math.Round(perimeter, 2));
                        TxtBXAnswer.Text = msg;
                    }
                    else // if (RdoBtnAP.Checked == true)
                    { 
                        radious = Convert.ToDouble(txtBoxR.Text);   //getting data from txtbox, users entry. 
                        area = Math.PI * radious * radious;          //calculation.
                        perimeter = 2 * Math.PI * radious;           //calculation.
                        msg = "Area = " + Convert.ToString(Math.Round(area, 2)) + "  Perimeter = " + Convert.ToString(Math.Round(perimeter, 2));
                        TxtBXAnswer.Text = msg;

                    }
                }
            }               
        }                      
       
        private void BtnClear_Click(object sender, EventArgs e)
            //button clearing out all values txtboes and resetting visable for next calculations.
        {
            TxtBXAnswer.Text = "";                             //clears anwser txtbox.
            pictureBox1.Image = Properties.Resources.Shape;     //sets picture box to the default.
            RdoBtnAreaCalc.Checked = false;                     //clears checked radio button.
            RdoBtnPerim.Checked = false;                        //clears checked radio button.
            RdoBtnAP.Checked = false;                           //clears checked radio button.
            RdoBtnRect.Checked = false;                         //clears checked radio button.
            RdoBtnSq.Checked = false;                           //clears checked radio button.
            RdoBtnTrap.Checked = false;                         //clears checked radio button.               
            RdoBtnRhom.Checked = false;                         //clears checked radio button.  
            RdoBtnCir.Checked = false;                          //clears checked radio button.              
            RdoBtnTri.Checked = false;                          //clears checked radio button.
            RdoBtnPara.Checked = false;                         //clears checked radio button.    
            txtBoxL.Text = "";                              //clears anwser txtbox .                                       
            txtBoxH.Text = "";                              //clears anwser txtbox.
            txtBoxW.Text = "";                              //clears anwser txtbox.
            txtBoxR.Text = "";                              //clears anwser txtbox.
            txtBoxW.Visible = false;                        //makes txtbox hinden.
            txtBoxL.Visible = false;                        //makes txtbox hinden.
            txtBoxR.Visible = false;                        //makes txtbox hinden .      
            txtBoxH.Visible = false;                        //makes txtbox hinden.
            label5.Visible = false;                         //makes label hinden.
            label1.Visible = false;                         //makes label hinden.
            label3.Visible = false;                         //makes label hinden.
            label2.Visible = false;                         //makes label hinden .       
            label4.Visible = false;                         //makes label hinden.
            btnCalcualate.Text = "Calculate";               //changes button back to a calculate state.
            
        }
        
            private void label5_Click(object sender, EventArgs e)
        {
            
            //label5.Text = perimeter.ToString(label5.Text);
        }

        private void RdoBtnSq_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
