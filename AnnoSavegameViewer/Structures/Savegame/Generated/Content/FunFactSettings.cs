using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FunFactSettings {

    [BinaryContent(Name = "ScopeContext", NodeType = BinaryContentTypes.Attribute)]
    public object ScopeContext { get; set; }

    [BinaryContent(Name = "Value", NodeType = BinaryContentTypes.Attribute)]
    public object Value { get; set; }

    [BinaryContent(Name = "TextGUID", NodeType = BinaryContentTypes.Attribute)]
    public object TextGUID { get; set; }

    [BinaryContent(Name = "CounterContext", NodeType = BinaryContentTypes.Attribute)]
    public object CounterContext { get; set; }

    [BinaryContent(Name = "FactNumber", NodeType = BinaryContentTypes.Attribute)]
    public object FactNumber { get; set; }

    [BinaryContent(Name = "PlayerCounter", NodeType = BinaryContentTypes.Node)]
    public PlayerCounter PlayerCounter { get; set; }

    [BinaryContent(Name = "ValueType", NodeType = BinaryContentTypes.Node)]
    public ValueType ValueType { get; set; }

    [BinaryContent(Name = "Scope", NodeType = BinaryContentTypes.Node)]
    public Scope Scope { get; set; }

  }
}