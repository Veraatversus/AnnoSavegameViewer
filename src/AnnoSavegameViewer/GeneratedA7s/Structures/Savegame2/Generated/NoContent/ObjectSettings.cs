namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ObjectSettings {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ObjectSettingsList> ObjectSettingsList { get; set; }

  }
}