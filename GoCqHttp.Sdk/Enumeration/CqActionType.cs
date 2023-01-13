﻿namespace EleCho.GoCqHttpSdk
{
    public enum CqActionType
    {
        SendPrivateMessage,
        SendGroupMessage,
        SendMessage,
        RecallMessage,
        SendGroupForwardMessage,
        GetMessage,
        GetForwardMessage,
        GetImage,
        BanGroupMember,
        BanGroupAnonymousMember,
        BanAllGroupMembers,
        KickGroupMember,
        HandleFriendRequest,
        HandleGroupRequest,
        MarkMessageAsRead,
        SetGroupAdministrator,
        SetGroupAnonymous,
        SetGroupNickname,
        SetGroupName,
        LeaveGroup,
        SetGroupSpecialTitle,
        GroupSignIn,
        GetLoginInformation,
        GetStrangerInformation,
        SetAccountProfile
    }
}