namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AreaHistoryValue {

		[BinaryContent(Name = "Snapshots", NodeType = BinaryContentTypes.Node)]
		public NoneSnapshots Snapshots { get; set; }

	}
}
