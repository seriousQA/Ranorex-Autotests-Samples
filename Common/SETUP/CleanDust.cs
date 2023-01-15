/*
 * Created by Ranorex
 * User: Vasilenok_e
 * Date: 05.02.2019
 * Time: 12:31
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

namespace SETUP
{
	/// <summary>
	/// Clean Dust.
	/// <param name="regeditFolder">the name of registry folder of your application.</param>
	/// </summary>	
    [TestModule("86EBD88D-358B-477A-9943-549F1C60C6E0", ModuleType.UserCode, 1)]
    public class CleanDust : ITestModule
    { 
    	
    	string _regeditFolder = "";
    	[TestVariable("c5588e7b-e6bf-4f52-ae50-21b4759ac3bd")]
    	public string regeditFolder
    	{
    		get { return _regeditFolder; }
    		set { _regeditFolder = value; }
    	}
    	        
        public CleanDust()
        {
            // Do not delete - a parameterless constructor is required!
        }

        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
                        
            // Delete from the registry the key for application.
            SETUPlib.REGdelete(regeditFolder);
            
            // Remove such traces of a test program like \Documents, \Roaming and s.o.
            SETUPlib.RMDIR(regeditFolder);
            Delay.Seconds(2);
            
        }
    }
}
