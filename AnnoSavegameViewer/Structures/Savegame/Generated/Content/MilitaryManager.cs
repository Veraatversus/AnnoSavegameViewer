namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class MilitaryManager {

    [BinaryContent(Name = "nextFightID", NodeType = BinaryContentTypes.Attribute)]
    public object NextFightID { get; set; }

    [BinaryContent(Name = "ObjectToFightId", NodeType = BinaryContentTypes.Node)]
    public ObjectToFightId ObjectToFightId { get; set; }

    [BinaryContent(Name = "FightIdToFight", NodeType = BinaryContentTypes.Node)]
    public FightIdToFight FightIdToFight { get; set; }

  }
}