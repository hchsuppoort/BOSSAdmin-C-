using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Explorer1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing&&components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        internal ToolStripContainer ToolStripContainer;
        internal ImageList TreeNodeImageList;
        internal ToolStripSeparator ToolStripSeparator7;
        internal ToolStripSeparator ToolStripSeparator8;
        internal ToolStrip ToolStrip;
        internal ToolStripButton BackToolStripButton;
        internal ToolStripButton ForwardToolStripButton;
        internal ToolStripButton FoldersToolStripButton;
        internal ToolStripDropDownButton ListViewToolStripButton;
        internal ToolStripMenuItem ListToolStripMenuItem;
        internal ToolStripMenuItem DetailsToolStripMenuItem;
        internal ToolStripMenuItem LargeIconsToolStripMenuItem;
        internal ToolStripMenuItem SmallIconsToolStripMenuItem;
        internal ToolStripMenuItem TileToolStripMenuItem;
        internal MenuStrip MenuStrip;
        internal ToolStripMenuItem FileToolStripMenuItem;
        internal ToolStripMenuItem NewToolStripMenuItem;
        internal ToolStripMenuItem OpenToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripMenuItem SaveToolStripMenuItem;
        internal ToolStripMenuItem SaveAsToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripMenuItem PrintToolStripMenuItem;
        internal ToolStripMenuItem PrintPreviewToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripMenuItem ExitToolStripMenuItem;
        internal ToolStripMenuItem EditToolStripMenuItem;
        internal ToolStripMenuItem UndoToolStripMenuItem;
        internal ToolStripMenuItem RedoToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator4;
        internal ToolStripMenuItem CutToolStripMenuItem;
        internal ToolStripMenuItem CopyToolStripMenuItem;
        internal ToolStripMenuItem PasteToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator5;
        internal ToolStripMenuItem SelectAllToolStripMenuItem;
        internal ToolStripMenuItem ViewToolStripMenuItem;
        internal ToolStripMenuItem ToolBarToolStripMenuItem;
        internal ToolStripMenuItem StatusBarToolStripMenuItem;
        internal ToolStripMenuItem FoldersToolStripMenuItem;
        internal ToolStripMenuItem ToolsToolStripMenuItem;
        internal ToolStripMenuItem OptionsToolStripMenuItem;
        internal ToolStripMenuItem HelpToolStripMenuItem;
        internal ToolStripMenuItem ContentsToolStripMenuItem;
        internal ToolStripMenuItem IndexToolStripMenuItem;
        internal ToolStripMenuItem SearchToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator6;
        internal ToolStripMenuItem AboutToolStripMenuItem;
        internal SplitContainer SplitContainer;
        internal TreeView TreeView;
        internal ListView ListView;
        internal StatusStrip StatusStrip;
        internal ToolStripStatusLabel ToolStripStatusLabel;
        internal ToolTip ToolTip;
        internal ImageList ListViewLargeImageList;
        internal ImageList ListViewSmallImageList;

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Explorer1));
            StatusStrip=new StatusStrip();
            ToolStripStatusLabel=new ToolStripStatusLabel();
            TreeNodeImageList=new ImageList(components);
            ToolStrip=new ToolStrip();
            BackToolStripButton=new ToolStripButton();
            ForwardToolStripButton=new ToolStripButton();
            ToolStripSeparator7=new ToolStripSeparator();
            FoldersToolStripButton=new ToolStripButton();
            FoldersToolStripButton.Click+=new EventHandler(FoldersToolStripButton_Click);
            ToolStripSeparator8=new ToolStripSeparator();
            ListViewToolStripButton=new ToolStripDropDownButton();
            ListToolStripMenuItem=new ToolStripMenuItem();
            ListToolStripMenuItem.Click+=new EventHandler(ListToolStripMenuItem_Click);
            DetailsToolStripMenuItem=new ToolStripMenuItem();
            DetailsToolStripMenuItem.Click+=new EventHandler(DetailsToolStripMenuItem_Click);
            LargeIconsToolStripMenuItem=new ToolStripMenuItem();
            LargeIconsToolStripMenuItem.Click+=new EventHandler(LargeIconsToolStripMenuItem_Click);
            SmallIconsToolStripMenuItem=new ToolStripMenuItem();
            SmallIconsToolStripMenuItem.Click+=new EventHandler(SmallIconsToolStripMenuItem_Click);
            TileToolStripMenuItem=new ToolStripMenuItem();
            TileToolStripMenuItem.Click+=new EventHandler(TileToolStripMenuItem_Click);
            MenuStrip=new MenuStrip();
            FileToolStripMenuItem=new ToolStripMenuItem();
            NewToolStripMenuItem=new ToolStripMenuItem();
            OpenToolStripMenuItem=new ToolStripMenuItem();
            OpenToolStripMenuItem.Click+=new EventHandler(OpenToolStripMenuItem_Click);
            ToolStripSeparator1=new ToolStripSeparator();
            SaveToolStripMenuItem=new ToolStripMenuItem();
            SaveAsToolStripMenuItem=new ToolStripMenuItem();
            SaveAsToolStripMenuItem.Click+=new EventHandler(SaveAsToolStripMenuItem_Click);
            ToolStripSeparator2=new ToolStripSeparator();
            PrintToolStripMenuItem=new ToolStripMenuItem();
            PrintPreviewToolStripMenuItem=new ToolStripMenuItem();
            ToolStripSeparator3=new ToolStripSeparator();
            ExitToolStripMenuItem=new ToolStripMenuItem();
            ExitToolStripMenuItem.Click+=new EventHandler(ExitToolStripMenuItem_Click);
            EditToolStripMenuItem=new ToolStripMenuItem();
            UndoToolStripMenuItem=new ToolStripMenuItem();
            RedoToolStripMenuItem=new ToolStripMenuItem();
            ToolStripSeparator4=new ToolStripSeparator();
            CutToolStripMenuItem=new ToolStripMenuItem();
            CopyToolStripMenuItem=new ToolStripMenuItem();
            PasteToolStripMenuItem=new ToolStripMenuItem();
            ToolStripSeparator5=new ToolStripSeparator();
            SelectAllToolStripMenuItem=new ToolStripMenuItem();
            ViewToolStripMenuItem=new ToolStripMenuItem();
            ToolBarToolStripMenuItem=new ToolStripMenuItem();
            ToolBarToolStripMenuItem.Click+=new EventHandler(ToolBarToolStripMenuItem_Click);
            StatusBarToolStripMenuItem=new ToolStripMenuItem();
            StatusBarToolStripMenuItem.Click+=new EventHandler(StatusBarToolStripMenuItem_Click);
            FoldersToolStripMenuItem=new ToolStripMenuItem();
            FoldersToolStripMenuItem.Click+=new EventHandler(FoldersToolStripMenuItem_Click);
            ToolsToolStripMenuItem=new ToolStripMenuItem();
            OptionsToolStripMenuItem=new ToolStripMenuItem();
            HelpToolStripMenuItem=new ToolStripMenuItem();
            ContentsToolStripMenuItem=new ToolStripMenuItem();
            IndexToolStripMenuItem=new ToolStripMenuItem();
            SearchToolStripMenuItem=new ToolStripMenuItem();
            ToolStripSeparator6=new ToolStripSeparator();
            AboutToolStripMenuItem=new ToolStripMenuItem();
            ToolTip=new ToolTip(components);
            ToolStripContainer=new ToolStripContainer();
            SplitContainer=new SplitContainer();
            TreeView=new TreeView();
            TreeView.AfterSelect+=new TreeViewEventHandler(TreeView_AfterSelect);
            ListView=new ListView();
            ListViewLargeImageList=new ImageList(components);
            ListViewSmallImageList=new ImageList(components);
            StatusStrip.SuspendLayout();
            ToolStrip.SuspendLayout();
            MenuStrip.SuspendLayout();
            ToolStripContainer.BottomToolStripPanel.SuspendLayout();
            ToolStripContainer.ContentPanel.SuspendLayout();
            ToolStripContainer.TopToolStripPanel.SuspendLayout();
            ToolStripContainer.SuspendLayout();
            SplitContainer.Panel1.SuspendLayout();
            SplitContainer.Panel2.SuspendLayout();
            SplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // StatusStrip
            // 
            StatusStrip.Dock=DockStyle.None;
            StatusStrip.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel });
            StatusStrip.Location=new Point(0, 0);
            StatusStrip.Name="StatusStrip";
            StatusStrip.Size=new Size(632, 22);
            StatusStrip.TabIndex=6;
            StatusStrip.Text="StatusStrip";
            // 
            // ToolStripStatusLabel
            // 
            ToolStripStatusLabel.Name="ToolStripStatusLabel";
            ToolStripStatusLabel.Size=new Size(38, 17);
            ToolStripStatusLabel.Text="Status";
            // 
            // TreeNodeImageList
            // 
            TreeNodeImageList.ImageStream=(ImageListStreamer)resources.GetObject("TreeNodeImageList.ImageStream");
            TreeNodeImageList.TransparentColor=Color.Transparent;
            TreeNodeImageList.Images.SetKeyName(0, "ClosedFolder");
            TreeNodeImageList.Images.SetKeyName(1, "OpenFolder");
            // 
            // ToolStrip
            // 
            ToolStrip.Anchor=AnchorStyles.Right;
            ToolStrip.Dock=DockStyle.None;
            ToolStrip.Items.AddRange(new ToolStripItem[] { BackToolStripButton, ForwardToolStripButton, ToolStripSeparator7, FoldersToolStripButton, ToolStripSeparator8, ListViewToolStripButton });
            ToolStrip.Location=new Point(3, 24);
            ToolStrip.Name="ToolStrip";
            ToolStrip.Size=new Size(231, 25);
            ToolStrip.TabIndex=0;
            ToolStrip.Text="ToolStrip1";
            // 
            // BackToolStripButton
            // 
            BackToolStripButton.Enabled=false;
            BackToolStripButton.Image=(Image)resources.GetObject("BackToolStripButton.Image");
            BackToolStripButton.ImageTransparentColor=Color.Black;
            BackToolStripButton.Name="BackToolStripButton";
            BackToolStripButton.Size=new Size(49, 22);
            BackToolStripButton.Text="Back";
            BackToolStripButton.ToolTipText="Back to the previous item";
            // 
            // ForwardToolStripButton
            // 
            ForwardToolStripButton.Enabled=false;
            ForwardToolStripButton.Image=(Image)resources.GetObject("ForwardToolStripButton.Image");
            ForwardToolStripButton.ImageTransparentColor=Color.Black;
            ForwardToolStripButton.Name="ForwardToolStripButton";
            ForwardToolStripButton.Size=new Size(67, 22);
            ForwardToolStripButton.Text="Forward";
            ForwardToolStripButton.ToolTipText="Move forward to the next item";
            // 
            // ToolStripSeparator7
            // 
            ToolStripSeparator7.Name="ToolStripSeparator7";
            ToolStripSeparator7.Size=new Size(6, 25);
            // 
            // FoldersToolStripButton
            // 
            FoldersToolStripButton.Checked=true;
            FoldersToolStripButton.CheckState=CheckState.Checked;
            FoldersToolStripButton.Image=(Image)resources.GetObject("FoldersToolStripButton.Image");
            FoldersToolStripButton.ImageTransparentColor=Color.Black;
            FoldersToolStripButton.Name="FoldersToolStripButton";
            FoldersToolStripButton.Size=new Size(62, 22);
            FoldersToolStripButton.Text="Folders";
            FoldersToolStripButton.ToolTipText="Toggle Folders View";
            // 
            // ToolStripSeparator8
            // 
            ToolStripSeparator8.Name="ToolStripSeparator8";
            ToolStripSeparator8.Size=new Size(6, 25);
            // 
            // ListViewToolStripButton
            // 
            ListViewToolStripButton.DisplayStyle=ToolStripItemDisplayStyle.Image;
            ListViewToolStripButton.DropDownItems.AddRange(new ToolStripItem[] { ListToolStripMenuItem, DetailsToolStripMenuItem, LargeIconsToolStripMenuItem, SmallIconsToolStripMenuItem, TileToolStripMenuItem });
            ListViewToolStripButton.Image=(Image)resources.GetObject("ListViewToolStripButton.Image");
            ListViewToolStripButton.ImageTransparentColor=Color.Black;
            ListViewToolStripButton.Name="ListViewToolStripButton";
            ListViewToolStripButton.Size=new Size(29, 22);
            ListViewToolStripButton.Text="Views";
            // 
            // ListToolStripMenuItem
            // 
            ListToolStripMenuItem.Name="ListToolStripMenuItem";
            ListToolStripMenuItem.Size=new Size(130, 22);
            ListToolStripMenuItem.Text="List";
            // 
            // DetailsToolStripMenuItem
            // 
            DetailsToolStripMenuItem.Checked=true;
            DetailsToolStripMenuItem.CheckState=CheckState.Checked;
            DetailsToolStripMenuItem.Name="DetailsToolStripMenuItem";
            DetailsToolStripMenuItem.Size=new Size(130, 22);
            DetailsToolStripMenuItem.Text="Details";
            // 
            // LargeIconsToolStripMenuItem
            // 
            LargeIconsToolStripMenuItem.Name="LargeIconsToolStripMenuItem";
            LargeIconsToolStripMenuItem.Size=new Size(130, 22);
            LargeIconsToolStripMenuItem.Text="Large Icons";
            // 
            // SmallIconsToolStripMenuItem
            // 
            SmallIconsToolStripMenuItem.Name="SmallIconsToolStripMenuItem";
            SmallIconsToolStripMenuItem.Size=new Size(130, 22);
            SmallIconsToolStripMenuItem.Text="Small Icons";
            // 
            // TileToolStripMenuItem
            // 
            TileToolStripMenuItem.Name="TileToolStripMenuItem";
            TileToolStripMenuItem.Size=new Size(130, 22);
            TileToolStripMenuItem.Text="Tile";
            // 
            // MenuStrip
            // 
            MenuStrip.Dock=DockStyle.None;
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, EditToolStripMenuItem, ViewToolStripMenuItem, ToolsToolStripMenuItem, HelpToolStripMenuItem });
            MenuStrip.Location=new Point(0, 0);
            MenuStrip.Name="MenuStrip";
            MenuStrip.Size=new Size(632, 24);
            MenuStrip.TabIndex=0;
            MenuStrip.Text="MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewToolStripMenuItem, OpenToolStripMenuItem, ToolStripSeparator1, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ToolStripSeparator2, PrintToolStripMenuItem, PrintPreviewToolStripMenuItem, ToolStripSeparator3, ExitToolStripMenuItem });
            FileToolStripMenuItem.Name="FileToolStripMenuItem";
            FileToolStripMenuItem.Size=new Size(35, 20);
            FileToolStripMenuItem.Text="&File";
            // 
            // NewToolStripMenuItem
            // 
            NewToolStripMenuItem.Image=(Image)resources.GetObject("NewToolStripMenuItem.Image");
            NewToolStripMenuItem.ImageTransparentColor=Color.Black;
            NewToolStripMenuItem.Name="NewToolStripMenuItem";
            NewToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.N;
            NewToolStripMenuItem.Size=new Size(140, 22);
            NewToolStripMenuItem.Text="&New";
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Image=(Image)resources.GetObject("OpenToolStripMenuItem.Image");
            OpenToolStripMenuItem.ImageTransparentColor=Color.Black;
            OpenToolStripMenuItem.Name="OpenToolStripMenuItem";
            OpenToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.O;
            OpenToolStripMenuItem.Size=new Size(140, 22);
            OpenToolStripMenuItem.Text="&Open";
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name="ToolStripSeparator1";
            ToolStripSeparator1.Size=new Size(137, 6);
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Image=(Image)resources.GetObject("SaveToolStripMenuItem.Image");
            SaveToolStripMenuItem.ImageTransparentColor=Color.Black;
            SaveToolStripMenuItem.Name="SaveToolStripMenuItem";
            SaveToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.S;
            SaveToolStripMenuItem.Size=new Size(140, 22);
            SaveToolStripMenuItem.Text="&Save";
            // 
            // SaveAsToolStripMenuItem
            // 
            SaveAsToolStripMenuItem.Name="SaveAsToolStripMenuItem";
            SaveAsToolStripMenuItem.Size=new Size(140, 22);
            SaveAsToolStripMenuItem.Text="Save &As";
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name="ToolStripSeparator2";
            ToolStripSeparator2.Size=new Size(137, 6);
            // 
            // PrintToolStripMenuItem
            // 
            PrintToolStripMenuItem.Image=(Image)resources.GetObject("PrintToolStripMenuItem.Image");
            PrintToolStripMenuItem.ImageTransparentColor=Color.Black;
            PrintToolStripMenuItem.Name="PrintToolStripMenuItem";
            PrintToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.P;
            PrintToolStripMenuItem.Size=new Size(140, 22);
            PrintToolStripMenuItem.Text="&Print";
            // 
            // PrintPreviewToolStripMenuItem
            // 
            PrintPreviewToolStripMenuItem.Image=(Image)resources.GetObject("PrintPreviewToolStripMenuItem.Image");
            PrintPreviewToolStripMenuItem.ImageTransparentColor=Color.Black;
            PrintPreviewToolStripMenuItem.Name="PrintPreviewToolStripMenuItem";
            PrintPreviewToolStripMenuItem.Size=new Size(140, 22);
            PrintPreviewToolStripMenuItem.Text="Print Pre&view";
            // 
            // ToolStripSeparator3
            // 
            ToolStripSeparator3.Name="ToolStripSeparator3";
            ToolStripSeparator3.Size=new Size(137, 6);
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name="ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size=new Size(140, 22);
            ExitToolStripMenuItem.Text="E&xit";
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { UndoToolStripMenuItem, RedoToolStripMenuItem, ToolStripSeparator4, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, ToolStripSeparator5, SelectAllToolStripMenuItem });
            EditToolStripMenuItem.Name="EditToolStripMenuItem";
            EditToolStripMenuItem.Size=new Size(37, 20);
            EditToolStripMenuItem.Text="&Edit";
            // 
            // UndoToolStripMenuItem
            // 
            UndoToolStripMenuItem.Image=(Image)resources.GetObject("UndoToolStripMenuItem.Image");
            UndoToolStripMenuItem.ImageTransparentColor=Color.Black;
            UndoToolStripMenuItem.Name="UndoToolStripMenuItem";
            UndoToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.Z;
            UndoToolStripMenuItem.Size=new Size(156, 22);
            UndoToolStripMenuItem.Text="&Undo";
            // 
            // RedoToolStripMenuItem
            // 
            RedoToolStripMenuItem.Image=(Image)resources.GetObject("RedoToolStripMenuItem.Image");
            RedoToolStripMenuItem.ImageTransparentColor=Color.Black;
            RedoToolStripMenuItem.Name="RedoToolStripMenuItem";
            RedoToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.Y;
            RedoToolStripMenuItem.Size=new Size(156, 22);
            RedoToolStripMenuItem.Text="&Redo";
            // 
            // ToolStripSeparator4
            // 
            ToolStripSeparator4.Name="ToolStripSeparator4";
            ToolStripSeparator4.Size=new Size(153, 6);
            // 
            // CutToolStripMenuItem
            // 
            CutToolStripMenuItem.Image=(Image)resources.GetObject("CutToolStripMenuItem.Image");
            CutToolStripMenuItem.ImageTransparentColor=Color.Black;
            CutToolStripMenuItem.Name="CutToolStripMenuItem";
            CutToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.X;
            CutToolStripMenuItem.Size=new Size(156, 22);
            CutToolStripMenuItem.Text="Cu&t";
            // 
            // CopyToolStripMenuItem
            // 
            CopyToolStripMenuItem.Image=(Image)resources.GetObject("CopyToolStripMenuItem.Image");
            CopyToolStripMenuItem.ImageTransparentColor=Color.Black;
            CopyToolStripMenuItem.Name="CopyToolStripMenuItem";
            CopyToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.C;
            CopyToolStripMenuItem.Size=new Size(156, 22);
            CopyToolStripMenuItem.Text="&Copy";
            // 
            // PasteToolStripMenuItem
            // 
            PasteToolStripMenuItem.Image=(Image)resources.GetObject("PasteToolStripMenuItem.Image");
            PasteToolStripMenuItem.ImageTransparentColor=Color.Black;
            PasteToolStripMenuItem.Name="PasteToolStripMenuItem";
            PasteToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.V;
            PasteToolStripMenuItem.Size=new Size(156, 22);
            PasteToolStripMenuItem.Text="&Paste";
            // 
            // ToolStripSeparator5
            // 
            ToolStripSeparator5.Name="ToolStripSeparator5";
            ToolStripSeparator5.Size=new Size(153, 6);
            // 
            // SelectAllToolStripMenuItem
            // 
            SelectAllToolStripMenuItem.Name="SelectAllToolStripMenuItem";
            SelectAllToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.A;
            SelectAllToolStripMenuItem.Size=new Size(156, 22);
            SelectAllToolStripMenuItem.Text="Select &All";
            // 
            // ViewToolStripMenuItem
            // 
            ViewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolBarToolStripMenuItem, StatusBarToolStripMenuItem, FoldersToolStripMenuItem });
            ViewToolStripMenuItem.Name="ViewToolStripMenuItem";
            ViewToolStripMenuItem.Size=new Size(41, 20);
            ViewToolStripMenuItem.Text="&View";
            // 
            // ToolBarToolStripMenuItem
            // 
            ToolBarToolStripMenuItem.Checked=true;
            ToolBarToolStripMenuItem.CheckState=CheckState.Checked;
            ToolBarToolStripMenuItem.Name="ToolBarToolStripMenuItem";
            ToolBarToolStripMenuItem.Size=new Size(124, 22);
            ToolBarToolStripMenuItem.Text="&Toolbar";
            // 
            // StatusBarToolStripMenuItem
            // 
            StatusBarToolStripMenuItem.Checked=true;
            StatusBarToolStripMenuItem.CheckState=CheckState.Checked;
            StatusBarToolStripMenuItem.Name="StatusBarToolStripMenuItem";
            StatusBarToolStripMenuItem.Size=new Size(124, 22);
            StatusBarToolStripMenuItem.Text="&Status Bar";
            // 
            // FoldersToolStripMenuItem
            // 
            FoldersToolStripMenuItem.Checked=true;
            FoldersToolStripMenuItem.CheckState=CheckState.Checked;
            FoldersToolStripMenuItem.Name="FoldersToolStripMenuItem";
            FoldersToolStripMenuItem.Size=new Size(124, 22);
            FoldersToolStripMenuItem.Text="&Folders";
            // 
            // ToolsToolStripMenuItem
            // 
            ToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OptionsToolStripMenuItem });
            ToolsToolStripMenuItem.Name="ToolsToolStripMenuItem";
            ToolsToolStripMenuItem.Size=new Size(44, 20);
            ToolsToolStripMenuItem.Text="&Tools";
            // 
            // OptionsToolStripMenuItem
            // 
            OptionsToolStripMenuItem.Name="OptionsToolStripMenuItem";
            OptionsToolStripMenuItem.Size=new Size(111, 22);
            OptionsToolStripMenuItem.Text="&Options";
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ContentsToolStripMenuItem, IndexToolStripMenuItem, SearchToolStripMenuItem, ToolStripSeparator6, AboutToolStripMenuItem });
            HelpToolStripMenuItem.Name="HelpToolStripMenuItem";
            HelpToolStripMenuItem.Size=new Size(40, 20);
            HelpToolStripMenuItem.Text="&Help";
            // 
            // ContentsToolStripMenuItem
            // 
            ContentsToolStripMenuItem.Name="ContentsToolStripMenuItem";
            ContentsToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.F1;
            ContentsToolStripMenuItem.Size=new Size(162, 22);
            ContentsToolStripMenuItem.Text="&Contents";
            // 
            // IndexToolStripMenuItem
            // 
            IndexToolStripMenuItem.Image=(Image)resources.GetObject("IndexToolStripMenuItem.Image");
            IndexToolStripMenuItem.ImageTransparentColor=Color.Black;
            IndexToolStripMenuItem.Name="IndexToolStripMenuItem";
            IndexToolStripMenuItem.Size=new Size(162, 22);
            IndexToolStripMenuItem.Text="&Index";
            // 
            // SearchToolStripMenuItem
            // 
            SearchToolStripMenuItem.Image=(Image)resources.GetObject("SearchToolStripMenuItem.Image");
            SearchToolStripMenuItem.ImageTransparentColor=Color.Black;
            SearchToolStripMenuItem.Name="SearchToolStripMenuItem";
            SearchToolStripMenuItem.Size=new Size(162, 22);
            SearchToolStripMenuItem.Text="&Search";
            // 
            // ToolStripSeparator6
            // 
            ToolStripSeparator6.Name="ToolStripSeparator6";
            ToolStripSeparator6.Size=new Size(159, 6);
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name="AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size=new Size(162, 22);
            AboutToolStripMenuItem.Text="&About ...";
            // 
            // ToolStripContainer
            // 
            // 
            // ToolStripContainer.BottomToolStripPanel
            // 
            ToolStripContainer.BottomToolStripPanel.Controls.Add(StatusStrip);
            // 
            // ToolStripContainer.ContentPanel
            // 
            ToolStripContainer.ContentPanel.Controls.Add(SplitContainer);
            ToolStripContainer.ContentPanel.Size=new Size(632, 382);
            ToolStripContainer.Dock=DockStyle.Fill;
            ToolStripContainer.Location=new Point(0, 0);
            ToolStripContainer.Name="ToolStripContainer";
            ToolStripContainer.Size=new Size(632, 453);
            ToolStripContainer.TabIndex=7;
            ToolStripContainer.Text="ToolStripContainer1";
            // 
            // ToolStripContainer.TopToolStripPanel
            // 
            ToolStripContainer.TopToolStripPanel.Controls.Add(MenuStrip);
            ToolStripContainer.TopToolStripPanel.Controls.Add(ToolStrip);
            // 
            // SplitContainer
            // 
            SplitContainer.Dock=DockStyle.Fill;
            SplitContainer.Location=new Point(0, 0);
            SplitContainer.Name="SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            SplitContainer.Panel1.Controls.Add(TreeView);
            // 
            // SplitContainer.Panel2
            // 
            SplitContainer.Panel2.Controls.Add(ListView);
            SplitContainer.Size=new Size(632, 382);
            SplitContainer.SplitterDistance=211;
            SplitContainer.TabIndex=0;
            SplitContainer.Text="SplitContainer1";
            // 
            // TreeView
            // 
            TreeView.Dock=DockStyle.Fill;
            TreeView.ImageIndex=0;
            TreeView.ImageList=TreeNodeImageList;
            TreeView.Location=new Point(0, 0);
            TreeView.Name="TreeView";
            TreeView.SelectedImageIndex=1;
            TreeView.ShowLines=false;
            TreeView.Size=new Size(211, 382);
            TreeView.TabIndex=0;
            // 
            // ListView
            // 
            ListView.Dock=DockStyle.Fill;
            ListView.LargeImageList=ListViewLargeImageList;
            ListView.Location=new Point(0, 0);
            ListView.Name="ListView";
            ListView.Size=new Size(417, 382);
            ListView.SmallImageList=ListViewSmallImageList;
            ListView.TabIndex=0;
            ListView.UseCompatibleStateImageBehavior=false;
            // 
            // ListViewLargeImageList
            // 
            ListViewLargeImageList.ImageStream=(ImageListStreamer)resources.GetObject("ListViewLargeImageList.ImageStream");
            ListViewLargeImageList.TransparentColor=Color.Transparent;
            ListViewLargeImageList.Images.SetKeyName(0, "Graph1");
            ListViewLargeImageList.Images.SetKeyName(1, "Graph2");
            ListViewLargeImageList.Images.SetKeyName(2, "Graph3");
            // 
            // ListViewSmallImageList
            // 
            ListViewSmallImageList.ImageStream=(ImageListStreamer)resources.GetObject("ListViewSmallImageList.ImageStream");
            ListViewSmallImageList.TransparentColor=Color.Transparent;
            ListViewSmallImageList.Images.SetKeyName(0, "Graph1");
            ListViewSmallImageList.Images.SetKeyName(1, "Graph2");
            ListViewSmallImageList.Images.SetKeyName(2, "Graph3");
            // 
            // Explorer1
            // 
            AutoScaleDimensions=new SizeF(6.0f, 13.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(632, 453);
            Controls.Add(ToolStripContainer);
            Name="Explorer1";
            Text="Explorer1";
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            ToolStripContainer.BottomToolStripPanel.PerformLayout();
            ToolStripContainer.ContentPanel.ResumeLayout(false);
            ToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            ToolStripContainer.TopToolStripPanel.PerformLayout();
            ToolStripContainer.ResumeLayout(false);
            ToolStripContainer.PerformLayout();
            SplitContainer.Panel1.ResumeLayout(false);
            SplitContainer.Panel2.ResumeLayout(false);
            SplitContainer.ResumeLayout(false);
            Load+=new EventHandler(Explorer1_Load);
            ResumeLayout(false);

        }

    }
}