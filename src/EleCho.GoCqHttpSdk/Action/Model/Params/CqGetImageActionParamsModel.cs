﻿#pragma warning disable IDE1006 // Naming Styles

namespace EleCho.GoCqHttpSdk.Action.Model.Params;

internal class CqGetImageActionParamsModel(string file) : CqActionParamsModel
{
    public string file { get; } = file;
}