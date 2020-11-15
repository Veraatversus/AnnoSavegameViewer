namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class FogOfWarObjectsValue {

		[BinaryContent(Name = "Object", NodeType = BinaryContentTypes.Node)]
		public Object Object { get; set; }

		[BinaryContent(Name = "Participant", NodeType = BinaryContentTypes.Node)]
		public NoneParticipant Participant { get; set; }

		[BinaryContent(Name = "DiscoverRadius", NodeType = BinaryContentTypes.Node)]
		public DiscoverRadius DiscoverRadius { get; set; }

	}
}
