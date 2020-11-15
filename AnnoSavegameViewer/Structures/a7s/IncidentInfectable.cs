namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class IncidentInfectable {

		[BinaryContent(Name = "perIncidentData", NodeType = BinaryContentTypes.Node)]
		public PerIncidentData PerIncidentData { get; set; }

		[BinaryContent(Name = "activeType", NodeType = BinaryContentTypes.Node)]
		public IncidentInfectableActiveType ActiveType { get; set; }

		[BinaryContent(Name = "DensityBuffer", NodeType = BinaryContentTypes.Attribute)]
		public HexString DensityBuffer { get; set; }

		[BinaryContent(Name = "intensityInterval", NodeType = BinaryContentTypes.Attribute)]
		public HexString IntensityInterval { get; set; }

		[BinaryContent(Name = "activeIncident", NodeType = BinaryContentTypes.Attribute)]
		public HexString ActiveIncident { get; set; }

		[BinaryContent(Name = "intensity", NodeType = BinaryContentTypes.Attribute)]
		public HexString Intensity { get; set; }

		[BinaryContent(Name = "increaseRate", NodeType = BinaryContentTypes.Attribute)]
		public HexString IncreaseRate { get; set; }

		[BinaryContent(Name = "helpOnTheWay", NodeType = BinaryContentTypes.Attribute)]
		public HexString HelpOnTheWay { get; set; }

	}
}
