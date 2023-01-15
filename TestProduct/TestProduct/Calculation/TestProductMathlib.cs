/*
 * Created by Ranorex
 * User: Vasilenok_e
 * Date: 29.11.2021
 * Time: 14:26
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace TestProduct
{
    /// <summary>
    /// Math method Collection
    /// </summary>
    [UserCodeCollection]
    public class TestProductMathlib
    {
    	
    	/// <summary>
    	/// Compare two double values, rounded to precision.
    	/// </summary>
    	[UserCodeMethod]
    	public static void ValueCompare(string Expected, string Actual, int precision)
    	{
			// double pr = 10^(-precision);
  			double Expected_Round = Math.Round(double.Parse(Expected), precision);
  			double Actual_Round = Math.Round(double.Parse(Actual), precision);
    		if (Math.Abs(Expected_Round - Actual_Round) == 0)
    			{
    				Ranorex.Report.Success(Actual_Round.ToString(), "actual and excpected values are equal");
    			}
    		else
    			{
    				Ranorex.Report.Info(Actual.ToString(), "actual value in cell");
    				Ranorex.Report.Failure(Actual_Round.ToString(), "values are not equal (actual round)");
    				Ranorex.Report.Failure(Expected_Round.ToString(), "values are not equal (excpected round)");
    			}
    	}
    }
}
