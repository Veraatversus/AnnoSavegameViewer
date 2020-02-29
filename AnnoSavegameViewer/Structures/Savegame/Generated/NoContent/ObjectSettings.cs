using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ObjectSettings {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public ObjectSettingsList ObjectSettingsList { get; set; }

  }
}