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
            
            // ===========================================================================
            // Creating of CS CK 1942 zone 24 (24_426)
            // ===========================================================================
            
			// File > Geodesic Library
			repo.ProjectWindow.File.Click();
			repo.MenuFile.GeodesicLibrary.Click();
			repo.GeodeticLibraryDialog.CoordinateSystems.Click();
			
			// Geodetic Library > Create coordinate system (CS) > Select Transverse Mercator projection
			repo.GeodeticLibraryDialog.Splitter.Create.Click();
			repo.SetProjectionType.List.Click();
			repo.ComboDropdown.TransverseMercator.Click();
			repo.SetProjectionType.OKBtn.Click();
			
			// Rename the new CS to 24_426
			repo.GeodeticLibraryDialog.ParamWidget.NewCS.DoubleClick();
			repo.GeodeticLibraryDialog.Splitter.QLineEdit.TextValue = "24_426";
			
			// Datum > CK-42 (GOST 32453-2017)
			repo.GeodeticLibraryDialog.ParamWidget.WGS84.DoubleClick();
			repo.ComboDropdown.CK42GOST.Click();
			
			// Zone width > 6 deg
			repo.GeodeticLibraryDialog.ParamWidget.ZoneWidth.DoubleClick();
			repo.ComboDropdown.ListItem6Deg.Click();
			
			// Zone number > 24
			repo.GeodeticLibraryDialog.ParamWidget.ZoneNo.DoubleClick();
			repo.GeodeticDataLibrary.QLineEdit.PressKeys("{NumPad2}{NumPad4}{Return}");
            
            // Eo > 500 000
            repo.GeodeticLibraryDialog.ParamWidget.Eo.DoubleClick();	
            repo.GeodeticLibraryDialog.Splitter.QtSpinboxLineedit.TextValue = "500000";
            repo.GeodeticLibraryDialog.Apply.Click();
            repo.GeodeticLibraryDialog.OKBtn.Click();
            // ===========================================================================
			
			// ===========================================================================
            // Creating of CS Cax_423
            // ===========================================================================
			
            // File > Geodesic Library
			repo.ProjectWindow.File.Click();
			repo.MenuFile.GeodesicLibrary.Click();
			
			// Geodetic Library > Create coordinate system (CS) > Select Transverse Mercator projection
			repo.GeodeticLibraryDialog.Splitter.Create.Click();
			repo.SetProjectionType.List.Click();
			repo.ComboDropdown.TransverseMercator.Click();
			repo.SetProjectionType.OKBtn.Click();
			
			// Rename the new CS to Cax_423
			repo.GeodeticLibraryDialog.ParamWidget.NewCS.DoubleClick();
			repo.GeodeticLibraryDialog.Splitter.QLineEdit.TextValue = "Cax_423";
			
			// Datum > CK-42 (GOST 32453-2017)
			repo.GeodeticLibraryDialog.ParamWidget.WGS84.DoubleClick();
			repo.ComboDropdown.CK42GOST.Click();
			
			// Zone width > 3 deg
			repo.GeodeticLibraryDialog.ParamWidget.ZoneWidth.DoubleClick();
			repo.ComboDropdown.ListItem3Deg.Click();
			
			// Zone number > 47
			repo.GeodeticLibraryDialog.ParamWidget.ZoneNo.DoubleClick();
			repo.GeodeticDataLibrary.QLineEdit.PressKeys("{NumPad4}{NumPad7}{Return}");	
			
           // Eo > 250 000
            repo.GeodeticLibraryDialog.ParamWidget.Eo.DoubleClick();	
            repo.GeodeticLibraryDialog.Splitter.QtSpinboxLineedit.TextValue = "250000";
            repo.GeodeticLibraryDialog.Apply.Click();
            repo.GeodeticLibraryDialog.OKBtn.Click();
            
            // ===========================================================================
           
			/// <summary>
            /// Left panel Transformation points (Widget) > Select Coordinate System > CS CK 1942 zone 24 (24_426)
			/// <param name="CSname">the user Coordinate System name.</param>
			/// </summary>
			TestProduct.Supportlib.SelectUserCoordinateSystemLeft("24_426");            
 
            /// <summary>
            /// Right panel Transformation points (Widget) > Select Coordinate System > CS Cax_423
			/// <param name="CSname">the user Coordinate System name.</param>
			/// </summary>
            TestProduct.Supportlib.SelectUserCoordinateSystemRight("Cax_423"); 
            
            // Representation of the East
            TestProduct.Supportlib.EastRepresentation();
        }
    }
}
