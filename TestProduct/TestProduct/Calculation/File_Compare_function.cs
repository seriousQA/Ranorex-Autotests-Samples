/*
 * Created by Ranorex
 * User: Vasilenok_E
 * Date: 09.01.2018
 * Time: 19:47
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.IO;
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
    /// File compare function.
    /// </summary>
    [TestModule("BD46BC7E-96E4-4D42-B454-26C9E0DC8753", ModuleType.UserCode, 1)]
    public class File_Compare_function : ITestModule
    {
        /// <summary>
        /// File compare function.
        /// </summary>
        public File_Compare_function()
        {
            // Do not delete - a parameterless constructor is required!
        }

        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;            
        }
        
		/// <summary>
		///  Open a specific project.
		/// <param name="ResultFile">the Result file.</param>
		/// for example, value="25_426_result.csv"
		/// <param name="EtalonFile">the Etalon file.</param>
		/// for example, value="25_426_etalon.csv"
		/// </summary>    
    	public void Validate_FileTextEqual(string customLogMessage, string ResultFile, string EtalonFile)  
		{ 
			string filePath_Current = @"c:\Ranorex\" + ResultFile;
			string filePath_Expected = @"c:\Ranorex\" + EtalonFile;
			
    		// prepare log messages  
    		const string fileNotFoundMessage = "File not found for comparison in Validate_FileContentEqual: {0}";  
    		const string logMessage = "Comparing content of files ({0} vs. {1})";  
    		if (string.IsNullOrEmpty(customLogMessage))  
    		{  
        		customLogMessage = string.Format(logMessage, filePath_Expected, filePath_Current);  
    		}  
  
    		// check if file exists  
    		if (!System.IO.File.Exists(filePath_Current))  
    		{  
        		throw new Ranorex.RanorexException(string.Format(fileNotFoundMessage, filePath_Current));  
    		}  
  
    		// check if referencing file exists  
    		if (!System.IO.File.Exists(filePath_Expected))  
    		{  
        		throw new Ranorex.RanorexException(string.Format(fileNotFoundMessage, filePath_Expected));  
    		}  
  
    		// check if filenames are identical  
    		if (filePath_Expected.Equals(filePath_Current))  
    		{  
        		Ranorex.Validate.IsTrue(true, customLogMessage);  
    		}  
    		else  
    		{  
        		string current = System.IO.File.ReadAllText(filePath_Current);  
        		string expected = System.IO.File.ReadAllText(filePath_Expected);
        		
        		// validate whether expected value equals to current value  
        		Ranorex.Validate.AreEqual(current, expected, customLogMessage);  
    		}  
		}    
    }
}
 
  
    