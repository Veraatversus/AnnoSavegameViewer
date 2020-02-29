using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaProfile {

    [BinaryContent(Name = "Level", NodeType = BinaryContentTypes.Attribute)]
    public object Level { get; set; }

    [BinaryContent(Name = "activeSession", NodeType = BinaryContentTypes.Node)]
    public ActiveSession ActiveSession { get; set; }

    [BinaryContent(Name = "ProgressLevel", NodeType = BinaryContentTypes.Node)]
    public ProgressLevel ProgressLevel { get; set; }

    [BinaryContent(Name = "CustomCompanyName", NodeType = BinaryContentTypes.Node)]
    public CustomCompanyName CustomCompanyName { get; set; }

    [BinaryContent(Name = "CustomAvatarPortrait", NodeType = BinaryContentTypes.Node)]
    public CustomAvatarPortrait CustomAvatarPortrait { get; set; }

    [BinaryContent(Name = "CustomCompanyColor", NodeType = BinaryContentTypes.Node)]
    public CustomCompanyColor CustomCompanyColor { get; set; }

    [BinaryContent(Name = "CustomCompanyLogo", NodeType = BinaryContentTypes.Node)]
    public CustomCompanyLogo CustomCompanyLogo { get; set; }

    [BinaryContent(Name = "UniqueShipGuids", NodeType = BinaryContentTypes.Node)]
    public UniqueShipGuids UniqueShipGuids { get; set; }

    [BinaryContent(Name = "RequestedUniqueShips", NodeType = BinaryContentTypes.Node)]
    public RequestedUniqueShips RequestedUniqueShips { get; set; }

  }
}