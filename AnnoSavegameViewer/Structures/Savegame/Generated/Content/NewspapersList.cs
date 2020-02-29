using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class NewspapersList {

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "NotificationID", NodeType = BinaryContentTypes.Attribute)]
    public object NotificationID { get; set; }

    [BinaryContent(Name = "IsPublished", NodeType = BinaryContentTypes.Attribute)]
    public object IsPublished { get; set; }

    [BinaryContent(Name = "Volume", NodeType = BinaryContentTypes.Attribute)]
    public object Volume { get; set; }

    [BinaryContent(Name = "Blocked", NodeType = BinaryContentTypes.Attribute)]
    public object Blocked { get; set; }

    [BinaryContent(Name = "Name", NodeType = BinaryContentTypes.Attribute)]
    public object Name { get; set; }

    [BinaryContent(Name = "Logo", NodeType = BinaryContentTypes.Attribute)]
    public object Logo { get; set; }

    [BinaryContent(Name = "IsNew", NodeType = BinaryContentTypes.Attribute)]
    public object IsNew { get; set; }

    [BinaryContent(Name = "SelectedArticles", NodeType = BinaryContentTypes.Attribute)]
    public object SelectedArticles { get; set; }

    [BinaryContent(Name = "IsFavourite", NodeType = BinaryContentTypes.Attribute)]
    public object IsFavourite { get; set; }

    [BinaryContent(Name = "OriginalArticles", NodeType = BinaryContentTypes.Node)]
    public OriginalArticles OriginalArticles { get; set; }

    [BinaryContent(Name = "ReplacementArticles", NodeType = BinaryContentTypes.Node)]
    public ReplacementArticles ReplacementArticles { get; set; }

    [BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
    public NewspapersListOwner Owner { get; set; }

  }
}