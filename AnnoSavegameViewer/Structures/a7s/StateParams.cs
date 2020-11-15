namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class StateParams {

		[BinaryContent(Name = "PtPos", NodeType = BinaryContentTypes.Attribute)]
		public HexString PtPos { get; set; }

		[BinaryContent(Name = "Radius", NodeType = BinaryContentTypes.Attribute)]
		public HexString Radius { get; set; }

		[BinaryContent(Name = "Object", NodeType = BinaryContentTypes.Node)]
		public StateParamsObject Object { get; set; }

		[BinaryContent(Name = "AttachRadius", NodeType = BinaryContentTypes.Attribute)]
		public HexString AttachRadius { get; set; }

		[BinaryContent(Name = "AttachObject", NodeType = BinaryContentTypes.Node)]
		public AttachObject AttachObject { get; set; }

		[BinaryContent(Name = "SessionTranferInfo", NodeType = BinaryContentTypes.Node)]
		public SessionTranferInfo SessionTranferInfo { get; set; }

		[BinaryContent(Name = "StateOnQuitPassiveAttack", NodeType = BinaryContentTypes.Node)]
		public StateOnQuitPassiveAttack StateOnQuitPassiveAttack { get; set; }

		[BinaryContent(Name = "OptimalAttackMovementData", NodeType = BinaryContentTypes.Node)]
		public OptimalAttackMovementData OptimalAttackMovementData { get; set; }

		[BinaryContent(Name = "TargetStoppedMoving", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetStoppedMoving { get; set; }

		[BinaryContent(Name = "m_AllowTakeControllOnBeeingAttacked", NodeType = BinaryContentTypes.Attribute)]
		public HexString M_AllowTakeControllOnBeeingAttacked { get; set; }

		[BinaryContent(Name = "HasOptimalAttackMovementData", NodeType = BinaryContentTypes.Attribute)]
		public HexString HasOptimalAttackMovementData { get; set; }

		[BinaryContent(Name = "HasDesiredOffsetToTarget", NodeType = BinaryContentTypes.Attribute)]
		public HexString HasDesiredOffsetToTarget { get; set; }

		[BinaryContent(Name = "DesiredOffsetToTarget", NodeType = BinaryContentTypes.Attribute)]
		public HexString DesiredOffsetToTarget { get; set; }

		[BinaryContent(Name = "SuppressPassiveAttack", NodeType = BinaryContentTypes.Attribute)]
		public HexString SuppressPassiveAttack { get; set; }

	}
}
