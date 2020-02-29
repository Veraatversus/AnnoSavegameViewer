using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConsumptionStatesList {

    #region Public Properties

    [BinaryContent(Name = "CurrentSaturation", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentSaturation { get; set; }

    [BinaryContent(Name = "AverageSaturation", NodeType = BinaryContentTypes.Attribute)]
    public object AverageSaturation { get; set; }

    #endregion Public Properties
  }
}