namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SettledTrackerValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public SettledTrackerValuesNoneValue Value { get; set; }

	}
}
