using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SessionSoundManager {

[BinaryContent(Name = "AmbientMoodSoundHandler", NodeType = BinaryContentTypes.Node)]
public AmbientMoodSoundHandler AmbientMoodSoundHandler { get; set; }

[BinaryContent(Name = "EnvironmentHandler", NodeType = BinaryContentTypes.Node)]
public EnvironmentHandler EnvironmentHandler { get; set; }

}
}
