namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class FreeAreaproductivity {

		[BinaryContent(Name = "WorkerInfo", NodeType = BinaryContentTypes.Node)]
		public WorkerInfo WorkerInfo { get; set; }

		[BinaryContent(Name = "InitializeForestTime", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan InitializeForestTime { get; set; }

	}
}
