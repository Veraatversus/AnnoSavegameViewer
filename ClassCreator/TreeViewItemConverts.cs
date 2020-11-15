using AnnoSavegameViewer.Structures.RDA;
using System.Windows.Controls;

namespace ClassCreator {

  public static class TreeViewItemConverts {
    public static TreeViewItem ToTreeViewItem(this Rda rda, string fileName) {
      var item = new TreeViewItem() { Header = fileName, Tag = rda };
      var node = new TreeNode()
      foreach (var block in rda.Blocks) {
        item.Items.Add(block.ToTreeViewItem());
      }
      return item;
    }

    public static TreeViewItem ToTreeViewItem(this RdaBlock block) {
      var item = new TreeViewItem() { Header = block.Header, Tag = block };
      foreach (var file in block.Files) {
        item.Items.Add(file.ToTreeViewItem());
      }
      return item;
    }

    public static TreeViewItem ToTreeViewItem(this RdaFile file) {
      var item = new TreeViewItem() { Header = file.FileHeader, Tag = file };
      foreach (var file in file..Files) {
        item..Items.Add(file.ToTreeViewItem());
      }
      return item;
    }
  }
}
