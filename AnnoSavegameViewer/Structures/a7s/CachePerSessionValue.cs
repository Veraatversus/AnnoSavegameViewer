namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class CachePerSessionValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public CachePerSessionValuesNoneValue Value { get; set; }

	}
}
