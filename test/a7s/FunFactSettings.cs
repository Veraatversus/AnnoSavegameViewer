using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class FunFactSettings {

[BinaryContent(Name = "PlayerCounter", NodeType = BinaryContentTypes.Node)]
public PlayerCounter PlayerCounter { get; set; }

[BinaryContent(Name = "ValueType", NodeType = BinaryContentTypes.Node)]
public ValueType ValueType { get; set; }

[BinaryContent(Name = "Scope", NodeType = BinaryContentTypes.Node)]
public Scope Scope { get; set; }

[BinaryContent(Name = "ScopeContext", NodeType = BinaryContentTypes.Attribute)]
public HexString ScopeContext { get; set; }

[BinaryContent(Name = "Value", NodeType = BinaryContentTypes.Attribute)]
public HexString Value { get; set; }

[BinaryContent(Name = "TextGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString TextGUID { get; set; }

[BinaryContent(Name = "CounterContext", NodeType = BinaryContentTypes.Attribute)]
public HexString CounterContext { get; set; }

[BinaryContent(Name = "FactNumber", NodeType = BinaryContentTypes.Attribute)]
public HexString FactNumber { get; set; }

}
}
