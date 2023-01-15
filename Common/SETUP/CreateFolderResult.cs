/*
 * Created by Ranorex
 * User: Vasilenok_e
 * Date: 05.02.2019
 * Time: 15:38
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
using Microsoft.VisualBasic.FileIO;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace SETUP
{
    /// <summary>
	/// Create Folder Result
	/// </summary>	
    [TestModule("32877A38-2494-4A1B-913E-02569762A433", ModuleType.UserCode, 1)]
    public class CreateFolderResult : ITestModule
    {
       
        public CreateFolderResult()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        string _product = "";
        [TestVariable("18dcce64-a515-4167-886c-5154227dc370")]
        public string product
        {
        	get { return _product; }
        	set { _product = value; }
        }
        
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;  
                        
            SETUPlib.CreateFolderResult(product);
        }
        
        
    }
}
