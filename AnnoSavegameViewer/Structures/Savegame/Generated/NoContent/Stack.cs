using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Stack {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public StackList StackList { get; set; }

  }
}