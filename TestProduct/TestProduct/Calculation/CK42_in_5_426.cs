/*
 * Created by Ranorex
 * User: Vasilenok_E
 * Date: 13.01.2018
 * Time: 15:11
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
    /// Calculate the coordinates from CS 'CK-42 (GOST 32453-2017)' coordinate system 
    /// to the CS 'CK 1942 zone 5 (5_426)' coordinate system. CS = coordinate system.
    /// </summary>
    [TestModule("97F3C891-096D-46C8-86DB-3FB2D3EB4771", ModuleType.UserCode, 1)]
    public class CK42_in_5_426 : ITestModule
    {
        /// <summary>
        /// 1) Creating of CS CK 1942 zone 5 (5_426).
        /// 2) Select the required window pane for each CS.
        /// </summary>
        public CK42_in_5_426()
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
            // Creating of CS CK 1942 zone 5 (5_426)
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
			
			// Rename the new CS to 5_426
			repo.GeodeticLibraryDialog.ParamWidget.NewCS.DoubleClick();
			repo.GeodeticLibraryDialog.Splitter.QLineEdit.TextValue = "5_426";
			
			// Datum > CK-42 (GOST 32453-2017)
			repo.GeodeticLibraryDialog.ParamWidget.WGS84.DoubleClick();
			repo.ComboDropdown.CK42GOST.Click();
			
			// Zone number > 5
			repo.GeodeticLibraryDialog.ParamWidget.CellWidhZone.DoubleClick();
			repo.ComboDropdown.ListItem6Deg.Click();
			repo.GeodeticLibraryDialog.ParamWidget.CellZone.DoubleClick();
			repo.ComboDropdown.ListItem5.Click();
            
            // Eo > 500 000
            repo.GeodeticLibraryDialog.ParamWidget.Eo.DoubleClick();	
            repo.GeodeticLibraryDialog.Splitter.QtSpinboxLineedit.TextValue = "500000";
            repo.GeodeticLibraryDialog.Apply.Click();
            repo.GeodeticLibraryDialog.OKBtn.Click();
            // ===========================================================================
            
            /// <summary>
            /// Left panel Transformation points (Widget) > Select Coordinate System > CS CK-42 (GOST 32453-2017)
			/// <param name="CSname">the user Coordinate System name.</param>
			/// </summary>
			TestProduct.Supportlib.SelectUserCoordinateSystemLeft("CK-42 (GOST 32453-2017)");            
 
            /// <summary>
            /// Right panel Transformation points (Widget) > Select Coordinate System > CS CK 1942 zone 5 (5_426)
			/// <param name="CSname">the user Coordinate System name.</param>
			/// </summary>
            TestProduct.Supportlib.SelectUserCoordinateSystemRight("5_426"); 
            
            // Representation of the East 
			TestProduct.Supportlib.EastRepresentation();		
        }
    }
}
