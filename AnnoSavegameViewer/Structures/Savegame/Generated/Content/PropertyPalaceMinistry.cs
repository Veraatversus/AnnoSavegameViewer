using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PropertyPalaceMinistry {

    [BinaryContent(Name = "PreviousParagonLevel", NodeType = BinaryContentTypes.Attribute)]
    public object PreviousParagonLevel { get; set; }

    [BinaryContent(Name = "NewParagonLevel", NodeType = BinaryContentTypes.Attribute)]
    public object NewParagonLevel { get; set; }

    [BinaryContent(Name = "CurrentEffectRange", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentEffectRange { get; set; }

    [BinaryContent(Name = "NewEffectRange", NodeType = BinaryContentTypes.Attribute)]
    public object NewEffectRange { get; set; }

    [BinaryContent(Name = "PalaceExists", NodeType = BinaryContentTypes.Attribute)]
    public object PalaceExists { get; set; }

    [BinaryContent(Name = "Ministry", NodeType = BinaryContentTypes.Node)]
    public Ministry Ministry { get; set; }

    [BinaryContent(Name = "Decree", NodeType = BinaryContentTypes.Node)]
    public Decree Decree { get; set; }

    [BinaryContent(Name = "ActiveEffects", NodeType = BinaryContentTypes.Node)]
    public ActiveEffects ActiveEffects { get; set; }

    [BinaryContent(Name = "LockedEffectsToHandle", NodeType = BinaryContentTypes.Node)]
    public LockedEffectsToHandle LockedEffectsToHandle { get; set; }

    [BinaryContent(Name = "UnlockedEffectsToHandle", NodeType = BinaryContentTypes.Node)]
    public UnlockedEffectsToHandle UnlockedEffectsToHandle { get; set; }

    [BinaryContent(Name = "MinistryUnlockedStates", NodeType = BinaryContentTypes.Node)]
    public MinistryUnlockedStates MinistryUnlockedStates { get; set; }

    [BinaryContent(Name = "DecreeUnlockedStates", NodeType = BinaryContentTypes.Node)]
    public DecreeUnlockedStates DecreeUnlockedStates { get; set; }

  }
}