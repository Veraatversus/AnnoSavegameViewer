// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class PropertyPalace {

		[BinaryContent(Name = "ActiveDecrees", NodeType = BinaryContentTypes.Node)]
		public ActiveDecrees ActiveDecrees { get; set; }

		[BinaryContent(Name = "EffectRange", NodeType = BinaryContentTypes.Attribute)]
		public HexString EffectRange { get; set; }

		[BinaryContent(Name = "ParagonLevel", NodeType = BinaryContentTypes.Attribute)]
		public HexString ParagonLevel { get; set; }

		[BinaryContent(Name = "NewParagonLevel", NodeType = BinaryContentTypes.Attribute)]
		public HexString NewParagonLevel { get; set; }

		[BinaryContent(Name = "LastAreaAttractiveness", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastAreaAttractiveness { get; set; }

		[BinaryContent(Name = "MinistryStates", NodeType = BinaryContentTypes.Node)]
		public MinistryStates MinistryStates { get; set; }

		[BinaryContent(Name = "DecreeStates", NodeType = BinaryContentTypes.Node)]
		public DecreeStates DecreeStates { get; set; }

		[BinaryContent(Name = "ActiveEffects", NodeType = BinaryContentTypes.Node)]
		public PropertyPalaceActiveEffects ActiveEffects { get; set; }

	}
}
