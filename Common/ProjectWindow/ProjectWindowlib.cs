/*
 * Created by Ranorex
 * User: Vasilenok_e
 * Date: 20.03.2019
 * Time: 19:36
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
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic.FileIO;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace ProjectWindow
{
	/// <summary>
    /// Project Window methods library.
    /// </summary>	
    [UserCodeCollection]
    public class ProjectWindowlib
    {    	
    	
    	/// <summary>
    	/// Check by path (ResultPath) that the file(s).* exist.
    	/// <param name="formatfile"> the file-format.</param>
    	/// <param name="product">the test product name.</param>
    	/// </summary>
    	[UserCodeMethod]
    	public static void CheckExistResultFile(string product, string formatfile)
    	{            
            string Path = "c:\\Ranorex\\" + product + "\\FolderResult\\";  
            DirectoryInfo dir = new DirectoryInfo(Path);
			FileInfo[] ResultFile = dir.GetFiles("*." + formatfile);
			if (ResultFile.Length == 0)
			{
    		Report.Info("no files present");
			}
			foreach (var fi in ResultFile)
    		Report.Info(ResultFile + "Exists");
    	}    	
    	
    	/// <summary>
    	/// Open the Project.
    	/// <param name="ProjectName">the project name.</param>
    	/// <param name="ProjectDir">the path to the Project.</param>
    	/// </summary>
    	[UserCodeMethod]
    	public static void OpenProject(string ProjectDir, string ProjectName)
    	{
    		var repo = TestProduct.ProjectWindowRepository.Instance;		

    		repo.ProjectWindow.File.Click();
			Delay.Milliseconds(10);
			repo.MenuFile.Open.Click();
			Delay.Seconds(6);
            
            // form ['Open Project']
            repo.OpenProject.PreviousLocations.Click();
            Delay.Milliseconds(10);
            repo.OpenProject.Text41477.TextValue = ProjectDir;
            Delay.Milliseconds(10);  
            Keyboard.Press("{Return}");
            repo.OpenProject.Text1148.Click();
            repo.OpenProject.Text1148.TextValue = ProjectName;
			Delay.Milliseconds(10);
			// All files (*.*)
			repo.OpenProject.ComboBox1136.Click();
			repo.List.AllFiles.MoveTo();
			repo.List.AllFiles.Click();
			Delay.Milliseconds(10);
			repo.OpenProject.OpenBtn.Click();
			Delay.Seconds(25);
    	}    	
    	
    	/// <summary>
    	/// Wait For Repo items 
    	/// </summary>
    	[UserCodeMethod]
    	public static void WaitForElementToBeDisplayed(RxPath rxPath, Duration timeInterval)
    	{
    		Duration waitTime = 3000;
    		Duration totalTimeout = 0;
    		Element myElement = null;
    		
    		while (!(Host.Local.TryFindSingle(rxPath, waitTime, out myElement)))
    		{
    			System.Threading.Thread.Sleep(waitTime.Milliseconds);
    			totalTimeout = totalTimeout + waitTime;
    			if (totalTimeout.Milliseconds > timeInterval.Milliseconds)
    			{
    				throw new ElementNotFoundException("Element not found");
    			}
    		}
    	}
    	
    }
}
