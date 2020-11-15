namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class IncidentsValue {

		[BinaryContent(Name = "mapKey", NodeType = BinaryContentTypes.Attribute)]
		public HexString MapKey { get; set; }

		[BinaryContent(Name = "mapContext", NodeType = BinaryContentTypes.Attribute)]
		public HexString MapContext { get; set; }

		[BinaryContent(Name = "BehaviourConfig", NodeType = BinaryContentTypes.Node)]
		public BehaviourConfig BehaviourConfig { get; set; }

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "InfectionInterval", NodeType = BinaryContentTypes.Attribute)]
		public HexString InfectionInterval { get; set; }

		[BinaryContent(Name = "SendNotifications", NodeType = BinaryContentTypes.Node)]
		public SendNotifications SendNotifications { get; set; }

		[BinaryContent(Name = "InfectedAreaSize", NodeType = BinaryContentTypes.Attribute)]
		public HexString InfectedAreaSize { get; set; }

		[BinaryContent(Name = "LastInfectedAreaSize", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastInfectedAreaSize { get; set; }

		[BinaryContent(Name = "InfectedBuildings", NodeType = BinaryContentTypes.Node)]
		public InfectedBuildings InfectedBuildings { get; set; }

		[BinaryContent(Name = "ProximityAffected", NodeType = BinaryContentTypes.Node)]
		public ProximityAffected ProximityAffected { get; set; }

		[BinaryContent(Name = "ProtectedBuildings", NodeType = BinaryContentTypes.Node)]
		public ProtectedBuildings ProtectedBuildings { get; set; }

		[BinaryContent(Name = "TotalInfectedBuildings", NodeType = BinaryContentTypes.Attribute)]
		public HexString TotalInfectedBuildings { get; set; }

		[BinaryContent(Name = "LastDestroyedBuildingID", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastDestroyedBuildingID { get; set; }

		[BinaryContent(Name = "FallbackBuildingID", NodeType = BinaryContentTypes.Attribute)]
		public HexString FallbackBuildingID { get; set; }

		[BinaryContent(Name = "StartBuildingID", NodeType = BinaryContentTypes.Attribute)]
		public HexString StartBuildingID { get; set; }

		[BinaryContent(Name = "StartBuildingGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString StartBuildingGUID { get; set; }

		[BinaryContent(Name = "WasResolverSent", NodeType = BinaryContentTypes.Attribute)]
		public HexString WasResolverSent { get; set; }

		[BinaryContent(Name = "ResolveActions", NodeType = BinaryContentTypes.Node)]
		public ResolveActions ResolveActions { get; set; }

		[BinaryContent(Name = "SourceReason", NodeType = BinaryContentTypes.Node)]
		public SourceReason SourceReason { get; set; }

		[BinaryContent(Name = "mobs", NodeType = BinaryContentTypes.Node)]
		public Mobs Mobs { get; set; }

		[BinaryContent(Name = "mobT1mapping", NodeType = BinaryContentTypes.Node)]
		public MobT1mapping MobT1mapping { get; set; }

	}
}
