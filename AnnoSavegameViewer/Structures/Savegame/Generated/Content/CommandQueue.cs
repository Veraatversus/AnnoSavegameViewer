using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CommandQueue {

    #region Public Properties

    [BinaryContent(Name = "BasePosition", NodeType = BinaryContentTypes.Attribute)]
    public object BasePosition { get; set; }

    [BinaryContent(Name = "BaseRotation", NodeType = BinaryContentTypes.Attribute)]
    public object BaseRotation { get; set; }

    [BinaryContent(Name = "ExecuteCurrentCommand", NodeType = BinaryContentTypes.Attribute)]
    public object ExecuteCurrentCommand { get; set; }

    [BinaryContent(Name = "StateMain", NodeType = BinaryContentTypes.Attribute)]
    public object StateMain { get; set; }

    [BinaryContent(Name = "StateSub", NodeType = BinaryContentTypes.Attribute)]
    public object StateSub { get; set; }

    [BinaryContent(Name = "Stance", NodeType = BinaryContentTypes.Attribute)]
    public object Stance { get; set; }

    [BinaryContent(Name = "Commands", NodeType = BinaryContentTypes.Node)]
    public Commands Commands { get; set; }

    [BinaryContent(Name = "SpecialAssignment", NodeType = BinaryContentTypes.Node)]
    public SpecialAssignment SpecialAssignment { get; set; }

    [BinaryContent(Name = "StateParams", NodeType = BinaryContentTypes.Node)]
    public StateParams StateParams { get; set; }

    #endregion Public Properties
  }
}