// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class RouteMapValue {

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "Name", NodeType = BinaryContentTypes.Attribute)]
		public HexString Name { get; set; }

		[BinaryContent(Name = "Ships", NodeType = BinaryContentTypes.Attribute)]
		public HexString Ships { get; set; }

		[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
		public NoneOwner Owner { get; set; }

		[BinaryContent(Name = "OwnerType", NodeType = BinaryContentTypes.Node)]
		public OwnerType OwnerType { get; set; }

		[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
		public Type Type { get; set; }

		[BinaryContent(Name = "Stations", NodeType = BinaryContentTypes.Node)]
		public Stations Stations { get; set; }

		[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
		public NoneIDManager IDManager { get; set; }

		[BinaryContent(Name = "LastErrors", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastErrors { get; set; }

		[BinaryContent(Name = "CharterRouteDescription", NodeType = BinaryContentTypes.Node)]
		public CharterRouteDescription CharterRouteDescription { get; set; }

	}
}
