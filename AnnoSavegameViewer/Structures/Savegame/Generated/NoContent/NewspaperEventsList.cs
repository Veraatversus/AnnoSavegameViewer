using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class NewspaperEventsList {

    [BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Node)]
    public NewspaperEventsListContext Context { get; set; }

  }
}