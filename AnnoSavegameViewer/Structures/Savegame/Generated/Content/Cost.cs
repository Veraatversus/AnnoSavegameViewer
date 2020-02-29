using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Cost {

    #region Public Properties

    [BinaryContent(Name = "RoundUp", NodeType = BinaryContentTypes.Attribute)]
    public object RoundUp { get; set; }

    [BinaryContent(Name = "BuildCosts", NodeType = BinaryContentTypes.Node)]
    public BuildCosts BuildCosts { get; set; }

    [BinaryContent(Name = "InfluenceCosts", NodeType = BinaryContentTypes.Node)]
    public InfluenceCosts InfluenceCosts { get; set; }

    #endregion Public Properties
  }
}