namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ProjectileDesc {

		[BinaryContent(Name = "OwnerID", NodeType = BinaryContentTypes.Attribute)]
		public HexString OwnerID { get; set; }

		[BinaryContent(Name = "TargetID", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetID { get; set; }

		[BinaryContent(Name = "HitType", NodeType = BinaryContentTypes.Node)]
		public HitType HitType { get; set; }

		[BinaryContent(Name = "AdditionalStatusEffects", NodeType = BinaryContentTypes.Node)]
		public AdditionalStatusEffects AdditionalStatusEffects { get; set; }

	}
}
