namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MetaBuildPermits {

		[BinaryContent(Name = "buildPermits", NodeType = BinaryContentTypes.Node)]
		public BuildPermits BuildPermits { get; set; }

	}
}
