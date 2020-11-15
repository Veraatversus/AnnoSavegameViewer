namespace AnnoSavegameViewer.Templates {
  using AnnoSerializer.Structures.DataTypes;

  public class AnnoParticipant {

    #region Public Properties

    public short ID { get; }

    public DescriptionInt GUID { get; set; }

    #endregion Public Properties

    #region Public Constructors

    public AnnoParticipant(short id) => ID = id;

    #endregion Public Constructors
  }
}