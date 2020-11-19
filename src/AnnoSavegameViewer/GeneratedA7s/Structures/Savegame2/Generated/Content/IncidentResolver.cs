namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class IncidentResolver {

    #region Public Properties

    [BinaryContent(Name = "specialActionCooldown", NodeType = BinaryContentTypes.Attribute)]
    public object SpecialActionCooldown { get; set; }

    [BinaryContent(Name = "resolverUnits", NodeType = BinaryContentTypes.Node)]
    public ResolverUnits ResolverUnits { get; set; }

    [BinaryContent(Name = "specialUnits", NodeType = BinaryContentTypes.Node)]
    public SpecialUnits SpecialUnits { get; set; }

    #endregion Public Properties
  }
}