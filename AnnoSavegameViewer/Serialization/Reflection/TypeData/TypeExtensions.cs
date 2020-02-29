using System;
using System.Collections;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Serialization.Reflection.TypeData {

  /// <summary>
  /// Represents a collection of extension methods for the <see cref="Type"/> class.
  /// </summary>
  internal static class TypeExtensions {

    #region Internal Methods

    /// <summary>
    /// Returns a value indicating whether the given <paramref name="type"/> is enumerable. Returns
    /// <see langword="false"/> for non-enumerable objects and strings.
    /// </summary>
    /// <param name="type">The type which should be checked.</param>
    /// <returns>
    /// <see langword="true"/> if the type is enumerable and not a string; otherwise <see langword="false"/>.
    /// </returns>
    internal static bool IsEnumerable(this Type type) {
      return type != typeof(String) && (type.IsArray || typeof(IEnumerable).IsAssignableFrom(type));
    }

    /// <summary>
    /// Gets the element type of <see cref="IEnumerable"/> instances. Returns <see langword="null"/>
    /// for non-enumerable objects and strings.
    /// </summary>
    /// <param name="type">The type which element type should be returned.</param>
    /// <returns>The type of the elements, or <see langword="null"/>.</returns>
    internal static Type GetEnumerableElementType(this Type type) {
      // Do not handle strings as enumerables, they are stored differently.
      if (type == typeof(String)) {
        return null;
      }

      // Check for array instances.
      if (type.IsArray) {
        var elementType = type.GetElementType();
        if (type.GetArrayRank() > 1 || elementType.IsArray) {
          throw new NotImplementedException(
              $"Type {type} is a multidimensional array and not supported at the moment.");
        }
        return elementType;
      }

      // Check for IEnumerable instances. Only the first implementation of IEnumerable<> is returned.
      if (typeof(IEnumerable).IsAssignableFrom(type)) {
        foreach (var interfaceType in type.GetInterfaces()) {
          if (interfaceType.IsGenericType
              && interfaceType.GetGenericTypeDefinition() == typeof(IEnumerable<>)) {
            return interfaceType.GetGenericArguments()[0];
          }
        }
      }

      return null;
    }

    internal static Type GetFirstUnderlayingType(this Type type) {
      if (type == typeof(String)) {
        return null;
      }

      // Check for array instances.
      if (type.IsArray) {
        var elementType = type.GetElementType();
        if (type.GetArrayRank() > 1 || elementType.IsArray) {
          throw new NotImplementedException(
              $"Type {type} is a multidimensional array and not supported at the moment.");
        }
        return elementType;
      }

      if (type.IsGenericType) {
        var arguments = type.GetGenericArguments();

        if (arguments.Length > 1) {
          throw new NotImplementedException(
              $"Type {type} is a multidimensional generic and not supported at the moment.");
        }
        else if (arguments.Length == 1) {
          return arguments[0];
        }
      }

      return null;
    }

    internal static bool TryGetEnumerableElementType(this Type type, out Type elementType) {
      // Do not handle strings as enumerables, they are stored differently.
      if (type != typeof(String)) {
        // Check for array instances.
        if (type.IsArray) {
          Type elemType = type.GetElementType();
          if (type.GetArrayRank() > 1 || elemType.IsArray) {
            throw new NotImplementedException(
                $"Type {type} is a multidimensional array and not supported at the moment.");
          }
          elementType = elemType;
          return true;
        }

        // Check for IEnumerable instances. Only the first implementation of IEnumerable<> is returned.
        if (typeof(IEnumerable).IsAssignableFrom(type)) {
          foreach (var interfaceType in type.GetInterfaces()) {
            if (interfaceType.IsGenericType
                && interfaceType.GetGenericTypeDefinition() == typeof(IEnumerable<>)) {
              elementType = interfaceType.GetGenericArguments()[0];
              return true;
            }
          }
        }
      }

      elementType = null;
      return false;
    }

    #endregion Internal Methods
  }
}