using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PropertyPalaceMinistry {

[BinaryContent(Name = "Ministry", NodeType = BinaryContentTypes.Node)]
public Ministry Ministry { get; set; }

[BinaryContent(Name = "Decree", NodeType = BinaryContentTypes.Node)]
public Decree Decree { get; set; }

[BinaryContent(Name = "ActiveEffects", NodeType = BinaryContentTypes.Node)]
public PropertyPalaceMinistryActiveEffects ActiveEffects { get; set; }

[BinaryContent(Name = "PreviousParagonLevel", NodeType = BinaryContentTypes.Attribute)]
public HexString PreviousParagonLevel { get; set; }

[BinaryContent(Name = "NewParagonLevel", NodeType = BinaryContentTypes.Attribute)]
public HexString NewParagonLevel { get; set; }

[BinaryContent(Name = "CurrentEffectRange", NodeType = BinaryContentTypes.Attribute)]
public HexString CurrentEffectRange { get; set; }

[BinaryContent(Name = "NewEffectRange", NodeType = BinaryContentTypes.Attribute)]
public HexString NewEffectRange { get; set; }

[BinaryContent(Name = "LockedEffectsToHandle", NodeType = BinaryContentTypes.Node)]
public LockedEffectsToHandle LockedEffectsToHandle { get; set; }

[BinaryContent(Name = "UnlockedEffectsToHandle", NodeType = BinaryContentTypes.Node)]
public UnlockedEffectsToHandle UnlockedEffectsToHandle { get; set; }

[BinaryContent(Name = "MinistryUnlockedStates", NodeType = BinaryContentTypes.Node)]
public MinistryUnlockedStates MinistryUnlockedStates { get; set; }

[BinaryContent(Name = "DecreeUnlockedStates", NodeType = BinaryContentTypes.Node)]
public DecreeUnlockedStates DecreeUnlockedStates { get; set; }

[BinaryContent(Name = "PalaceExists", NodeType = BinaryContentTypes.Attribute)]
public HexString PalaceExists { get; set; }

}
}
