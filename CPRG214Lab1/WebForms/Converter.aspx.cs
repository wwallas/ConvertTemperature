using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class WebForms_Converter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        decimal VlrCalculate = decimal.Parse(TxtValTmp.Text);
        // Calculate the dropdownlist when is equal value
        if (FromTmp.SelectedValue == ToTmp.SelectedValue)
        {
            LblResult.Text = TxtValTmp.Text;
        }
        
        if (FromTmp.SelectedValue == "1" && ToTmp.SelectedValue == "2")
        {
            LblResult.Text = CalculateCenToFaren(VlrCalculate).ToString();
        }

        if (FromTmp.SelectedValue == "1" && ToTmp.SelectedValue == "3")
        {
            LblResult.Text = CalculateCenToKel(VlrCalculate).ToString();
        }

        if (FromTmp.SelectedValue == "2" && ToTmp.SelectedValue == "1")
        {
            LblResult.Text = CalculateFarenToCen(VlrCalculate).ToString();
        }

        if (FromTmp.SelectedValue == "2" && ToTmp.SelectedValue == "3")
        {
            LblResult.Text = CalculateFarenToKel(VlrCalculate).ToString();
        }

        if (FromTmp.SelectedValue == "3" && ToTmp.SelectedValue == "1")
        {
            LblResult.Text = CalculateKelToCen(VlrCalculate).ToString();
        }

        if (FromTmp.SelectedValue == "3" && ToTmp.SelectedValue == "2")
        {
            LblResult.Text = CalculateKelToFaren(VlrCalculate).ToString();
        }


    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        TxtValTmp.Text = "0";
        FromTmp.SelectedValue = "1";
        ToTmp.SelectedValue = "2";
        LblResult.Text = " ";

    }

    public decimal CalculateCenToFaren(decimal VlrCalculate)
    {
        //℉=(℃*1.8)+32 

        decimal total;
        // check that the parameters are valid
        total = (VlrCalculate * (decimal)1.8) + 32;

        return Math.Round(total, 2);

    }

    public decimal CalculateCenToKel(decimal VlrCalculate)
    {
        //K=℃+273.15  

        decimal total;
        // check that the parameters are valid
        total = VlrCalculate + (decimal)273.15;

        return Math.Round(total, 2);

    }

    public decimal CalculateFarenToCen(decimal VlrCalculate)
    {
        // ℃=(℉-32)/1.8  

        decimal total= 0.2m;
        // check that the parameters are valid
        total = (VlrCalculate - 32)/ (decimal)1.8;

        return Math.Round(total, 2);

    }

    public decimal CalculateFarenToKel(decimal VlrCalculate)
    {
        //K=((℉-32)/1.8)+273.15
        
        decimal total;
        // check that the parameters are valid
        total = ((VlrCalculate -32) / (decimal)1.8) + (decimal)273.15;

        return Math.Round(total, 2);

    }

    public decimal CalculateKelToCen(decimal VlrCalculate)
    {
        //℃=K-273.15 
        decimal total;
        // check that the parameters are valid
        total = VlrCalculate - (decimal)273.15;

        return Math.Round(total, 2);

    }

    public decimal CalculateKelToFaren(decimal VlrCalculate)
    {
        //℉=((K-273.15)*1.8)+32  
        decimal total;
        // check that the parameters are valid
        total = ((VlrCalculate - (decimal)273.15)* (decimal)1.8) + 32;

        return Math.Round(total, 2);

    }
}