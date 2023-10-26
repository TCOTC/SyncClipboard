﻿using Avalonia.Input;
using Avalonia.Threading;
using SyncClipboard.Core.Clipboard;
using SyncClipboard.Core.Models;
using System.Threading;
using System.Threading.Tasks;

namespace SyncClipboard.Desktop.ClipboardAva;

internal abstract class ClipboardSetterBase<ProfileType> : IClipboardSetter<ProfileType> where ProfileType : Profile
{
    public abstract object CreateClipboardObjectContainer(ClipboardMetaInfomation metaInfomation);

    public virtual Task SetLocalClipboard(object obj, CancellationToken ctk)
    {
        return Task.CompletedTask;
    }
}
