﻿namespace EleCho.GoCqHttpSdk.Action.Model.Params;

internal class CqGetOnlineClientsActionParamsModel(bool no_cache) : CqActionParamsModel
{
    public bool no_cache { get; } = no_cache;
}
