﻿#pragma warning disable CS8618

using EleCho.GoCqHttpSdk.Message.CqCodeDef;

namespace EleCho.GoCqHttpSdk.Message.DataModel
{
    internal class CqDiceMsgDataModel : CqMsgDataModel
    {
        public static CqDiceMsgDataModel FromCqCode(CqCode code)
        {
            return new CqDiceMsgDataModel();
        }
    }
}