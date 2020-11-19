namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Stack {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<StackList> StackList { get; set; }

  }
}