namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NewspapersValue {

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "OriginalArticles", NodeType = BinaryContentTypes.Node)]
		public OriginalArticles OriginalArticles { get; set; }

		[BinaryContent(Name = "ReplacementArticles", NodeType = BinaryContentTypes.Node)]
		public ReplacementArticles ReplacementArticles { get; set; }

		[BinaryContent(Name = "NotificationID", NodeType = BinaryContentTypes.Attribute)]
		public HexString NotificationID { get; set; }

		[BinaryContent(Name = "IsPublished", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsPublished { get; set; }

		[BinaryContent(Name = "Volume", NodeType = BinaryContentTypes.Attribute)]
		public HexString Volume { get; set; }

		[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
		public NewspapersValuesNoneOwner Owner { get; set; }

		[BinaryContent(Name = "Name", NodeType = BinaryContentTypes.Attribute)]
		public HexString Name { get; set; }

		[BinaryContent(Name = "Logo", NodeType = BinaryContentTypes.Attribute)]
		public HexString Logo { get; set; }

		[BinaryContent(Name = "IsNew", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsNew { get; set; }

		[BinaryContent(Name = "SelectedArticles", NodeType = BinaryContentTypes.Attribute)]
		public HexString SelectedArticles { get; set; }

	}
}
