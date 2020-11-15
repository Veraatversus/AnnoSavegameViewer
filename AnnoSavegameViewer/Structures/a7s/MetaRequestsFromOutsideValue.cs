namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MetaRequestsFromOutsideValue {

		[BinaryContent(Name = "Product", NodeType = BinaryContentTypes.Attribute)]
		public HexString Product { get; set; }

		[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Node)]
		public MetaRequestsFromOutsideValuesNonePriority Priority { get; set; }

		[BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
		public MetaRequestsFromOutsideValuesNoneSource Source { get; set; }

		[BinaryContent(Name = "RequestingSession", NodeType = BinaryContentTypes.Attribute)]
		public HexString RequestingSession { get; set; }

		[BinaryContent(Name = "TargetSession", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetSession { get; set; }

		[BinaryContent(Name = "Status", NodeType = BinaryContentTypes.Attribute)]
		public HexString Status { get; set; }

	}
}
