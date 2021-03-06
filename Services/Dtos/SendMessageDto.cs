﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Dtos
{
    public class SendMessageDto
    {
        public List<UserInfoDto> UserList { get; set; }

        public string Message { get; set; }

        public string Topic { get; set; }

        public bool IsSend { get; set; }

        public SendMessageDto()
        {
            UserList = new List<UserInfoDto>();
        }
    }
}
