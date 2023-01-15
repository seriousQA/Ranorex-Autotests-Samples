/*
 * Created by Ranorex
 * User: Vasilenok_e
 * Date: 20.03.2019
 * Time: 18:06
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
using Ranorex.Core.Repository;  

namespace TestProduct
{
    /// <summary>
    /// Description of StartPopupWatcher.
    /// </summary>
    [TestModule("55C349C9-0F48-4031-BFC7-91BEA6E10ABC", ModuleType.UserCode, 1)]
    public class StartPopupWatcher : ITestModule
    {
        public static TestProductRepository.StartPopupWatcher.StartPopupWatcherRepository repo = TestProductRepository.StartPopupWatcher.StartPopupWatcherRepository.Instance;
        	
        public StartPopupWatcher()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            var myPopupWatcher = new PopupWatcher();
            
            myPopupWatcher.Watch(repo.FileReplaceDialog.SelfInfo, ConfirmDialog);
            myPopupWatcher.Watch(repo.ImportSettings.SelfInfo, ConfirmDialog);
            myPopupWatcher.Watch(repo.QMessageBox.SelfInfo, ConfirmDialog);
            myPopupWatcher.Watch(repo.ExportDialog.SelfInfo, ConfirmDialog);
			myPopupWatcher.Start();
            Report.Info("Info", "PopupWatcher started.");
        }
        
        public static void ConfirmDialog(Ranorex.Core.Repository.RepoItemInfo repoItemInfo, Ranorex.Core.Element myElement)
        {
        	if (repoItemInfo==repo.FileReplaceDialog.SelfInfo)
        	{
        		repo.FileReplaceDialog.ReplaceAllBtn.Click();
        	}        	
        	
        	if (repoItemInfo==repo.ImportSettings.SelfInfo)
        	{        		
        		repo.ImportSettings.OKBtn.Click();
        	}
        	
        	if (repoItemInfo==repo.QMessageBox.SelfInfo)
        	{
        		repo.QMessageBox.Self.As<QtElement>().InvokeMethod("Accept");
        	}
        	
        	if (repoItemInfo==repo.ExportDialog.SelfInfo)
        	{        		
        		repo.ExportDialog.OKBtn.Click();
        	} 
        }
    }
}
