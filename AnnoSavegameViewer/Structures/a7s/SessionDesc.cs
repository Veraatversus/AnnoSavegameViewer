namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SessionDesc {

		[BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt SessionGUID { get; set; }

		[BinaryContent(Name = "SessionID", NodeType = BinaryContentTypes.Attribute)]
		public Int16 SessionID { get; set; }

		[BinaryContent(Name = "SessionMap", NodeType = BinaryContentTypes.Attribute, Encoding = "utf-16")]
		public String SessionMap { get; set; }

		[BinaryContent(Name = "MapGeneratorSettings", NodeType = BinaryContentTypes.Node)]
		public MapGeneratorSettings MapGeneratorSettings { get; set; }

	}
}
