/*
 * Created by Ranorex
 * User: Vasilenok_E
 * Date: 13.01.2018
 * Time: 19:02
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
    /// Calculate the coordinates from CS \CK 1942 zone 5 (5_426)\ coordinate system 
    /// to the CS \CK-42 (GOST 32453-2017)\ coordinate system. CS = coordinate system.
    /// </summary>
    [TestModule("21D212AD-9047-4192-B700-226F225D4F2A", ModuleType.UserCode, 1)]
    public class N5_426_in_CK42 : ITestModule
    {
        /// <summary>
        /// 1) Creating of CS CK 1942 zone 5 (5_426).
        /// 2) Select the required window pane for each CS.
        /// </summary>
        public N5_426_in_CK42()
        {
            // Do not delete - a parameterless constructor is required!
        }

        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
			var repo = TestProductRepository.TestProductRepository.Instance;
           			
			// Creating of CS CK 1942 zone 5 (5_426)
            string CSname1 = "5_426";
            string ZoneWidthValue1 = "6";
            string ZoneNumberValue1 = "5";
            string AxialMeridianValue1 = "";
            string N0Value1 = "";
            string E0Value1 = "500000";
            
            TestProduct.Supportlib.CreateNewCoordinateSystem(CSname1, ZoneWidthValue1, ZoneNumberValue1, 
                                                             AxialMeridianValue1, N0Value1, E0Value1);
            
            // Left panel Transformation points (Widget) > Select Coordinate System > SC CK 1942 zone 5 (5_426)  
			TestProduct.Supportlib.SelectUserCoordinateSystemLeft(CSname1);  
			
            // Right panel Transformation points (Widget) > Select Coordinate System > SC CK-42 (GOST 32453-2017)
            TestProduct.Supportlib.SelectUserCoordinateSystemRight("CK-42 (GOST 32453-2017)");            
        }
    }
}
