/*
 * Created by Ranorex
 * User: Vasilenok_e
 * Date: 28.02.2019
 * Time: 17:29
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

namespace ProjectWindow
{
	/// <summary>
    /// Open the Project module.
    /// <param name="ProjectName">the number of iterationse.</param>
    /// value="1" - run 3 times with Delay; value="2" - run 1 time
    /// <param name="ProjectName">the project name.</param>
    /// <param name="ProjectDir">the path to the Project.</param>
    /// /// </summary>
    [TestModule("8F8133CB-1F22-4EDD-ADBD-8D1E9E03C108", ModuleType.UserCode, 1)]
    public class OpenProject : ITestModule
    {
        string _flag = "";
        [TestVariable("9f242ec8-1f25-41c7-bfc4-c3c3b421a428")]
        public string flag
        {
        	get { return _flag; }
        	set { _flag = value; }
        }

        string _ProjectDir = "";
        [TestVariable("abb84af0-f2a1-4a41-a386-1f01f5de9d20")]
        public string ProjectDir
        {
        	get { return _ProjectDir; }
        	set { _ProjectDir = value; }
        } 
        
        string _ProjectName = "";
        [TestVariable("e3040480-fba1-4550-893a-9adf53ffac8f")]
        public string ProjectName
        {
        	get { return _ProjectName; }
        	set { _ProjectName = value; }
        }
    
        public OpenProject()
        {
            // Do not delete - a parameterless constructor is required!
        }
	
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
		      
            if (flag.Equals("1"))
            {
            for (int i=0; i<2; i++)
            {
            	ProjectWindowlib.OpenProject(ProjectDir, ProjectName);
            }
            	Delay.Seconds(5);
            	ProjectWindowlib.OpenProject(ProjectDir, ProjectName);
            }
            else
            {
            	ProjectWindowlib.OpenProject(ProjectDir, ProjectName);
            }
            Delay.Seconds(5);
        }
    }
}
