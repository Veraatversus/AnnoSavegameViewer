namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class IncidentManager {

		[BinaryContent(Name = "NextIncidentID", NodeType = BinaryContentTypes.Attribute)]
		public Int32 NextIncidentID { get; set; }

		[BinaryContent(Name = "Incidents", NodeType = BinaryContentTypes.Node)]
		public Incidents Incidents { get; set; }

		[BinaryContent(Name = "SessionIntervals", NodeType = BinaryContentTypes.Node)]
		public SessionIntervals SessionIntervals { get; set; }

	}
}
