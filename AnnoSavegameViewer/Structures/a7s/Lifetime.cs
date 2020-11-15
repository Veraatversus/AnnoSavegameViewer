namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Lifetime {

		[BinaryContent(Name = "RemainingTime", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan RemainingTime { get; set; }

	}
}
