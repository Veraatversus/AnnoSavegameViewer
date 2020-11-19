// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MetaObjectMapValue {

		[BinaryContent(Name = "guid", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt Guid { get; set; }

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public Int64 ID { get; set; }

		[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
		public MetaObjectMapValuesNoneParticipantID ParticipantID { get; set; }

		[BinaryContent(Name = "MetaProfile", NodeType = BinaryContentTypes.Node)]
		public MetaProfile MetaProfile { get; set; }

		[BinaryContent(Name = "MetaParticipantMessages", NodeType = BinaryContentTypes.Node)]
		public MetaParticipantMessages MetaParticipantMessages { get; set; }

		[BinaryContent(Name = "MetaInteraction", NodeType = BinaryContentTypes.Node)]
		public MetaInteraction MetaInteraction { get; set; }

		[BinaryContent(Name = "MetaGameObjectReference", NodeType = BinaryContentTypes.Node)]
		public MetaGameObjectReference MetaGameObjectReference { get; set; }

		[BinaryContent(Name = "MetaDiplomacy", NodeType = BinaryContentTypes.Node)]
		public MetaDiplomacy MetaDiplomacy { get; set; }

		[BinaryContent(Name = "MetaProfileCounter", NodeType = BinaryContentTypes.Node)]
		public MetaProfileCounter MetaProfileCounter { get; set; }

		[BinaryContent(Name = "MetaInfluence", NodeType = BinaryContentTypes.Node)]
		public MetaInfluence MetaInfluence { get; set; }

		[BinaryContent(Name = "MetaTrader", NodeType = BinaryContentTypes.Node)]
		public MetaTrader MetaTrader { get; set; }

		[BinaryContent(Name = "MetaConstructionAI", NodeType = BinaryContentTypes.Node)]
		public MetaConstructionAI MetaConstructionAI { get; set; }

		[BinaryContent(Name = "BuyShares", NodeType = BinaryContentTypes.Node)]
		public BuyShares BuyShares { get; set; }

		[BinaryContent(Name = "MetaUniqueBuildingHandler", NodeType = BinaryContentTypes.Node)]
		public MetaUniqueBuildingHandler MetaUniqueBuildingHandler { get; set; }

		[BinaryContent(Name = "MetaExpeditionUser", NodeType = BinaryContentTypes.Node)]
		public MetaExpeditionUser MetaExpeditionUser { get; set; }

		[BinaryContent(Name = "MetaBuildPermits", NodeType = BinaryContentTypes.Node)]
		public MetaBuildPermits MetaBuildPermits { get; set; }

		[BinaryContent(Name = "Deactivated", NodeType = BinaryContentTypes.Attribute)]
		public HexString Deactivated { get; set; }

	}
}
