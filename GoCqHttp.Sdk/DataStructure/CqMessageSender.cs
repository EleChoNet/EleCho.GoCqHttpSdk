﻿using EleCho.GoCqHttpSdk.Post;
using System;

namespace EleCho.GoCqHttpSdk
{
    public class CqMessageSender
    {
        internal CqMessageSender(CqMessageSenderModel model)
        {
            UserId = model.user_id;
            Nickname = model.nickname;
            Gender = CqEnum.GetGender(model.sex);
            Age = model.age;
        }

        public long UserId { get; set; }
        public string Nickname { get; set; }
        public CqGender Gender { get; set; }
        public int Age { get; set; }
    }
}