namespace AnnoSavegameViewer.Serialization.Core {
  using System;
  using System.Collections;
  using System.ComponentModel;
  using System.Runtime.CompilerServices;
  using System.Text;

  /// <summary> Represents a member configuration for reading and writing it as binary data. </summary>
  [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class BinaryContentAttribute : Attribute, INotifyPropertyChanged {

    #region Public Properties

    /// <summary> Gets or sets the format for <see cref="bool"/> members. Defaults to <see cref="BoolPattern.Byte"/>. </summary>
    public BoolPattern BoolPattern {
      get => boolPattern;
      set {
        if (boolPattern != value) {
          boolPattern = value;
          RaisePropertyChanged(nameof(BoolPattern));
        }
      }
    }

    /// <summary>
    /// Gets or sets the format for <see cref="DateTime"/> members. Defaults to <see cref="DateTimePattern.NetTicks"/>.
    /// </summary>
    public DateTimePattern DateTimePattern {
      get => dateTimePattern;
      set {
        if (dateTimePattern != value) {
          dateTimePattern = value;
          RaisePropertyChanged(nameof(DateTimePattern));
        }
      }
    }

    /// <summary>
    /// Gets or sets the format for <see cref="TimeSpan"/> members. Defaults to <see cref="TimeSpanPattern.MilliSeconds"/>.
    /// </summary>
    public TimeSpanPattern TimeSpanPattern {
      get => timeSpanPattern;
      set {
        if (timeSpanPattern != value) {
          timeSpanPattern = value;
          RaisePropertyChanged(nameof(TimeSpanPattern));
        }
      }
    }

    /// <summary>
    /// Gets or sets the encoding for <see cref="string"/> members. Defaults to <see
    /// cref="Encoding.UTF8"/> (utf-8).
    /// </summary>
    public string Encoding {
      get => encoding;
      set {
        if (encoding != value) {
          encoding = value;
          RaisePropertyChanged(nameof(Encoding));
        }
      }
    }

    /// <summary> Gets or sets the Endian for type members. Defaults to <see cref="Endian.System"/>. </summary>
    public Endian Endian {
      get => endian;
      set {
        if (endian != value) {
          endian = value;
          RaisePropertyChanged(nameof(Endian));
        }
      }
    }

    /// <summary>
    /// Gets or sets the number of elements to read or write. Required for <see cref="IEnumerable"/>
    /// members or strings when <see cref="StringCoding"/> is <see cref="StringCoding.Raw"/>.
    /// Multidimensional arrays are not supported.
    /// </summary>
    public int Length {
      get => length;
      set {
        if (length != value) {
          length = value;
          RaisePropertyChanged(nameof(Length));
        }
      }
    }

    /// <summary>
    /// Gets or sets the matching Name represented in the binary for this. Defaults to <see langword="null"/>.
    /// </summary>
    public string Name {
      get => name;
      set {
        if (name != value) {
          name = value;
          RaisePropertyChanged(nameof(Name));
        }
      }
    }

    /// <summary>
    /// Gets or sets the <see cref="BinaryContentTypes"/> Name represented in the binary for this.
    /// Defaults to <see cref="BinaryContentTypes.Both"/>.
    /// </summary>
    public BinaryContentTypes NodeType {
      get => nodeType;
      set {
        if (nodeType != value) {
          nodeType = value;
          RaisePropertyChanged(nameof(NodeType));
        }
      }
    }

    /// <summary> Gets or sets offset of this field in bytes. Can be negative. Defaults to 0. </summary>
    public int Offset {
      get => offset;
      set {
        if (offset != value) {
          offset = value;
          RaisePropertyChanged(nameof(Offset));
        }
      }
    }

    /// <summary>
    /// Gets or sets the number determining the order in which the member is read or written. If not
    /// specified, the members are written in alphabetical order.
    /// </summary>
    public int Order {
      get => order;
      set {
        if (order != value) {
          order = value;
          RaisePropertyChanged(nameof(Order));
        }
      }
    }

    /// <summary>
    /// Gets or sets a value indicating whether enum values are checked for a valid value or set of
    /// flags. Defaults to <see langword="false"/>.
    /// </summary>
    public bool Strict {
      get => strict;
      set {
        if (strict != value) {
          strict = value;
          RaisePropertyChanged(nameof(Strict));
        }
      }
    }

    /// <summary>
    /// Gets or sets the format for <see cref="string"/> members. Defaults to <see cref="StringPattern.FixByteCount"/>.
    /// </summary>
    public StringPattern StringPattern {
      get => stringPattern;
      set {
        if (stringPattern != value) {
          stringPattern = value;
          RaisePropertyChanged(nameof(StringPattern));
        }
      }
    }

    /// <summary>
    /// Gets or sets the <see cref="CompressionTypes"/> Name represented in the binary for this.
    /// Defaults to <see cref="CompressionType.None"/>.
    /// </summary>
    public CompressionTypes CompressionType {
      get => compressionType;
      set {
        if (compressionType != value) {
          compressionType = value;
          RaisePropertyChanged(nameof(CompressionType));
        }
      }
    }

    /// <summary>
    /// Gets or sets the <see cref="ConversationTypes"/> Name represented in the binary for this.
    /// Defaults to <see cref="ConversationTypes.None"/>.
    /// </summary>
    public ConversationTypes ConversationType {
      get => conversationType;
      set {
        if (conversationType != value) {
          conversationType = value;
          RaisePropertyChanged(nameof(ConversationType));
        }
      }
    }

    /// <summary> Gets or sets the rda block number. Defaults to -1 if not set./&gt;. </summary>
    public int RdaBlock {
      get => rdaBlock;
      set {
        if (rdaBlock != value) {
          rdaBlock = value;
          RaisePropertyChanged(nameof(RdaBlock));
        }
      }
    }

    /// <summary> Gets or sets the file name inside the rda format. Defaults to <see cref="null"/>. </summary>
    public string RdaFile {
      get => rdaFile;
      set {
        if (rdaFile != value) {
          rdaFile = value;
          RaisePropertyChanged(nameof(RdaFile));
        }
      }
    }

    #endregion Public Properties

    #region Public Events

    public event PropertyChangedEventHandler PropertyChanged;

    #endregion Public Events

    #region Public Methods

    public void RaisePropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    #endregion Public Methods

    #region Public Fields

    public ConversationTypes conversationType = ConversationTypes.None;

    #endregion Public Fields

    #region Internal Fields

    internal static readonly BinaryContentAttribute Default = new BinaryContentAttribute();

    #endregion Internal Fields

    #region Private Fields

    private string rdaFile;
    private int rdaBlock = -1;
    private CompressionTypes compressionType = CompressionTypes.None;
    private StringPattern stringPattern;
    private bool strict;
    private int order = int.MinValue;
    private int offset;
    private BinaryContentTypes nodeType = BinaryContentTypes.Both;
    private string name;
    private int length;
    private Endian endian;
    private string encoding;
    private TimeSpanPattern timeSpanPattern;
    private DateTimePattern dateTimePattern;
    private BoolPattern boolPattern;

    #endregion Private Fields
  }
}