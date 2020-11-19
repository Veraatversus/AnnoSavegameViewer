// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace CSharpCode.SharpZipLib.Zip.Compression {
  /// <summary>
  /// This class stores the pending output of the Deflater.
  ///
  /// author of the original java version : Jochen Hoenicke
  /// </summary>
  public class DeflaterPending : PendingBuffer {
    /// <summary>
    /// Construct instance with default buffer size
    /// </summary>
    public DeflaterPending() : base(DeflaterConstants.PENDING_BUF_SIZE) {
    }
  }
}
