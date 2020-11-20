// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ResolverUnitsValue {

		[BinaryContent(Name = "institutionID", NodeType = BinaryContentTypes.Node)]
		public InstitutionID InstitutionID { get; set; }

		[BinaryContent(Name = "id", NodeType = BinaryContentTypes.Node)]
		public Id Id { get; set; }

		[BinaryContent(Name = "dummyObject", NodeType = BinaryContentTypes.Attribute)]
		public HexString DummyObject { get; set; }

		[BinaryContent(Name = "unlockTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString UnlockTime { get; set; }

		[BinaryContent(Name = "incidentType", NodeType = BinaryContentTypes.Node)]
		public IncidentType IncidentType { get; set; }

		[BinaryContent(Name = "reachedDest", NodeType = BinaryContentTypes.Attribute)]
		public HexString ReachedDest { get; set; }

		[BinaryContent(Name = "pos", NodeType = BinaryContentTypes.Attribute)]
		public HexString Pos { get; set; }

		[BinaryContent(Name = "atBase", NodeType = BinaryContentTypes.Attribute)]
		public HexString AtBase { get; set; }

		[BinaryContent(Name = "locked", NodeType = BinaryContentTypes.Attribute)]
		public HexString Locked { get; set; }

	}
}
