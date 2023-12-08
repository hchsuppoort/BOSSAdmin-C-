using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BossAdmin
{

    public partial class Explorer1
    {
        public Explorer1()
        {
            InitializeComponent();
        }

        private void Explorer1_Load(object sender, EventArgs e)
        {
            // Set up the UI
            SetUpListViewColumns();
            LoadTree();
        }

        private void LoadTree()
        {
            // TODO: Add code to add items to the treeview

            TreeNode tvRoot;
            TreeNode tvNode;

            tvRoot=TreeView.Nodes.Add("Root");
            tvNode=tvRoot.Nodes.Add("TreeItem1");
            tvNode=tvRoot.Nodes.Add("TreeItem2");
            tvNode=tvRoot.Nodes.Add("TreeItem3");
        }

        private void LoadListView()
        {
            // TODO: Add code to add items to the listview based on the selected item in the treeview

            ListViewItem lvItem;
            ListView.Items.Clear();

            lvItem=ListView.Items.Add("ListViewItem1");
            lvItem.ImageKey="Graph1";
            lvItem.SubItems.AddRange(new string[] { "Column2", "Column3" });

            lvItem=ListView.Items.Add("ListViewItem2");
            lvItem.ImageKey="Graph2";
            lvItem.SubItems.AddRange(new string[] { "Column2", "Column3" });

            lvItem=ListView.Items.Add("ListViewItem3");
            lvItem.ImageKey="Graph3";
            lvItem.SubItems.AddRange(new string[] { "Column2", "Column3" });
        }

        private void SetUpListViewColumns()
        {

            // TODO: Add code to set up listview columns
            ColumnHeader lvColumnHeader;

            // Setting Column widths applies only to the current view, so this line
            // explicitly sets the ListView to be showing the SmallIcon view
            // before setting the column width
            SetView(View.SmallIcon);

            lvColumnHeader=ListView.Columns.Add("Column1");
            // Set the SmallIcon view column width large enough so that the items
            // do not overlap
            // Note that the second and third column do not appear in SmallIcon
            // view, so there is no need to set those while in SmallIcon view
            lvColumnHeader.Width=90;

            // Change the view to Details and set up the appropriate column
            // widths for the Details view differently than SmallIcon view
            SetView(View.Details);

            // The first column needs to be slightly larger in Details view than it
            // was for SmallIcon view, and Column2 and Column3 need explicit sizes
            // set for Details view
            lvColumnHeader.Width=100;

            lvColumnHeader=ListView.Columns.Add("Column2");
            lvColumnHeader.Width=70;

            lvColumnHeader=ListView.Columns.Add("Column3");
            lvColumnHeader.Width=70;

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close this form
            Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the toolstrip and also the checked state of the associated menu item
            ToolBarToolStripMenuItem.Checked=!ToolBarToolStripMenuItem.Checked;
            ToolStrip.Visible=ToolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the statusstrip and also the checked state of the associated menu item
            StatusBarToolStripMenuItem.Checked=!StatusBarToolStripMenuItem.Checked;
            StatusStrip.Visible=StatusBarToolStripMenuItem.Checked;
        }

        // Change whether or not the folders pane is visible
        private void ToggleFoldersVisible()
        {
            // First toggle the checked state of the associated menu item
            FoldersToolStripMenuItem.Checked=!FoldersToolStripMenuItem.Checked;

            // Change the Folders toolbar button to be in sync
            FoldersToolStripButton.Checked=FoldersToolStripMenuItem.Checked;

            // Collapse the Panel containing the TreeView.
            SplitContainer.Panel1Collapsed=!FoldersToolStripMenuItem.Checked;
        }

        private void FoldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleFoldersVisible();
        }

        private void FoldersToolStripButton_Click(object sender, EventArgs e)
        {
            ToggleFoldersVisible();
        }

        private void SetView(View View)
        {
            // Figure out which menu item should be checked
            ToolStripMenuItem MenuItemToCheck = null;
            switch (View)
            {
                case View.Details:
                    {
                        MenuItemToCheck=DetailsToolStripMenuItem;
                        break;
                    }
                case View.LargeIcon:
                    {
                        MenuItemToCheck=LargeIconsToolStripMenuItem;
                        break;
                    }
                case View.List:
                    {
                        MenuItemToCheck=ListToolStripMenuItem;
                        break;
                    }
                case View.SmallIcon:
                    {
                        MenuItemToCheck=SmallIconsToolStripMenuItem;
                        break;
                    }
                case View.Tile:
                    {
                        MenuItemToCheck=TileToolStripMenuItem;
                        break;
                    }

                default:
                    {
                        Debug.Fail("Unexpected View");
                        View=View.Details;
                        MenuItemToCheck=DetailsToolStripMenuItem;
                        break;
                    }
            }

            // Check the appropriate menu item and deselect all others under the Views menu
            foreach (ToolStripMenuItem MenuItem in ListViewToolStripButton.DropDownItems)
            {
                if (ReferenceEquals(MenuItem, MenuItemToCheck))
                {
                    MenuItem.Checked=true;
                }
                else
                {
                    MenuItem.Checked=false;
                }
            }

            // Finally, set the view requested
            ListView.View=View;
        }

        private void ListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetView(View.List);
        }

        private void DetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetView(View.Details);
        }

        private void LargeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetView(View.LargeIcon);
        }

        private void SmallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetView(View.SmallIcon);
        }

        private void TileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetView(View.Tile);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.InitialDirectory=Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            OpenFileDialog.Filter="Text Files (*.txt)|*.txt";
            OpenFileDialog.ShowDialog(this);

            string FileName = OpenFileDialog.FileName;
            // TODO: Add code to open the file
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.InitialDirectory=Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            SaveFileDialog.Filter="Text Files (*.txt)|*.txt";
            SaveFileDialog.ShowDialog(this);

            string FileName = SaveFileDialog.FileName;
            // TODO: Add code here to save the current contents of the form to a file.
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // TODO: Add code to change the listview contents based on the currently-selected node of the treeview
            LoadListView();
        }

    }
}