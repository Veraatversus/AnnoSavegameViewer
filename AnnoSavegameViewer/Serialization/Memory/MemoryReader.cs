using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Serialization.Reflection.TypeData;
using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace AnnoSavegameViewer.Serialization.Memory {

  /// <summary>
  /// Represents a cursor in a <see cref="ReadOnlyMemory{Byte}"/> at which data is read from.
  /// </summary>
  [DebuggerDisplay(nameof(MemoryReader) + ", Position={Position}")]
  public class MemoryReader {

    #region Public Properties

    /// <summary>
    /// Gets a value indicating whether the current position reached the end of the span.
    /// </summary>
    public bool IsEndOfSpan => Memory.Length - Position <= 0;

    /// <summary>
    /// Gets the <see cref="ReadOnlySpan{Byte}"/> from which data is read.
    /// </summary>
    //public ReadOnlySpan<byte> Span { get; }

    /// <summary>
    /// Gets the length of the underlying <see cref="Span"/>.
    /// </summary>
    public int Length => Memory.Length;

    #endregion Public Properties

    #region Public Fields

    /// <summary>
    /// Gets the <see cref="Memory{Byte}"/> from which data is read.
    /// </summary>
    public ReadOnlyMemory<byte> Memory;

    /// <summary>
    /// Gets or sets the index in the <see cref="Span"/> at which the next data is read from.
    /// </summary>
    public int Position;

    #endregion Public Fields

    #region Public Constructors

    // { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="MemoryReader"/> struct to operate on the given
    /// <paramref name="span"/>.
    /// </summary>
    /// <param name="span">The <see cref="ReadOnlyMemory{Byte}"/> to read from.</param>
    public MemoryReader(ReadOnlyMemory<byte> memory) {
      Memory = memory;
      Position = 0;
    }

    #endregion Public Constructors

    #region Public Methods

    /// <summary>
    /// Aligns the position to the given byte multiple.
    /// </summary>
    /// <param name="alignment">
    /// The byte multiple to align to. If negative, the position is decreased to the previous
    /// multiple rather than the next one.
    /// </param>
    /// <returns>The new position.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int Align(int alignment) => Position += MathTools.GetAlignmentDelta(Position, alignment);

    /// <summary>
    /// Gets a <see cref="MemoryReader"/> for the remaining data following the current position.
    /// </summary>
    /// <returns>The <see cref="MemoryReader"/> covering the remaining data.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public MemoryReader Slice() => new MemoryReader(Memory.Slice(Position));

    /// <summary>
    /// Gets a <see cref="MemoryReader"/> for the data covered from the given <paramref
    /// name="start"/> position.
    /// </summary>
    /// <param name="start">The position from which to start covering data.</param>
    /// <returns>The <see cref="MemoryReader"/> covering the remaining data.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public MemoryReader Slice(int start) => new MemoryReader(Memory.Slice(start));

    /// <summary>
    /// Gets a <see cref="MemoryReader"/> for the data covered by the given <paramref name="start"/>
    /// position and <paramref name="length"/>.
    /// </summary>
    /// <param name="start">The position from which to start covering data.</param>
    /// <param name="length">The number of bytes to cover.</param>
    /// <returns>The <see cref="MemoryReader"/> covering the remaining data.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public MemoryReader Slice(int start, int length) => new MemoryReader(Memory.Slice(start, length));

    /// <summary>
    /// Reads a <see cref="Boolean"/> value from the given offset and by the given pattern.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Boolean ReadBoolean(BoolPattern pattern = default, int offset = 0) {
      Memory.Span.Slice(Position).ReadBoolean(out var result, out var _, offset, pattern);
      this.Position += offset + pattern switch
      {
        BoolPattern.Byte => 1,
        BoolPattern.Word => 2,
        BoolPattern.Dword => 4
      };
      return result;
    }

    /// <summary>
    /// Reads the given number of <see cref="Byte"/> values from the given offset.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Byte[] ReadBytes(int count, Endian endian = Endian.System, int offset = 0) {
      Position += offset + count;
      return Memory.Span.Slice(Position).ReadBytes(count, offset, endian);
    }

    /// <summary>
    /// Reads a <see cref="Byte"/> value from the given offset.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Byte ReadByte(int offset = 0) {
      Memory.Span.Slice(Position).ReadByte(out var result, offset);
      Position += offset + sizeof(Byte);
      return result;
    }

    /// <summary>
    /// Reads a <see cref="DateTime"/> value from the given offset by the given pattern.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public DateTime ReadDateTime(DateTimePattern pattern = default, Endian endian = Endian.System, int offset = 0) {
      Memory.Span.Slice(Position).ReadDateTime(out var result, offset, pattern, endian);
      this.Position += offset + pattern switch
      {
        DateTimePattern.CTime => 4,
        DateTimePattern.CTime64 => 8,
        DateTimePattern.NetTicks => 8
      };
      return result;
    }

    /// <summary>
    /// Reads a <see cref="Decimal"/> value from the given offset.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Decimal ReadDecimal(int offset = 0) {
      Memory.Span.Slice(Position).ReadDecimal(out var result, offset);
      Position += offset + sizeof(Decimal);
      return result;
    }

    /// <summary>
    /// Reads a <see cref="Double"/> value from the given offset.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Double ReadDouble(Endian endian = Endian.System, int offset = 0) {
      Memory.Span.Slice(Position).ReadDouble(out var result, offset, endian);
      Position += offset + sizeof(Double);
      return result;
    }

    /// <summary>
    /// Reads an <see cref="Enum"/> value from the given offset, using the size of the underlying type.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T ReadEnum<T>(Endian endian = Endian.System, int offset = 0) where T : struct, Enum {
      Memory.Span.Slice(Position).ReadEnum(out T result, out var usedBytes, offset, endian);
      Position += offset + usedBytes;
      return result;
    }

    // <summary>
    /// Reads an <see cref="Enum"/> value from the given offset, using the size of the underlying
    /// type. </summary> <returns>The value retrieved from the given offset.</returns> <exception
    /// cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public object ReadEnum(Type enumType, bool strict, Endian endian = Endian.System, int offset = 0) {
      var valueType = Enum.GetUnderlyingType(enumType);
      object value;

      if (valueType == typeof(Byte))
        value = ReadByte(offset);
      else if (valueType == typeof(SByte))
        value = ReadSByte(offset);
      else if (valueType == typeof(Int16))
        value = ReadInt16(endian, offset);
      else if (valueType == typeof(Int32))
        value = ReadInt32(endian, offset);
      else if (valueType == typeof(Int64))
        value = ReadInt64(endian, offset);
      else if (valueType == typeof(UInt16))
        value = ReadUInt16(endian, offset);
      else if (valueType == typeof(UInt32))
        value = ReadUInt32(endian, offset);
      else if (valueType == typeof(UInt64))
        value = ReadUInt64(endian, offset);
      else
        throw new NotImplementedException($"Unsupported enum type {valueType}.");

      // Check if the value is defined in the enumeration, if requested.
      if (strict)
        EnumTools.Validate(enumType, value);
      return value;
    }

    /// <summary>
    /// Reads an <see cref="Enum"/> value from the given offset, using the size of the underlying
    /// type. The value is validated, throwing an exception if it is not defined in the enum.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentException">The value is not defined in the enum.</exception>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T ReadEnumSafe<T>(Endian endian = Endian.System, int offset = 0) where T : struct, Enum {
      Memory.Span.Slice(Position).ReadEnumSafe(out T result, out var usedBytes, offset, endian);
      Position += offset + usedBytes;
      return result;
    }

    /// <summary>
    /// Reads an <see cref="Int16"/> value from the given offset.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Int16 ReadInt16(Endian endian = Endian.System, int offset = 0) {
      Memory.Span.Slice(Position).ReadInt16(out var result, offset, endian);
      Position += offset + sizeof(Int16);
      return result;
    }

    /// <summary>
    /// Reads an <see cref="Int32"/> value from the given offset.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Int32 ReadInt32(Endian endian = Endian.System, int offset = 0) {
      Memory.Span.Slice(Position).ReadInt32(out var result, offset, endian);
      Position += offset + sizeof(Int32);
      return result;
    }

    /// <summary>
    /// Reads an <see cref="Int32"/> value from the given offset. The value is stored in 1 to 5
    /// bytes, only using another byte if it does not fit into 7 more bits of the current one.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentException">The data available is not a 7-bit encoded integer.</exception>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Int32 ReadInt32Bit7(int offset = 0) {
      Memory.Span.Slice(Position).ReadInt32Bit7(out var result, out var usedBytes, offset);
      Position += offset + usedBytes;
      return result;
    }

    /// <summary>
    /// Reads an <see cref="Int64"/> value from the given offset.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Int64 ReadInt64(Endian endian = Endian.System, int offset = 0) {
      Memory.Span.Slice(Position).ReadInt64(out var result, offset, endian);
      Position += offset + sizeof(Int64);
      return result;
    }

    /// <summary>
    /// Reads an <see cref="SByte"/> value from the given offset.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public SByte ReadSByte(int offset = 0) {
      Memory.Span.Slice(Position).ReadSByte(out var result, offset);
      Position += offset + sizeof(SByte);
      return result;
    }

    /// <summary>
    /// Reads an <see cref="Single"/> value from the given offset.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Single ReadSingle(Endian endian = Endian.System, int offset = 0) {
      Memory.Span.Slice(Position).ReadSingle(out var result, offset, endian);
      Position += offset + sizeof(Single);
      return result;
    }

    /// <summary>
    /// Reads a <see cref="String"/> value from the given offset and by the given pattern and the
    /// given length.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public String ReadString(Encoding encoding = null, StringPattern stringPattern = StringPattern.VariableByteCount, int length = 0, int offset = 0) {
      Memory.Span.Slice(Position).ReadString(out var value, out var usedBytes, offset, length, encoding, stringPattern);
      Position += offset + usedBytes;
      return value;
    }

    /// <summary>
    /// Reads a <see cref="UInt16"/> value from the given offset.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UInt16 ReadUInt16(Endian endian = Endian.System, int offset = 0) {
      Memory.Span.Slice(Position).ReadUInt16(out var result, offset, endian);
      Position += offset + sizeof(UInt16);
      return result;
    }

    /// <summary>
    /// Reads a <see cref="UInt32"/> value from the given offset.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UInt32 ReadUInt32(Endian endian = Endian.System, int offset = 0) {
      Memory.Span.Slice(Position).ReadUInt32(out var result, offset, endian);
      Position += offset + sizeof(UInt32);
      return result;
    }

    /// <summary>
    /// Reads a <see cref="UInt64"/> value from the given offset.
    /// </summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UInt64 ReadUInt64(Endian endian = Endian.System, int offset = 0) {
      Memory.Span.Slice(Position).ReadUInt64(out var result, offset, endian);
      Position += offset + sizeof(UInt64);
      return result;
    }

    public T ReadObject<T>() => (T)ReadObject(typeof(T));

    public object ReadObject(Type type, BinaryContentAttribute attribute = null) {
      var att = attribute ?? new BinaryContentAttribute();
      var encoding = att.Encoding != null ? Encoding.GetEncoding(att.Encoding) : null;

      if (type == typeof(string)) {
        var lenght = att.Length != 0 ? att.Length : Length - att.Offset;
        return ReadString(encoding, att.StringPattern, lenght, att.Offset);
      }
      else if (type.IsEnumerable())
        throw new InvalidOperationException("Multidimensional arrays cannot be read directly.");
      else if (type == typeof(bool))
        return ReadBoolean(att.BoolPattern, att.Offset);
      else if (type == typeof(byte))
        return ReadByte(att.Offset);
      else if (type == typeof(DateTime))
        return ReadDateTime(att.DateTimePattern, att.Endian, att.Offset);
      else if (type == typeof(decimal))
        return ReadDecimal(att.Offset);
      else if (type == typeof(double))
        return ReadDouble(att.Endian, att.Offset);
      else if (type == typeof(short))
        return ReadInt16(att.Endian, att.Offset);
      else if (type == typeof(int))
        return ReadInt32(att.Endian, att.Offset);
      else if (type == typeof(long))
        return ReadInt64(att.Endian, att.Offset);
      else if (type == typeof(sbyte))
        return ReadSByte(att.Offset);
      else if (type == typeof(float))
        return ReadSingle(att.Endian, att.Offset);
      else if (type == typeof(ushort))
        return ReadUInt16(att.Endian, att.Offset);
      else if (type == typeof(uint))
        return ReadUInt32(att.Endian, att.Offset);
      else if (type == typeof(ulong))
        return ReadUInt64(att.Endian);
      else if (type.IsEnum)
        return ReadEnum(type, att.Strict, att.Endian, att.Offset);
      else if (type == typeof(object))
        return ReadBytes(Length - att.Offset, att.Endian, att.Offset);
      else
        return ReadCustomObject(type);
    }

    public object ReadCustomObject(Type type, object instance = null) {
      var typeData = TypeData.GetTypeData(type);
      instance ??= typeData.GetInstance();
      foreach (var orderedMember in typeData.OrderedNodes) {
        ReadMember(instance, orderedMember.Value);
      }
      foreach (var unorderedMember in typeData.UnorderedNodes) {
        if (IsEndOfSpan) {
          break;
        }
        ReadMember(instance, unorderedMember.Value);
      }
      return instance;
    }

    #endregion Public Methods

    #region Private Methods

    private void ReadMember(object instance, MemberData member) {
      // Read the value and respect settings stored in the member attribute.
      object value = null;
      var elementType = member.Type.GetFirstUnderlayingType();
      if (elementType == null) {
        value = ReadObject(member.Type, member.Attribute);
      }
      else if (member.Type.IsArray) {
        Array values = Array.CreateInstance(elementType, member.Attribute.Length);
        for (int i = 0; i < values.Length; i++) {
          values.SetValue(ReadObject(elementType, member.Attribute), i);
        }
        value = values;
      }
      else if (member.Type.IsGenericType) {
        var existingObject = member.MemberInfo.GetMemberValue(instance);
        if (existingObject == null) {
          existingObject = TypeData.GetTypeData(member.Type).GetInstance();
          member.MemberInfo.SetMemberValue(instance, existingObject);
        }

        if (existingObject is IList list) {
          while (!IsEndOfSpan) {
            list.Add(ReadObject(elementType, member.Attribute));
          }
          return;
        }
        else {
          throw new NotImplementedException(
          $"Type {member.Type} is not supported by the serializer.");
        }
      }

      // Set the read value.
      switch (member.MemberInfo) {
        case FieldInfo field:
          field.SetValue(instance, value);
          break;

        case PropertyInfo property:
          property.SetValue(instance, value);
          break;
      }
    }

    #endregion Private Methods
  }
}