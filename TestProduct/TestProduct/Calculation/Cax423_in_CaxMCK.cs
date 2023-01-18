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
            
            // Cax423 in CaxMCK
            
            var repo = TestProductRepository.TestProductRepository.Instance;
            
			// ===========================================================================
            // Creating of CS CaxMCK
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
            
            // Rename the new CS to Cax_MCK
			repo.GeodeticLibraryDialog.ParamWidget.NewCS.DoubleClick();
			repo.GeodeticLibraryDialog.Splitter.QLineEdit.TextValue = "Cax_MCK";
			
			// Datum > CK-42 (GOST 32453-2017)
			repo.GeodeticLibraryDialog.ParamWidget.WGS84.DoubleClick();
			repo.ComboDropdown.CK42GOST.Click();
			
            // Eo > 250 000
            repo.GeodeticLibraryDialog.ParamWidget.Eo.DoubleClick();	
            repo.GeodeticLibraryDialog.Splitter.QtSpinboxLineedit.TextValue = "25000";
            
			// N0			
			repo.GeodeticLibraryDialog.ParamWidget.No.DoubleClick();
			repo.GeodeticLibraryDialog.Splitter.QtSpinboxLineedit.TextValue = "-5781357,63";
			
			// Axial Meridian 
			repo.GeodeticLibraryDialog.ParamWidget.AxisMeridian.DoubleClick();
			repo.GeodeticLibraryDialog.Splitter.QtSpinboxLineedit.TextValue = "141°57'00,00\"";			
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
            /// Left panel Transformation points (Widget) > Select Coordinate System > CS Cax423  
			/// <param name="CSname">the user Coordinate System name.</param>
			/// </summary>
			TestProduct.Supportlib.SelectUserCoordinateSystemLeft("Cax_423");            
 
            /// <summary>
            /// Right panel Transformation points (Widget) > Select Coordinate System > CS CaxMCK
			/// <param name="CSname">the user Coordinate System name.</param>
			/// </summary>
            TestProduct.Supportlib.SelectUserCoordinateSystemRight("Cax_MCK"); 
        }
	}
}
