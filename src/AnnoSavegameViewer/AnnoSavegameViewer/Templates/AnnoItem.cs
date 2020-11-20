// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Templates {

  using System;
  using System.Diagnostics;
  using System.Diagnostics.CodeAnalysis;
  using AnnoSerializer.Structures.DataTypes;
  using AnnoSerializer.Structures.Generated.a7s;

  [DebuggerDisplay("{Amount}x {GUID}")]
  public sealed class AnnoItem  {

    #region Public Properties

    public DescriptionInt GUID { get; set; }
    public int Amount { get; set; }
    public bool InUse { get; set; }
    public AnnoParticipant Participant { get; set; }
    public GameObjectObjectsValue ParentObject { get; set; }
    public AreaManagersValue AreaManager { get; set; }
    public AreaInfoValue AreaInfo { get; set; }
    public GameSessionsValue Session { get; set; }

    #endregion Public Properties
  }
}