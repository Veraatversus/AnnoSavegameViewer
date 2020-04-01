using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BuildingsList {

    [BinaryContent(Name = "Pos", NodeType = BinaryContentTypes.Attribute)]
    public object Pos { get; set; }

    [BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Attribute)]
    public object Rotation { get; set; }

    [BinaryContent(Name = "ReqSecurity", NodeType = BinaryContentTypes.Attribute)]
    public object ReqSecurity { get; set; }

    [BinaryContent(Name = "ReqSecurityBase", NodeType = BinaryContentTypes.Attribute)]
    public object ReqSecurityBase { get; set; }

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

    [BinaryContent(Name = "ProvSecurity", NodeType = BinaryContentTypes.Attribute)]
    public object ProvSecurity { get; set; }

    [BinaryContent(Name = "harborBlocker", NodeType = BinaryContentTypes.Node)]
    public HarborBlocker HarborBlocker { get; set; }

    [BinaryContent(Name = "Shippaths", NodeType = BinaryContentTypes.Node)]
    public Shippaths Shippaths { get; set; }

  }
}