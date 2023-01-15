/*
 * Created by Ranorex
 * User: Vasilenok_e
 * Date: 25.02.2019
 * Time: 16:13
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
using System.Diagnostics;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace TEARDOWN
{
    /// <summary>
    /// Close App
    /// </summary>
    [TestModule("3E0EBBE7-D1F6-4068-AF8A-D5CD1DBCC2B5", ModuleType.UserCode, 1)]
    public class CloseApp : ITestModule
    {  
     	
     	string _processName = "";
     	[TestVariable("1deb2bb6-9747-4ff3-a566-3bb75508825c")]
     	public string processName
     	{
     		get { return _processName; }
     		set { _processName = value; }
     	}
     	    	
    	
        public CloseApp()
        {
            // Do not delete - a parameterless constructor is required!
        }

        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
			TEARDOWNlib.KillProcessAndChildren(processName); 
    	}
	}
}