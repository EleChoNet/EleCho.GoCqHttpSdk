﻿#pragma warning disable IDE1006 // Naming Styles


namespace EleCho.GoCqHttpSdk.Action.Model.Params;

internal class CqGetGroupFileSystemInformationActionParamsModel(long group_id) : CqActionParamsModel
{
    public long group_id { get; } = group_id;
}