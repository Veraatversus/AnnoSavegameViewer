// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Serialization.Memory {
  using AnnoSerializer.Serialization.Core;
  using AnnoSerializer.Serialization.Reflection.TypeData;
  using System;
  using System.Collections;
  using System.Diagnostics;
  using System.Runtime.CompilerServices;
  using System.Text;

  /// <summary>
  /// Represents a cursor in a <see cref="ReadOnlyMemory{T}{Byte}"/> at which data is read from.
  /// </summary>
  [DebuggerDisplay(nameof(MemoryReader) + ", Position={Position}")]
  public class MemoryReader {

    #region Public Properties

    /// <summary>
    /// Gets a value indicating whether the current position reached the end of the span.
    /// </summary>
    public bool IsEndOfSpan => Memory.Length - Position <= 0;

    /// <summary> Gets the <see cref="Memory{Byte}"/> from which data is read. </summary>
    public ReadOnlyMemory<byte> Memory { get; }

    /// <summary>
    /// Gets or sets the index in the <see cref="Span"/> at which the next data is read from.
    /// </summary>
    public int Position { get; set; }

    /// <summary> Gets the length of the underlying <see cref="Span"/>. </summary>
    public int Length => Memory.Length;

    #endregion Public Properties

    #region Public Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="MemoryReader"/> struct to operate on the given
    /// <paramref name="memory"/>.
    /// </summary>
    /// <param name="memory"> The <see cref="ReadOnlyMemory{Byte}"/> to read from. </param>
    public MemoryReader(ReadOnlyMemory<byte> memory) {
      Memory = memory;
      Position = 0;
    }

    #endregion Public Constructors

    #region Public Methods

    /// <summary> Aligns the position to the given byte multiple. </summary>
    /// <param name="alignment">
    /// The byte multiple to align to. If negative, the position is decreased to the previous
    /// multiple rather than the next one.
    /// </param>
    /// <returns> The new position. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int Align(int alignment) => Position += MathTools.GetAlignmentDelta(Position, alignment);

    /// <summary>
    /// Gets a <see cref="MemoryReader"/> for the remaining data following the current position.
    /// </summary>
    /// <returns> The <see cref="MemoryReader"/> covering the remaining data. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public MemoryReader Slice() => new MemoryReader(Memory[Position..]);

    /// <summary>
    /// Gets a <see cref="MemoryReader"/> for the data covered from the given <paramref
    /// name="start"/> position.
    /// </summary>
    /// <param name="start"> The position from which to start covering data. </param>
    /// <returns> The <see cref="MemoryReader"/> covering the remaining data. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public MemoryReader Slice(int start) => new MemoryReader(Memory[start..]);

    /// <summary>
    /// Gets a <see cref="MemoryReader"/> for the data covered by the given <paramref name="start"/>
    /// position and <paramref name="length"/>.
    /// </summary>
    /// <param name="start"> The position from which to start covering data. </param>
    /// <param name="length"> The number of bytes to cover. </param>
    /// <returns> The <see cref="MemoryReader"/> covering the remaining data. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public MemoryReader Slice(int start, int length) => new MemoryReader(Memory.Slice(start, length));

    /// <summary>
    /// Reads a <see cref="bool"/> value from the given offset and by the given pattern.
    /// </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool ReadBoolean(BoolPattern pattern = default, int offset = 0) {
      Memory.Span[Position..].ReadBoolean(out var result, out var usedBytes, offset, pattern);
      this.Position += usedBytes;
      return result;
    }

    /// <summary> Reads the given number of <see cref="byte"/> values from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte[] ReadBytes(int count, Endian endian = Endian.System, int offset = 0) {
      Position += offset + count;
      return Memory.Span[Position..].ReadBytes(count, offset, endian);
    }

    /// <summary> Reads a <see cref="byte"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte ReadByte(int offset = 0) {
      Memory.Span[Position..].ReadByte(out var result, offset);
      Position += offset + sizeof(byte);
      return result;
    }

    /// <summary> Reads a <see cref="DateTime"/> value from the given offset by the given pattern. </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public DateTime ReadDateTime(DateTimePattern pattern = default, Endian endian = Endian.System, int offset = 0) {
      Memory.Span[Position..].ReadDateTime(out var result, out var usedBytes, offset, pattern, endian);
      this.Position += usedBytes;
      return result;
    }

    /// <summary> Reads a <see cref="TimeSpan/> value from the given offset by the given pattern.
    /// </summary> <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public TimeSpan ReadTimeSpan(TimeSpanPattern pattern = default, Endian endian = Endian.System, int offset = 0) {
      Memory.Span[Position..].ReadTimeSpan(out var result, offset, pattern, endian);
      this.Position += 8 + offset;
      return result;
    }

    /// <summary> Reads a <see cref="decimal"/> value from the given offset. </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public decimal ReadDecimal(int offset = 0) {
      Memory.Span[Position..].ReadDecimal(out var result, offset);
      Position += offset + sizeof(decimal);
      return result;
    }

    /// <summary> Reads a <see cref="double"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public double ReadDouble(Endian endian = Endian.System, int offset = 0) {
      Memory.Span[Position..].ReadDouble(out var result, offset, endian);
      Position += offset + sizeof(double);
      return result;
    }

    /// <summary>
    /// Reads an <see cref="Enum"/> value from the given offset, using the size of the underlying type.
    /// </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T ReadEnum<T>(Endian endian = Endian.System, int offset = 0) where T : struct, Enum {
      Memory.Span[Position..].ReadEnum(out T result, out var usedBytes, offset, endian);
      Position += usedBytes;
      return result;
    }

    /// <summary>Reads an <see cref="Enum"/> value from the given offset, using the size of the underlying type.</summary>
    /// <returns>The value retrieved from the given offset.</returns>
    /// <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public object ReadEnum(Type enumType, bool strict, Endian endian = Endian.System, int offset = 0) {
      Memory.Span[Position..].ReadEnum(out var result, out var usedBytes, enumType, strict, offset, endian);
      Position += usedBytes;
      return result;
    }

    /// <summary>
    /// Reads an <see cref="Enum"/> value from the given offset, using the size of the underlying
    /// type. The value is validated, throwing an exception if it is not defined in the enum.
    /// </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentException"> The value is not defined in the enum. </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T ReadEnumSafe<T>(Endian endian = Endian.System, int offset = 0) where T : struct, Enum {
      Memory.Span[Position..].ReadEnumSafe(out T result, out var usedBytes, offset, endian);
      Position += usedBytes;
      return result;
    }

    /// <summary> Reads an <see cref="short"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public short ReadInt16(Endian endian = Endian.System, int offset = 0) {
      Memory.Span[Position..].ReadInt16(out var result, offset, endian);
      Position += offset + sizeof(short);
      return result;
    }

    /// <summary> Reads an <see cref="int"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int ReadInt32(Endian endian = Endian.System, int offset = 0) {
      Memory.Span[Position..].ReadInt32(out var result, offset, endian);
      Position += offset + sizeof(int);
      return result;
    }

    /// <summary>
    /// Reads an <see cref="int"/> value from the given offset. The value is stored in 1 to 5
    /// bytes, only using another byte if it does not fit into 7 more bits of the current one.
    /// </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentException"> The data available is not a 7-bit encoded integer. </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int ReadInt32Bit7(int offset = 0) {
      Memory.Span[Position..].ReadInt32Bit7(out var result, out var usedBytes, offset);
      Position += usedBytes;
      return result;
    }

    /// <summary> Reads an <see cref="long"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public long ReadInt64(Endian endian = Endian.System, int offset = 0) {
      Memory.Span[Position..].ReadInt64(out var result, offset, endian);
      Position += offset + sizeof(long);
      return result;
    }

    /// <summary> Reads an <see cref="sbyte"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public sbyte ReadSByte(int offset = 0) {
      Memory.Span[Position..].ReadSByte(out var result, offset);
      Position += offset + sizeof(sbyte);
      return result;
    }

    /// <summary> Reads an <see cref="float"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public float ReadSingle(Endian endian = Endian.System, int offset = 0) {
      Memory.Span[Position..].ReadSingle(out var result, offset, endian);
      Position += offset + sizeof(float);
      return result;
    }

    /// <summary>
    /// Reads a <see cref="string"/> value from the given offset and by the given pattern and the
    /// given length.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ReadString(Encoding encoding = null, StringPattern stringPattern = StringPattern.VariableByteCount, int length = 0, int offset = 0) {
      Memory.Span[Position..].ReadString(out var value, out var usedBytes, offset, length, encoding, stringPattern);
      Position += usedBytes;
      return value;
    }

    /// <summary> Reads a <see cref="ushort"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ushort ReadUInt16(Endian endian = Endian.System, int offset = 0) {
      Memory.Span[Position..].ReadUInt16(out var result, offset, endian);
      Position += offset + sizeof(ushort);
      return result;
    }

    /// <summary> Reads a <see cref="uint"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public uint ReadUInt32(Endian endian = Endian.System, int offset = 0) {
      Memory.Span[Position..].ReadUInt32(out var result, offset, endian);
      Position += offset + sizeof(uint);
      return result;
    }

    /// <summary> Reads a <see cref="ulong"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ulong ReadUInt64(Endian endian = Endian.System, int offset = 0) {
      Memory.Span[Position..].ReadUInt64(out var result, offset, endian);
      Position += offset + sizeof(ulong);
      return result;
    }

    /// <summary> Reads a <see cref="ReadOnlyMemory{T}"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ReadOnlyMemory<byte> ReadReadOnlyMemory(int lenght, int offset = 0) {
      var result = Memory.Slice(Position + offset, lenght);
      Position += offset + lenght;
      return result;
    }

    public T ReadObject<T>() => (T)ReadObject(typeof(T));

    public object ReadObject(Type type, BinaryContentAttribute attribute = null) => ReadObject(out var _, type, attribute);

    public object ReadObject(out int usedBytes, Type type, BinaryContentAttribute attribute = null) {
      var result = Memory[Position..].ReadObject(out usedBytes, type, attribute);
      Position += usedBytes;
      return result;
    }

    public object ReadCustomObject(out int usedBytes, Type type, object instance = null) {
      usedBytes = 0;
      var typeData = TypeData.GetTypeData(type);
      instance ??= typeData.GetInstance();
      foreach (var orderedMember in typeData.OrderedNodes) {
        usedBytes += ReadMember(instance, orderedMember.Value);
      }
      foreach (var unorderedMember in typeData.UnorderedNodes) {
        if (IsEndOfSpan) {
          break;
        }
        usedBytes += ReadMember(instance, unorderedMember.Value);
      }
      return instance;
    }

    #endregion Public Methods

    #region Private Methods

    private int ReadMember(object instance, MemberData member) {
      // Read the value and respect settings stored in the member attribute.

      object value = null;
      var usedBytesResult = 0;

      var elementType = member.Type.GetFirstUnderlayingType();
      if (elementType == null) {
        value = ReadObject(out var usedBytes, member.Type, member.Attribute);
        usedBytesResult += usedBytes;
      }


      if (member.Type.IsArray) {
        var values = Array.CreateInstance(elementType, member.Attribute.Length);
        for (var i = 0; i < values.Length; i++) {
          values.SetValue(ReadObject(out var usedBytes, elementType, member.Attribute), i);
          usedBytesResult += usedBytes;
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
            _ = list.Add(ReadObject(out var usedBytes, elementType, member.Attribute));
            usedBytesResult += usedBytes;
          }
          return usedBytesResult;
        }
        else if (member.Type == typeof(ReadOnlyMemory<byte>)) {
          value = ReadObject(out var usedBytes, member.Type, member.Attribute);
          usedBytesResult = usedBytes;
        }
        else {
          throw new NotImplementedException(
          $"Type {member.Type} is not supported by the serializer.");
        }
      }

      // Set the read value.
      member.MemberInfo.SetMemberValue(instance, value);
      return usedBytesResult;
    }

    #endregion Private Methods
  }
}