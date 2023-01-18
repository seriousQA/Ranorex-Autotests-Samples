/*
 * Created by Ranorex
 * User: Vasilenok_E
 * Date: 20.01.2018
 * Time: 10:43
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
    /// Calculate the coordinates from CS 'CK 1942 zone 24 (24_426)' coordinate system 
    /// to the CS 'Cax_423' coordinate system. CS = coordinate system.
    /// </summary>
    [TestModule("3F51ABE0-B064-4EF4-AABC-2C45EB736D2B", ModuleType.UserCode, 1)]
    public class N24_426_in_Cax423 : ITestModule
    {
        /// <summary>
        /// 1) Creating of CS CK 1942 zone 24 (24_426).
        /// 2) Creating of CS Cax_423.
        /// 3) Select the required window pane for each CS.
        /// </summary>
        public N24_426_in_Cax423()
        {
            // Do not delete - a parameterless constructor is required!
        }

        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            var repo = TestProductRepository.TestProductRepository.Instance;
            
            // Creating of CS CK 1942 zone 24 (24_426)
            string CSname1 = "24_426";
            string ZoneWidthValue1 = "6";
            string ZoneNumberValue1 = "24";
            string AxialMeridianValue1 = "";
            string N0Value1 = "";
            string E0Value1 = "500000";
            
            TestProduct.Supportlib.CreateNewCoordinateSystem(CSname1, ZoneWidthValue1, ZoneNumberValue1, 
                                                             AxialMeridianValue1, N0Value1, E0Value1);
			
            // Creating  of CS Cax_423
            string CSname2 = "Cax_423";
            string ZoneWidthValue2 = "3";
            string ZoneNumberValue2 = "47";
            string AxialMeridianValue2 = "";
            string N0Value2 = "";
            string E0Value2 = "250000";
            
			TestProduct.Supportlib.CreateNewCoordinateSystem(CSname2, ZoneWidthValue2, ZoneNumberValue2, 
                                                             AxialMeridianValue2, N0Value2, E0Value2);
            
			// Left panel Transformation points (Widget) > Select Coordinate System > CS CK 1942 zone 24 (24_426)
			TestProduct.Supportlib.SelectUserCoordinateSystemLeft(CSname1); 
			
            // Right panel Transformation points (Widget) > Select Coordinate System > CS Cax_423
            TestProduct.Supportlib.SelectUserCoordinateSystemRight(CSname2); 
            
            // Representation of the East
            TestProduct.Supportlib.EastRepresentation();
        }
    }
}
