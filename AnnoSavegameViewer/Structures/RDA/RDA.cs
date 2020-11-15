namespace AnnoSavegameViewer.Structures.RDA {
  using AnnoSavegameViewer.Serialization.Memory;
  using System;
  using System.Collections.Generic;

  public class Rda {

		#region Public Properties

		public RdaHeader RdaHeader { get; private set; }
		public List<RdaBlock> Blocks { get; private set; }

		#endregion Public Properties

		#region Public Constructors

		public Rda(ReadOnlyMemory<byte> bytes) {
			var reader = bytes.ToReader();
			ReadRda(reader);
		}

    public Rda(ref MemoryReader reader) => ReadRda(reader);

    #endregion Public Constructors

    #region Private Methods

    private void ReadRda(MemoryReader reader) {
			RdaHeader = new RdaHeader(ref reader);

			Blocks = new List<RdaBlock>();
			var nextHeaderOffset = (int)RdaHeader.FirstBlockHeaderOffset;
      for (var index = 0; nextHeaderOffset <= reader.Length - 32; index++) {
        var block = new RdaBlock(ref reader, nextHeaderOffset) { Index = index };
        Blocks.Add(block);
        nextHeaderOffset = (int)block.Header.NextHeaderOffset;
      }
    }

		#endregion Private Methods
	}
}