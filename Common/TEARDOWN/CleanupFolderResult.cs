/*
 * Created by Ranorex
 * User: Vasilenok_e
 * Date: 25.02.2019
 * Time: 16:12
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
using System.IO;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace TEARDOWN
{
    /// <summary>
    /// Description of CleanupFolderResultNiv.
    /// </summary>
    [TestModule("EC77FF2A-911A-4116-B5A3-A6232AE06BC8", ModuleType.UserCode, 1)]
    public class CleanupFolderResult : ITestModule
    { 
         string _product = "";
         [TestVariable("839ca9af-2c13-46ee-a49e-957041dc1871")]
         public string product
         {
         	get { return _product; }
         	set { _product = value; }
         }
         
    	/// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CleanupFolderResult()
        {
            // Do not delete - a parameterless constructor is required!
        }
       
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            TEARDOWNlib.CleanupFolderResult(product);
        }
    }
}
