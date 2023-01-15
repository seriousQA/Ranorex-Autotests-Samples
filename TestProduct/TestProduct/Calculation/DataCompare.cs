/*
 * Created by Ranorex
 * User: Vasilenok_e
 * Date: 25.11.2021
 * Time: 18:09
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
    /// 1) Calculating from Geodetic coordinate system to Earth-centered coordinate system.
    /// 2) Compare x,y,z values by rows (actual - in TestProduct, expected - in data source).
    /// In data source values have benn verified by calculations in Mathcad by A. Kiselevich. 
    /// </summary>
	[TestModule("4F42A03A-60E0-4913-B027-4A2C44F2E304", ModuleType.UserCode, 1)]
    public class DataCompare : ITestModule
    { 
    	string _X = "";
    	[TestVariable("043544f2-0e17-44d6-8c4e-e9beb39bfb89")]
    	public string X
    	{
    		get { return _X; }
    		set { _X = value;}
    	}
    	
    	string _Y = "";
    	[TestVariable("7bd230f1-3bf1-4110-9d5a-2d3989fc9233")]
    	public string Y
    	{
    		get { return _Y; }
    		set { _Y = value;}
    	}
    	
    	string _Z = "";
    	[TestVariable("c5147e61-2de7-45d5-8238-e281b62658bb")]
    	public string Z
    	{
    		get { return _Z; }
    		set { _Z = value;}
    	}
    	
    	string _B = "";
    	[TestVariable("cd7394bf-d487-4f87-9fa5-13941253df47")]
    	public string B
    	{
    		get { return _B; }
    		set { _B = value; }
    	}
    	
    	string _L = "";
    	[TestVariable("f8b6be3e-6704-4d18-87ab-267e81c5a151")]
    	public string L
    	{
    		get { return _L; }
    		set { _L = value; }
    	}
    	
    	string _N = "";
    	[TestVariable("a6a73771-1c27-40b5-9dca-6e9ef4ba54d6")]
    	public string N
    	{
    		get { return _N; }
    		set { _N = value; }
    	}
    	
    	string _E = "";
    	[TestVariable("8a39a544-2338-4a99-a42c-9c47a0a855bf")]
    	public string E
    	{
    		get { return _E; }
    		set { _E = value; }
    	}
    	
    	string _He = "";
    	[TestVariable("724f0c95-e455-4ec6-8033-ff398aebfd34")]
    	public string He
    	{
    		get { return _He; }
    		set { _He = value; }
    	}
    	
    	string _Hn = "";
    	[TestVariable("628147fb-7365-456c-b31d-6458a9ac48e9")]
    	public string Hn
    	{
    		get { return _Hn; }
    		set { _Hn = value; }
    	}
    	
    	
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            // 	get current Test Container
			var curTestContainer = (TestCaseNode) TestSuite.Current.CurrentTestContainer;
			
			// get all rows of the data source that is currently set
			Ranorex.Core.Data.RowCollection rows = curTestContainer.DataContext.Source.Rows;
			
			// rows count
			int AllRows = rows.Count;
			Ranorex.Report.Info(AllRows.ToString(), "rows in data source");			
			
			// compare x,y,z values by rows
				
			// get row index from data source
			// in data source rowIndex/columnIndex starts with 1 (not with 0)
			// in TestProduct rowIndex/columnIndex starts with 0, therefore (CurrentRowIndex - 1) 
			int rowIndex = (curTestContainer.DataContext.CurrentRowIndex - 1);
			
			if (!X.IsEmpty())
			{
				// compare x.value (actual) with x.value (expected) from data source
				int columnIndex_X = 1;
				Cell CTTrgCellX = Cell.FromPath("/form[@name='ProjectWindow']//form[@name~'Widget']/table[@name~'PointItemView']/row[@index="+ rowIndex +"]/cell[@columnindex="+ columnIndex_X +"]");
				TestProductMathlib.ValueCompare(X, CTTrgCellX.Text, 3);
				Delay.Milliseconds(3);
			}
			
			if (!B.IsEmpty())
			{
				// compare B.value (actual) with x.value (expected) from data source
				int columnIndex_B = 1;
				Cell CTTrgCellB = Cell.FromPath("/form[@name='ProjectWindow']//form[@name~'Widget']/table[@name~'PointItemView']/row[@index="+ rowIndex +"]/cell[@columnindex="+ columnIndex_B +"]");
				TestProductMathlib.ValueCompare(B, CTTrgCellB.Text, 9);
				Delay.Milliseconds(3);
			}
			
			if (!N.IsEmpty())
			{
				// compare x.value (actual) with x.value (expected) from data source
				int columnIndex_N = 1;
				Cell CTTrgCellN = Cell.FromPath("/form[@name='ProjectWindow']//form[@name~'Widget']/table[@name~'PointItemView']/row[@index="+ rowIndex +"]/cell[@columnindex="+ columnIndex_N +"]");
				TestProductMathlib.ValueCompare(N, CTTrgCellN.Text, 3);
				Delay.Milliseconds(3);
			}
			
			if (!Y.IsEmpty())
			{
				// compare y.value (actual) with y.value (expected) from data source
				int columnIndex_Y = 2;
				Cell CTTrgCellY = Cell.FromPath("/form[@name='ProjectWindow']//form[@name~'Widget']/table[@name~'PointItemView']/row[@index="+ rowIndex +"]/cell[@columnindex="+ columnIndex_Y +"]");
				TestProductMathlib.ValueCompare(Y, CTTrgCellY.Text, 3);
				Delay.Milliseconds(3);
			}
			
			if (!L.IsEmpty())
			{
				// compare L.value (actual) with y.value (expected) from data source
				int columnIndex_L = 2;
				Cell CTTrgCellL = Cell.FromPath("/form[@name='ProjectWindow']//form[@name~'Widget']/table[@name~'PointItemView']/row[@index="+ rowIndex +"]/cell[@columnindex="+ columnIndex_L +"]");
				TestProductMathlib.ValueCompare(L, CTTrgCellL.Text, 9);
				Delay.Milliseconds(3);
			}
			
			if (!E.IsEmpty())
			{
				// compare x.value (actual) with x.value (expected) from data source
				int columnIndex_E = 2;
				Cell CTTrgCellE = Cell.FromPath("/form[@name='ProjectWindow']//form[@name~'Widget']/table[@name~'PointItemView']/row[@index="+ rowIndex +"]/cell[@columnindex="+ columnIndex_E +"]");
				TestProductMathlib.ValueCompare(E, CTTrgCellE.Text, 3);
				Delay.Milliseconds(3);
			}
			
			if (!Z.IsEmpty())
			{					
				// compare z.value (actual) with z.value (expected) from data source
				int columnIndex_Z = 3;
				Cell CTTrgCellZ = Cell.FromPath("/form[@name='ProjectWindow']//form[@name~'Widget']/table[@name~'PointItemView']/row[@index="+ rowIndex +"]/cell[@columnindex="+ columnIndex_Z +"]");
				TestProductMathlib.ValueCompare(Z, CTTrgCellZ.Text, 3);
				Delay.Milliseconds(3);
			}
			
			if (!Hn.IsEmpty())
			{
				// return a value from current data connector row and given column
				int columnIndex_Hn = curTestContainer.DataContext.Source.Columns["Hn"].Index;
				
				// compare Hn.value (actual) with z.value (expected) from data source
				//int columnIndex_Hn = (HnColumnIndex - 1);
				Cell CTTrgCellHe = Cell.FromPath("/form[@name='ProjectWindow']//form[@name~'Widget']/table[@name~'PointItemView']/row[@index="+ rowIndex +"]/cell[@columnindex="+ columnIndex_Hn +"]");
				TestProductMathlib.ValueCompare(Hn, CTTrgCellHe.Text, 3);
				Delay.Milliseconds(3);
			}
			
			if (!He.IsEmpty())
			{
				// return a value from current data connector row and given column
				int columnIndex_He = curTestContainer.DataContext.Source.Columns["He"].Index;
				
				// compare He.value (actual) with z.value (expected) from data source
				//int columnIndex_He = (HeColumnIndex - 1);
				Cell CTTrgCellHe = Cell.FromPath("/form[@name='ProjectWindow']//form[@name~'Widget']/table[@name~'PointItemView']/row[@index="+ rowIndex +"]/cell[@columnindex="+ columnIndex_He +"]");
				TestProductMathlib.ValueCompare(He, CTTrgCellHe.Text, 3);
				Delay.Milliseconds(3);
			}
        }
    }
}