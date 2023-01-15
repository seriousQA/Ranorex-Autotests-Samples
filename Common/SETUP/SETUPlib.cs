/*
 * Created by Ranorex
 * User: Vasilenok_e
 * Date: 19.12.2018
 * Time: 12:17
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
using Microsoft.Win32;
using System.Security.Principal;
using Microsoft.VisualBasic.FileIO;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace SETUP
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class SETUPlib
    {
    	/// <summary>
		/// Create a ResultFolder for each test product.
		/// <param name="product">the test product name.</param>
		/// </summary>
    	[UserCodeMethod]
    	public static void CreateFolderResult(string product)
    	{
    		string FolderResult = "c:\\Ranorex\\" + product + "\\FolderResult\\";
            FileSystem.CreateDirectory(FolderResult);
            Delay.Milliseconds(10);
    	}
    	
    	/// <summary>
    	/// Run 32-bit or 64-bit application.
    	/// <param name="FullExePathX86">full path to *.exe file (32-bit application).</param>
		/// <param name="ShortBinPathX86">short path to Bin folder (32-bit application).</param>
		/// <param name="FullExePathX64">full path to *.exe file (64-bit application).</param>
		/// <param name="ShortBinPathX64">short path to Bin folder (64-bit application).</param>
    	/// </summary>
    	[UserCodeMethod]
    	public static void FirstOpenApp(string FullExePathX86, string ShortBinPathX86, string FullExePathX64, string ShortBinPathX64)
    	{
    		if (File.Exists(FullExePathX86))
    		{
    	    	Host.Local.RunApplication(FullExePathX86, "", ShortBinPathX86, false);
    	    	Delay.Seconds(3);
    		}
    		else
    		{
    	    	Host.Local.RunApplication(FullExePathX64, "", ShortBinPathX64, false);
    	    	Delay.Seconds(3);
    		}
    	}
    	
    	/// <summary>
    	/// FirstRunDialog > "C:/Ranorex/" + product + "/FolderResult/Templates" > OK 
    	/// </summary>
    	[UserCodeMethod]
    	public static void FirstRunDialogPath(string product)
    	{
    		var repo = SETUPRepository.Instance;
    		
    		repo.FirstRunDialog.Path.Click();
            Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}{Delete}");
            repo.FirstRunDialog.Path.TextValue = "C:/Ranorex/" + product + "/FolderResult";
            Delay.Seconds(5);
            repo.FirstRunDialog.OKBtn.Click();
            Delay.Seconds(5);
    	} 
    	
    	/// <summary>
		/// Delete from the registry the key for application.
		/// key name = variable
		/// <param name="regeditFolder">the name of registry folder of your application.</param>
		/// </summary>
    	[UserCodeMethod]
    	public static void REGdelete(string regeditFolder)
    	{
			RegistryKey keyName  = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE", true);
    		if (keyName == null)
    		{
    			
    		}
			else 
			{
				keyName.DeleteSubKeyTree(regeditFolder, false);
				keyName.Close();
			}
    	}
    	    	
    	/// <summary>
		/// Remove such traces of a test program like \Documents, \Roaming and s.o.
		/// <param name="regeditFolder">the name of registry folder of your application.</param>
		/// </summary>>
    	[UserCodeMethod]
    	public static void RMDIR(string regeditFolder)
    	{
    		string pathGdsLibrary = @"c:\%HOMEPATH%\AppData\Roaming\GdsLibrary";
    		if (Directory.Exists(Environment.ExpandEnvironmentVariables(pathGdsLibrary)))
    			{
    			DirectoryInfo GdsLibrary = new DirectoryInfo(Environment.ExpandEnvironmentVariables(pathGdsLibrary));
        		GdsLibrary.Delete(true);
    			}
    		string pathDocuments = @"c:\%HOMEPATH%\Documents\" + regeditFolder;
    		if (Directory.Exists(Environment.ExpandEnvironmentVariables(pathDocuments)))
    			{
    			DirectoryInfo Documents = new DirectoryInfo(Environment.ExpandEnvironmentVariables(pathDocuments));
        		Documents.Delete(true);
    			}
			// Roaming folder with files   
			string pathRoaming = @"c:\%HOMEPATH%\AppData\Roaming\" + regeditFolder;
			pathRoaming = Environment.ExpandEnvironmentVariables(pathRoaming);
			
			if (Directory.Exists(pathRoaming))
    		{
				// search for *.ini	in folder and delete	
				string[] fileList1 = Directory.GetFiles(pathRoaming, "*.ini");
    			foreach (string f1 in fileList1)
   				{
        			File.Delete(f1);
    			}
    			
    			// search for *.xml	in folder and delete	
				string[] fileList2 = Directory.GetFiles(pathRoaming, "*.xml");
    			foreach (string f2 in fileList2)
   				{
        			File.Delete(f2);
    			}
			}
    	}    
    	
    	/// <summary>
		/// StartDialog > CreateNewProject (gui)
		/// </summary>
    	[UserCodeMethod]
    	public static void StartDialogCreateNewProject()
    	{
    		var repo = SETUPRepository.Instance;    		
    		repo.StartDialog.CreateNewProject.Click();
            Delay.Seconds(15);
    	}
    	    	
    	/// <summary>
		///  Open a specific project.
		/// <param name="patchProject">path to the project.</param>
		/// for example, value="C:/Ranorex/.../Projects/">
		/// <param name="nameProject">the project name.</param>
		/// for example, value="myProject.docx">
		/// </summary>
    	[UserCodeMethod]
    	public static void OpenProjectStartDialog(string patchProject, string nameProject)
    	{
    		var repo = SETUPRepository.Instance;    		
    		repo.StartDialog.OpenProject.Click();
            Delay.Milliseconds(10);
            
            // form ['Open Project']
            repo.OpenProject.PreviousLocations.Click();
            Delay.Milliseconds(10);
            repo.OpenProject.Text41477.TextValue = patchProject;
            Delay.Milliseconds(10);  
            Keyboard.Press("{Return}");
            repo.OpenProject.Text1148.Click();
            repo.OpenProject.Text1148.TextValue = nameProject;
			Delay.Milliseconds(10);
			// All files (*.*)
			repo.OpenProject.ComboBox1136.Click();
			repo.List.AllFiles.MoveTo();
			repo.List.AllFiles.Click();
			Delay.Milliseconds(10);
			repo.OpenProject.OpenBtn.Click();
			Delay.Seconds(3);
    	}
    	
    	/// <summary>
		/// Resize a window to actually monitor resolution.
		/// </summary>
    	[UserCodeMethod]
    	public static void ResizeWindow()
    	{
    		var repo = SETUPRepository.Instance;
    		
    		Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
    		repo.ProjectWindow.Self.Resize(resolution.Width, resolution.Height);
    	}
    	
    	/// <summary> 
		/// Remove from \FolderResult all files created during the test run.
		/// <param name="product">the test product name.</param>
		/// </summary>
    	[UserCodeMethod]
    	public static void DeleteFilesFromDIR(string product)
    	{
    		string FolderResult = @"c:\\Ranorex\\" + product + "\\FolderResult\\";
    		if (Directory.Exists(Environment.ExpandEnvironmentVariables(FolderResult)))
    		{
    			DirectoryInfo dirInfo = new DirectoryInfo(Environment.ExpandEnvironmentVariables(FolderResult));
        		foreach (FileInfo file in dirInfo.GetFiles())
				{
    				file.Delete();
				}
    		}
    	}  
    }
}
