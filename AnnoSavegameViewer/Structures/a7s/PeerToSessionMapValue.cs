namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class PeerToSessionMapValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public NoneValue Value { get; set; }

		[BinaryContent(Name = "LastActiveSession", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt LastActiveSession { get; set; }

		[BinaryContent(Name = "CurrentlyActiveSession", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt CurrentlyActiveSession { get; set; }

	}
}
