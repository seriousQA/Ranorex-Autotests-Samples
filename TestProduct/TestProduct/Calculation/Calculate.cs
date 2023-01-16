/*
 * Created by Ranorex
 * User: Vasilenok_e
 * Date: 16.12.2021
 * Time: 16:15
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
    /// Test Product > Operations > Calculation
    /// and if Transformation Widget exists then transformation of planar rectangular coordinates
    /// </summary>
    [TestModule("E38E1FC5-5F98-4D60-A766-4304647F795B", ModuleType.UserCode, 1)]
    public class Calculate : ITestModule
    {
        public Calculate()
        {
            // Do not delete - a parameterless constructor is required!
        }

        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            var repo = TestProductRepository.TestProductRepository.Instance;
			
			// Operations > Calculation
			Supportlib.Calculation();
			
			/// <summary>
    		/// Selecting transformation parameters
    		/// <param name="name"> point name.</param>
    		/// <param name="x1">plane coordinate x1 of initial  point (N).</param>
    		/// for example, value="1234,005"
    		/// <param name="y1">plane coordinate y1 of initial  point (E).</param>
    		/// for example, value="5000,999"
    		/// <param name="alpha">the angle of rotation of the new CS in relation to the CS being converted;.</param>
    		/// for example, value="05°40'30\"" (5 degrees, 40 minutes, 30 seconds (d°m′s″))
    		/// </summary>
			if (repo.SelectTransformationParameters.SelfInfo.Exists(100))
			{
				Supportlib.LocalCalcDialog("1_2", "2345,020", "6996,376", "45°00'00\"");
			}
			else
			{
				Ranorex.Report.Info("Dialog is not visible");
			}
        }
    }
}
