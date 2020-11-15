namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Commands {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CommandsList> CommandsList { get; set; }

  }
}