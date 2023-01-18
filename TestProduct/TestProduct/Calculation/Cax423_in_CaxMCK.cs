/*
 * Created by Ranorex
 * User: Vasilenok_E
 * Date: 20.01.2018
 * Time: 12:36
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

namespace Calculation
{
    /// <summary>
    /// Calculate the coordinates from CS 'Cax_423' coordinate system 
    /// to the CS 'CaxMCK' coordinate system. CS = coordinate system.
    /// </summary>
    [TestModule("91D2AE54-9B12-44EF-A18A-C46BF0EE0D59", ModuleType.UserCode, 1)]
    public class Cax423_in_CaxMCK : ITestModule
    {
        /// <summary>
        /// 1) Creating of CS CaxMCK.
        /// 2) Creating of CS Cax_423.
        /// 3) Select the required window pane for each CS.
        /// </summary>
        public Cax423_in_CaxMCK()
        {
            // Do not delete - a parameterless constructor is required!
        }

        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            var repo = TestProductRepository.TestProductRepository.Instance;

            // Creating of CS CaxMCK
            string CSname1 = "Cax_MCK";
            string ZoneWidthValue1 = "";
            string ZoneNumberValue1 = "";
            string AxialMeridianValue1 = "141°57'00,00\"";
            string N0Value1 = "-5781357,63";
            string E0Value1 = "25000";
            
            TestProduct.Supportlib.CreateNewCoordinateSystem(CSname1, ZoneWidthValue1, ZoneNumberValue1, 
                                                             AxialMeridianValue1, N0Value1, E0Value1);
			
            // Creating of CS Cax_423
            string CSname2 = "Cax_423";
            string ZoneWidthValue2 = "3";
            string ZoneNumberValue2 = "47";
            string AxialMeridianValue2 = "";
            string N0Value2 = "";
            string E0Value2 = "250000";
            
			TestProduct.Supportlib.CreateNewCoordinateSystem(CSname2, ZoneWidthValue2, ZoneNumberValue2, 
                                                             AxialMeridianValue2, N0Value2, E0Value2);  
            
            /// Left panel Transformation points (Widget) > Select Coordinate System > CS Cax423  
			TestProduct.Supportlib.SelectUserCoordinateSystemLeft(CSname2);            

            /// Right panel Transformation points (Widget) > Select Coordinate System > CS CaxMCK
            TestProduct.Supportlib.SelectUserCoordinateSystemRight(CSname1); 
        }
	}
}
