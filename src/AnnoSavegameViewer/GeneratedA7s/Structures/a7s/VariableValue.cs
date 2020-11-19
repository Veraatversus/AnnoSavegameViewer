// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class VariableValue {

		[BinaryContent(Name = "FloatValue", NodeType = BinaryContentTypes.Node)]
		public FloatValue FloatValue { get; set; }

		[BinaryContent(Name = "Variable", NodeType = BinaryContentTypes.Node)]
		public VariableValueVariable Variable { get; set; }

	}
}
