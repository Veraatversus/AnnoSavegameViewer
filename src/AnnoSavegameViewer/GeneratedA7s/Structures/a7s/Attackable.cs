// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Attackable {

		[BinaryContent(Name = "LastAttackerID", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastAttackerID { get; set; }

		[BinaryContent(Name = "IslandWarFlagID", NodeType = BinaryContentTypes.Attribute)]
		public HexString IslandWarFlagID { get; set; }

		[BinaryContent(Name = "ExplosionCheckThreshold", NodeType = BinaryContentTypes.Attribute)]
		public HexString ExplosionCheckThreshold { get; set; }

		[BinaryContent(Name = "LastDamageTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastDamageTime { get; set; }

		[BinaryContent(Name = "LastDamageByAttacker", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastDamageByAttacker { get; set; }

		[BinaryContent(Name = "HealTickRemainder", NodeType = BinaryContentTypes.Attribute)]
		public HexString HealTickRemainder { get; set; }

		[BinaryContent(Name = "LastDamageOwner", NodeType = BinaryContentTypes.Node)]
		public LastDamageOwner LastDamageOwner { get; set; }

		[BinaryContent(Name = "LastOvertakeDamageDealerOwner", NodeType = BinaryContentTypes.Node)]
		public LastOvertakeDamageDealerOwner LastOvertakeDamageDealerOwner { get; set; }

		[BinaryContent(Name = "StatusEffects", NodeType = BinaryContentTypes.Node)]
		public StatusEffects StatusEffects { get; set; }

		[BinaryContent(Name = "ManagedAttackersByRange", NodeType = BinaryContentTypes.Node)]
		public ManagedAttackersByRange ManagedAttackersByRange { get; set; }

		[BinaryContent(Name = "IsWhiteFlagActive", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsWhiteFlagActive { get; set; }

		[BinaryContent(Name = "HitPoints", NodeType = BinaryContentTypes.Attribute)]
		public HexString HitPoints { get; set; }

		[BinaryContent(Name = "RemainderDamage", NodeType = BinaryContentTypes.Attribute)]
		public HexString RemainderDamage { get; set; }

		[BinaryContent(Name = "IsDead", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsDead { get; set; }

	}
}
