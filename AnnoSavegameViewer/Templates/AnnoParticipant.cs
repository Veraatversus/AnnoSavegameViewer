using AnnoSavegameViewer.Structures.Savegame;

namespace AnnoSavegameViewer.Templates {

  public class AnnoParticipant {

    #region Public Properties

    public short ID { get; private set; }

    public DescriptionInt GUID { get; set; }

    #endregion Public Properties

    #region Public Constructors

    public AnnoParticipant(short id) {
      ID = id;
    }

    #endregion Public Constructors
  }
}