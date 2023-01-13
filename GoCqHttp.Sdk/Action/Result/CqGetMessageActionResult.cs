﻿using EleCho.GoCqHttpSdk.Action.Model.Data;
using EleCho.GoCqHttpSdk;
using EleCho.GoCqHttpSdk.Message;
using EleCho.GoCqHttpSdk.Message.DataModel;
using EleCho.GoCqHttpSdk.Utils;
using System;

namespace EleCho.GoCqHttpSdk.Action
{
    public class CqGetMessageActionResult : CqActionResult
    {
        public bool IsGroupMsg { get; set; }
        
        public long MessageId { get; set; }
        public int RealId { get; set; }
        public CqMessageSender Sender { get; set; } = null!;
        public DateTime Time { get; set; }
        public CqMsg[] Message { get; set; } = null!;
        public string RawMessage { get; set; } = null!;

        internal CqGetMessageActionResult() { }

        internal override void ReadDataModel(CqActionResultDataModel? model)
        {
            if(model is CqGetMessageActionResultDataModel dataModel)
            {
                IsGroupMsg = dataModel.group;
                MessageId = dataModel.message_id;
                RealId = dataModel.real_id;
                Sender = new CqMessageSender(dataModel.sender);
                Time = UnixTime.DateFromUnix(dataModel.time);
                Message = Array.ConvertAll(dataModel.message ?? Array.Empty<CqMsgModel>(), CqMsg.FromModel);
                RawMessage = dataModel.raw_message;
            }
        }
    }
}