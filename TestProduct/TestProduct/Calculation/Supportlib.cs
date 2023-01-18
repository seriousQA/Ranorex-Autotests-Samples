/*
 * Created by Ranorex
 * User: Vasilenok_e
 * Date: 16.12.2021
 * Time: 15:58
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
    /// TestProduct Support methods library.
    /// </summary>
    [UserCodeCollection]
    public class Supportlib
    {
    	/// <summary>
    	/// Operations > Calculation (gui).
    	/// </summary>
    	[UserCodeMethod]
    	public static void Calculation()
    	{
    		var repo = TestProductRepository.TestProductRepository.Instance;
    		
    		repo.ProjectWindow.Operations.Click();
    		Delay.Milliseconds(20);
    		repo.contextmenuitems.Calculation.Click();
    		Delay.Milliseconds(200);
    	}
    	
		/// <summary>
    	/// Selecting transformation parameters.
    	/// <param name="name">geodetic point name.</param>
    	/// <param name="x1">x-coordinate.</param>
    	/// for example, value="1234,005"
    	/// <param name="y1">y-coordinate.</param>
    	/// for example, value="5000,999"
    	/// <param name="alpha">rectangle.</param>
    	/// for example, value="50°40'30\"" (50 degrees, 40 minutes, 30 seconds (d°m′s″))
    	/// </summary>
    	[UserCodeMethod]
    	public static void LocalCalcDialog(string name, string x1, string y1, string alpha)
    	{
    		var repo = TestProductRepository.TestProductRepository.Instance;

    		repo.SelectTransformationParameters.Create.Click();
    		repo.SelectTransformationParameters.QExpandingLineEdit.TextValue = name;
    		Delay.Seconds(1);    		
    		repo.SelectTransformationParameters.ItemWidget.Click();
    		repo.SelectTransformationParameters.N1_2.Click();
    		repo.SelectTransformationParameters.Typ.DoubleClick();
			repo.ComboDropdown.Helmert.MoveTo();
			repo.ComboDropdown.Helmert.Click();
			repo.SelectTransformationParameters.x1.DoubleClick();
			repo.SelectTransformationParameters.QtSpinboxLineedit.TextValue = x1;
			repo.SelectTransformationParameters.y1.Click();
			repo.SelectTransformationParameters.y1.PressKeys(y1);
			repo.SelectTransformationParameters.alpha.Click();
			repo.SelectTransformationParameters.alpha.PressKeys(alpha);
			repo.SelectTransformationParameters.OKBtn.Click();
			Delay.Milliseconds(30); 			
    	}
    	
    	/// <summary>
    	/// Universal Import Point (gui).
    	/// <param name="product">the test product name.</param>
    	/// <param name="filename">the file name with file-format.</param>
    	/// for example, value="5_426.txt"
    	/// </summary>
    	[UserCodeMethod]
    	public static void UniversalImportPoint(string product, string filename)
    	{
    		var repo = TestProductRepository.TestProductRepository.Instance;
			
			// File > Points table 1 > Import points with pattern
            repo.ProjectWindow.File.Click();
            repo.MenuFile.PointsTable1.Click();
            repo.contextmenuitems.ImportPointPattern.Click();
			
			// Customise the import: Template > Properties	
			repo.ImportPointWithPattern.Pattern.Click();
			repo.contextmenuitems.MenuItemProperties.Click();
			
			// Restore utility
			repo.ImportTemplateSettings.RestoreUtility.Click();
			repo.ImportSettings.OKBtn.Click();
			
			// Import pattern settings > Separators
			repo.ImportTemplateSettings.TemplateSettings.Click();
			repo.ImportTemplateSettings.Separators.Click();
			repo.ImportTemplateSettings.Separators.PressKeys("{LControlKey down}{Akey}{DELETE}");
			Delay.Milliseconds(10);	
			repo.ImportTemplateSettings.Separators.TextValue = ";";
			Delay.Milliseconds(10);
			repo.ImportTemplateSettings.OKBtn .Click();
			
			// Open file *.txt without zone number
			repo.ImportPointWithPattern.MainWindow.Open.Click();
			repo.OpenFile.PreviousLocations.Click();
			repo.OpenFile.Text41477.TextValue = "c:\\Ranorex\\" + product + "\\FolderImport\\Data_for_tests\\";
			Keyboard.Press("{Return}");
			repo.OpenFile.FileName.TextValue = filename;
			repo.OpenFile.OpenBtn.Click();
			
			// Import points with pattern > Import	
			repo.ImportPointWithPattern.MainWindow.Import.Click();
			Delay.Milliseconds(100);	
    	}
    	
    	/// <summary>
    	/// Representation of the East.
    	/// </summary>
    	[UserCodeMethod]
    	public static void EastRepresentation()
    	{
    		var repo = TestProductRepository.TestProductRepository.Instance;
    		
    		repo.ProjectWindow.File.Click();
			repo.MenuFile.ProjectProperties.Click();
			repo.ProjectConfDialog.Parameters.Click();
			repo.ProjectConfDialog.NZone.DoubleClick();
			repo.ComboDropdown.ListItemYes.Click();
			repo.ProjectConfDialog.Apply.Click();
			repo.ProjectConfDialog.OKBtn.Click();
    	}
    	
    	/// <summary>
    	/// Select the user Coordinate System (left panel).
    	/// <param name="CSname">the user Coordinate System name.</param>
    	/// </summary>
    	[UserCodeMethod]
    	public static void SelectUserCoordinateSystemLeft(string CSname)
    	{
    		var repo = TestProductRepository.TestProductRepository.Instance;
    		
    		repo.ProjectWindow.LeftWidget.Local.Click();
            repo.TransformParamWidget.Local.DoubleClick();
            repo.ComboDropdown.ImportFromGeodeticLibrary.Click();
			if (CSname=="CK-42 (GOST 32453-2017)")
            {
            	repo.SelectCoordinateSystem.GeodeticCS.DoubleClick();
            	repo.SelectCoordinateSystem.CS.EnsureVisible();
            	repo.SelectCoordinateSystem.CS.Click();
            }
            else
            {
				repo.SelectCoordinateSystem.ItemWidget.ExpandAll();
				repo.SelectCoordinateSystem.CS.EnsureVisible();
            	repo.SelectCoordinateSystem.CS.Click();
            }
            repo.SelectCoordinateSystem.OKBtn.Click();
            repo.TransformParamWidget.OKBtn.Click();
    	}    	
    	
    	/// <summary>
    	/// Select the user Coordinate System (right panel).
    	/// <param name="CSname">the user Coordinate System name.</param>
    	/// </summary>
    	[UserCodeMethod]
    	public static void SelectUserCoordinateSystemRight(string CSname)
    	{
    		var repo = TestProductRepository.TestProductRepository.Instance;
    		
    		repo.ProjectWindow.RightWidget.Local.Click();
            repo.TransformParamWidget.Local.DoubleClick();
            repo.ComboDropdown.ImportFromGeodeticLibrary.Click();            
            if (CSname=="CK-42 (GOST 32453-2017)")
            {
            	repo.SelectCoordinateSystem.GeodeticCS.DoubleClick();
            	repo.SelectCoordinateSystem.CS.EnsureVisible();
            	repo.SelectCoordinateSystem.CS.Click();
            }
            else
            {
				repo.SelectCoordinateSystem.ItemWidget.ExpandAll();
				repo.SelectCoordinateSystem.CS.EnsureVisible();
            	repo.SelectCoordinateSystem.CS.Click();
            }
            repo.SelectCoordinateSystem.OKBtn.Click();
            repo.TransformParamWidget.OKBtn.Click();
    	}    	
    	
    	/// <summary>
    	/// Cretae a new CS with parameters.
    	/// <param name="CSname">the user Coordinate System name.</param>
    	/// <param name="ZoneWidthValue">the width value of Zone ("Non-standard" or "3" or "6").</param>
    	/// <param name="ZoneNumberValue">the numer of Zone.</param>
    	/// <param name="AxialMeridianValue">the Axial Meridian value.</param>
    	/// <param name="N0Value">the value of N0.</param>
    	/// <param name="E0Value">the value of E0.</param>
    	/// </summary>
    	[UserCodeMethod]
    	public static void CreateNewCoordinateSystem(string CSname, string ZoneWidthValue, 
    	                                             string ZoneNumberValue, string AxialMeridianValue,
    	                                             string N0Value, string E0Value)
    	{
    		var repo = TestProductRepository.TestProductRepository.Instance;
    		
    		// File > Geodesic Library
			repo.ProjectWindow.File.Click();
			repo.MenuFile.GeodesicLibrary.Click();
			repo.GeodeticLibraryDialog.CoordinateSystems.Click();
			
			// Geodetic Library > Create coordinate system (CS) > Select Transverse Mercator projection
			repo.GeodeticLibraryDialog.Splitter.Create.Click();
			repo.SetProjectionType.List.Click();
			repo.ComboDropdown.TransverseMercator.Click();
			repo.GeodeticLibraryDialog.OKBtn.Click();
			
			// Rename the new CS to 'CSname'
			repo.GeodeticLibraryDialog.ParamWidget.NewCS.DoubleClick();
			repo.GeodeticLibraryDialog.Splitter.QLineEdit.TextValue = CSname;
			
			// Datum > CK-42 (GOST 32453-2017)
			repo.GeodeticLibraryDialog.ParamWidget.WGS84.DoubleClick();
			repo.ComboDropdown.CK42GOST.Click();
			
			// Zone width > "Non-standard" or "3" or "6"
			if(!ZoneWidthValue.IsEmpty())
			{
							repo.GeodeticLibraryDialog.ParamWidget.ZoneWidth.DoubleClick();
							repo.ComboDropdown.ListItenZoneWidth.Click();
			}
			
			// Zone number
			if(!ZoneNumberValue.IsEmpty())
			{
				repo.GeodeticLibraryDialog.ParamWidget.ZoneNo.DoubleClick();
				repo.GeodeticDataLibrary.QLineEdit.TextValue = ZoneNumberValue;
			}
			
			// Axial Meridian 
			if(!AxialMeridianValue.IsEmpty())
			{
				repo.GeodeticLibraryDialog.ParamWidget.AxisMeridian.DoubleClick();
				repo.GeodeticLibraryDialog.Splitter.QtSpinboxLineedit.TextValue = AxialMeridianValue;
			}
			
			// N0 
			if(!N0Value.IsEmpty())
			{
				repo.GeodeticLibraryDialog.ParamWidget.No.DoubleClick();
				repo.GeodeticLibraryDialog.Splitter.QtSpinboxLineedit.TextValue = N0Value;
			}
			
			// E0 
			if(!E0Value.IsEmpty())
			{
            	repo.GeodeticLibraryDialog.ParamWidget.Eo.DoubleClick();	
            	repo.GeodeticLibraryDialog.Splitter.QtSpinboxLineedit.TextValue = E0Value;
			}

            repo.GeodeticLibraryDialog.Apply.Click();
            repo.GeodeticLibraryDialog.OKBtn.Click();
    	}
    }
}
