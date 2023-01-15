/*
 * Created by Ranorex
 * User: Vasilenok_E
 * Date: 12.01.2018
 * Time: 12:23
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
    /// UniversalImportPoint module.
    /// <param name="product">the test product name.</param>
    /// <param name="filename">the file name with file-format.</param>
    /// for example, value="5_426.txt"
    /// </summary>
    [TestModule("5E042CA2-80AB-48D6-A40A-00AB4ECBCA13", ModuleType.UserCode, 1)]
    public class UniversalImportPoint : ITestModule
    {       
       string _product = "";
       [TestVariable("3dc6b21c-4bd1-46d3-b305-f3675f840148")]
       public string product
       {
       	get { return _product; }
       	set { _product = value; }
       }
       
       string _filename = "";
       [TestVariable("3b806930-7db3-42fe-a1ac-09ca8cb31329")]
       public string filename
       {
       	get { return _filename; }
       	set { _filename = value; }
       }       

       void ITestModule.Run()
       {
           Mouse.DefaultMoveTime = 300;
           Keyboard.DefaultKeyPressTime = 100;
           Delay.SpeedFactor = 1.0;
           

           Supportlib.UniversalImportPoint(product, filename);
       }
    }
}
