﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace TestProductRepository.StartPopupWatcher
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the StartPopupWatcherRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("8ff4a2c8-e4aa-4b95-97f5-5576edb6ee7b")]
    public partial class StartPopupWatcherRepository : RepoGenBaseFolder
    {
        static StartPopupWatcherRepository instance = new StartPopupWatcherRepository();
        StartPopupWatcherRepositoryFolders.FileReplaceDialogAppFolder _filereplacedialog;
        StartPopupWatcherRepositoryFolders.ImportSettingsAppFolder _importsettings;
        StartPopupWatcherRepositoryFolders.ExportDialogAppFolder _exportdialog;
        StartPopupWatcherRepositoryFolders.ExplorerMessageAppFolder _explorermessage;
        StartPopupWatcherRepositoryFolders.QMessageBoxAppFolder _qmessagebox;

        /// <summary>
        /// Gets the singleton class instance representing the StartPopupWatcherRepository element repository.
        /// </summary>
        [RepositoryFolder("8ff4a2c8-e4aa-4b95-97f5-5576edb6ee7b")]
        public static StartPopupWatcherRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public StartPopupWatcherRepository() 
            : base("StartPopupWatcherRepository", "/", null, 0, false, "8ff4a2c8-e4aa-4b95-97f5-5576edb6ee7b", ".\\RepositoryImages\\StartPopupWatcherRepository8ff4a2c8.rximgres")
        {
            _filereplacedialog = new StartPopupWatcherRepositoryFolders.FileReplaceDialogAppFolder(this);
            _importsettings = new StartPopupWatcherRepositoryFolders.ImportSettingsAppFolder(this);
            _exportdialog = new StartPopupWatcherRepositoryFolders.ExportDialogAppFolder(this);
            _explorermessage = new StartPopupWatcherRepositoryFolders.ExplorerMessageAppFolder(this);
            _qmessagebox = new StartPopupWatcherRepositoryFolders.QMessageBoxAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("8ff4a2c8-e4aa-4b95-97f5-5576edb6ee7b")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FileReplaceDialog folder.
        /// </summary>
        [RepositoryFolder("013f3f0c-f1ad-4ea3-8c96-afb106948229")]
        public virtual StartPopupWatcherRepositoryFolders.FileReplaceDialogAppFolder FileReplaceDialog
        {
            get { return _filereplacedialog; }
        }

        /// <summary>
        /// The ImportSettings folder.
        /// </summary>
        [RepositoryFolder("6531c7bf-9cad-48b1-ab10-82a71c1f0587")]
        public virtual StartPopupWatcherRepositoryFolders.ImportSettingsAppFolder ImportSettings
        {
            get { return _importsettings; }
        }

        /// <summary>
        /// The ExportDialog folder.
        /// </summary>
        [RepositoryFolder("16ebe8dc-8644-411b-ba3f-4061fa8b3aae")]
        public virtual StartPopupWatcherRepositoryFolders.ExportDialogAppFolder ExportDialog
        {
            get { return _exportdialog; }
        }

        /// <summary>
        /// The ExplorerMessage folder.
        /// </summary>
        [RepositoryFolder("a1b01a09-4f85-40c4-ab90-c25c23bc7252")]
        public virtual StartPopupWatcherRepositoryFolders.ExplorerMessageAppFolder ExplorerMessage
        {
            get { return _explorermessage; }
        }

        /// <summary>
        /// The QMessageBox folder.
        /// </summary>
        [RepositoryFolder("94586ecb-8ccc-4fd3-99bc-d76758ef79aa")]
        public virtual StartPopupWatcherRepositoryFolders.QMessageBoxAppFolder QMessageBox
        {
            get { return _qmessagebox; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class StartPopupWatcherRepositoryFolders
    {
        /// <summary>
        /// The FileReplaceDialogAppFolder folder.
        /// </summary>
        [RepositoryFolder("013f3f0c-f1ad-4ea3-8c96-afb106948229")]
        public partial class FileReplaceDialogAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _replaceallbtnInfo;
            RepoItemInfo _skipallbtnInfo;

            /// <summary>
            /// Creates a new FileReplaceDialog  folder.
            /// </summary>
            public FileReplaceDialogAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FileReplaceDialog", "/form[@name='FileReplaceDialog']", parentFolder, 30000, null, true, "013f3f0c-f1ad-4ea3-8c96-afb106948229", "")
            {
                _replaceallbtnInfo = new RepoItemInfo(this, "ReplaceAllBtn", "button[@name='replaceAll' and @type='QPushButton']", "", 30000, null, "e4c6df77-4e70-47ed-b317-464fe66b0960");
                _skipallbtnInfo = new RepoItemInfo(this, "SkipAllBtn", "button[@name='skipAll' and @type='QPushButton']", "", 30000, null, "71cc0893-30d0-4564-b469-474f1e8d2a7a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("013f3f0c-f1ad-4ea3-8c96-afb106948229")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("013f3f0c-f1ad-4ea3-8c96-afb106948229")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ReplaceAllBtn item.
            /// </summary>
            [RepositoryItem("e4c6df77-4e70-47ed-b317-464fe66b0960")]
            public virtual Ranorex.Button ReplaceAllBtn
            {
                get
                {
                    return _replaceallbtnInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ReplaceAllBtn item info.
            /// </summary>
            [RepositoryItemInfo("e4c6df77-4e70-47ed-b317-464fe66b0960")]
            public virtual RepoItemInfo ReplaceAllBtnInfo
            {
                get
                {
                    return _replaceallbtnInfo;
                }
            }

            /// <summary>
            /// The SkipAllBtn item.
            /// </summary>
            [RepositoryItem("71cc0893-30d0-4564-b469-474f1e8d2a7a")]
            public virtual Ranorex.Button SkipAllBtn
            {
                get
                {
                    return _skipallbtnInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The SkipAllBtn item info.
            /// </summary>
            [RepositoryItemInfo("71cc0893-30d0-4564-b469-474f1e8d2a7a")]
            public virtual RepoItemInfo SkipAllBtnInfo
            {
                get
                {
                    return _skipallbtnInfo;
                }
            }
        }

        /// <summary>
        /// The ImportSettingsAppFolder folder.
        /// </summary>
        [RepositoryFolder("6531c7bf-9cad-48b1-ab10-82a71c1f0587")]
        public partial class ImportSettingsAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _okbtnInfo;

            /// <summary>
            /// Creates a new ImportSettings  folder.
            /// </summary>
            public ImportSettingsAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ImportSettings", "/form[@name='ImportSettings']", parentFolder, 30000, null, true, "6531c7bf-9cad-48b1-ab10-82a71c1f0587", "")
            {
                _okbtnInfo = new RepoItemInfo(this, "OKBtn", "?/?/button[@text='OK']", "", 30000, null, "ede38051-7a20-4ef8-a2ea-1f7663998889");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6531c7bf-9cad-48b1-ab10-82a71c1f0587")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("6531c7bf-9cad-48b1-ab10-82a71c1f0587")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The OKBtn item.
            /// </summary>
            [RepositoryItem("ede38051-7a20-4ef8-a2ea-1f7663998889")]
            public virtual Ranorex.Button OKBtn
            {
                get
                {
                    return _okbtnInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The OKBtn item info.
            /// </summary>
            [RepositoryItemInfo("ede38051-7a20-4ef8-a2ea-1f7663998889")]
            public virtual RepoItemInfo OKBtnInfo
            {
                get
                {
                    return _okbtnInfo;
                }
            }
        }

        /// <summary>
        /// The ExportDialogAppFolder folder.
        /// </summary>
        [RepositoryFolder("16ebe8dc-8644-411b-ba3f-4061fa8b3aae")]
        public partial class ExportDialogAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _okbtnInfo;

            /// <summary>
            /// Creates a new ExportDialog  folder.
            /// </summary>
            public ExportDialogAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ExportDialog", "/form[@name='ExportDialog']", parentFolder, 30000, null, true, "16ebe8dc-8644-411b-ba3f-4061fa8b3aae", "")
            {
                _okbtnInfo = new RepoItemInfo(this, "OKBtn", "?/?/button[@text='OK']", "", 30000, null, "ab4d1d7a-b45d-41f1-9ed3-3d2f20dcdfb4");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("16ebe8dc-8644-411b-ba3f-4061fa8b3aae")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("16ebe8dc-8644-411b-ba3f-4061fa8b3aae")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The OKBtn item.
            /// </summary>
            [RepositoryItem("ab4d1d7a-b45d-41f1-9ed3-3d2f20dcdfb4")]
            public virtual Ranorex.Button OKBtn
            {
                get
                {
                    return _okbtnInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The OKBtn item info.
            /// </summary>
            [RepositoryItemInfo("ab4d1d7a-b45d-41f1-9ed3-3d2f20dcdfb4")]
            public virtual RepoItemInfo OKBtnInfo
            {
                get
                {
                    return _okbtnInfo;
                }
            }
        }

        /// <summary>
        /// The ExplorerMessageAppFolder folder.
        /// </summary>
        [RepositoryFolder("a1b01a09-4f85-40c4-ab90-c25c23bc7252")]
        public partial class ExplorerMessageAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _okbtnInfo;

            /// <summary>
            /// Creates a new ExplorerMessage  folder.
            /// </summary>
            public ExplorerMessageAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ExplorerMessage", "/form[@title='Explorer']", parentFolder, 30000, null, true, "a1b01a09-4f85-40c4-ab90-c25c23bc7252", "")
            {
                _okbtnInfo = new RepoItemInfo(this, "OKBtn", "?/?/element[@instance='0']/button[@text='ОК']", "", 30000, null, "391224e9-87cd-48ba-91e6-4467f4e8ed83");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a1b01a09-4f85-40c4-ab90-c25c23bc7252")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a1b01a09-4f85-40c4-ab90-c25c23bc7252")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The OKBtn item.
            /// </summary>
            [RepositoryItem("391224e9-87cd-48ba-91e6-4467f4e8ed83")]
            public virtual Ranorex.Button OKBtn
            {
                get
                {
                    return _okbtnInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The OKBtn item info.
            /// </summary>
            [RepositoryItemInfo("391224e9-87cd-48ba-91e6-4467f4e8ed83")]
            public virtual RepoItemInfo OKBtnInfo
            {
                get
                {
                    return _okbtnInfo;
                }
            }
        }

        /// <summary>
        /// The QMessageBoxAppFolder folder.
        /// </summary>
        [RepositoryFolder("94586ecb-8ccc-4fd3-99bc-d76758ef79aa")]
        public partial class QMessageBoxAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _okbtnInfo;

            /// <summary>
            /// Creates a new QMessageBox  folder.
            /// </summary>
            public QMessageBoxAppFolder(RepoGenBaseFolder parentFolder) :
                    base("QMessageBox", "/form[@type='QMessageBox' and @basetype='QMessageBox']", parentFolder, 30000, null, true, "94586ecb-8ccc-4fd3-99bc-d76758ef79aa", "")
            {
                _okbtnInfo = new RepoItemInfo(this, "OKBtn", "?/?/button[@text='OK']", "", 30000, null, "90070197-deaa-4fd3-b441-8c1f9db58300");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("94586ecb-8ccc-4fd3-99bc-d76758ef79aa")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("94586ecb-8ccc-4fd3-99bc-d76758ef79aa")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The OKBtn item.
            /// </summary>
            [RepositoryItem("90070197-deaa-4fd3-b441-8c1f9db58300")]
            public virtual Ranorex.Button OKBtn
            {
                get
                {
                    return _okbtnInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The OKBtn item info.
            /// </summary>
            [RepositoryItemInfo("90070197-deaa-4fd3-b441-8c1f9db58300")]
            public virtual RepoItemInfo OKBtnInfo
            {
                get
                {
                    return _okbtnInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
