/// <summary> Represents a Point in 3D with <see cref="Int32"/> precession. </summary>
namespace AnnoSavegameViewer.Structures.Savegame {
  using AnnoSavegameViewer.Serialization.Core;

  public struct Point3DInt {

    #region Public Properties

    [BinaryContent(Order = 0)]
    public int X { get; set; }

    [BinaryContent(Order = 1)]
    public int Y { get; set; }

    [BinaryContent(Order = 2)]
    public int Z { get; set; }

    #endregion Public Properties

    #region Public Methods

    public override string ToString() => $"X={X}, Y={Y}, Z={Z}";

    #endregion Public Methods
  }
}