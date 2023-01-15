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
    /// Calculate the coordinates from CK 1942 zone 5 (5_426) coordinate system to the CK-42 (GOST 32453-2017) coordinate system.
    /// CS = coordinate system.
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
            
            // Left panel Transformation points (Widget) > Select Coordinate System > SC CK 1942 zone 5 (5_426)    
            repo.ProjectWindow.DocWidget.Local.Click();
            repo.TransformParamWidget.Local.DoubleClick();
            repo.ComboDropdown.ImportFromGeodeticLibrary.Click();
			repo.SelectCoordinateSystem.ItemWidget.ExpandAll();
			repo.SelectCoordinateSystem.CS5_426.EnsureVisible();
            repo.SelectCoordinateSystem.CS5_426.Click();
            repo.SelectCoordinateSystem.OKBtn.Click();
            repo.TransformParamWidget.OKBtn.Click();
            
            // Right panel Transformation points (Widget) > Select Coordinate System > SC CK-42 (GOST 32453-2017)   
            repo.ProjectWindow.Widget.Local.Click();
            repo.TransformParamWidget.Local.DoubleClick();
            repo.ComboDropdown.ImportFromGeodeticLibrary.Click();
            repo.SelectCoordinateSystem.GeodeticCS.DoubleClick();
            repo.SelectCoordinateSystem.CK42GOST.Click();
            repo.SelectCoordinateSystem.OKBtn.Click();
            repo.TransformParamWidget.OKBtn.Click();
        }
    }
}
