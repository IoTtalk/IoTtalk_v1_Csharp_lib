﻿using System;
using System.Collections.Generic;


namespace IoTTalkLib.Model
{
    public class ProfileModel
    {
        public Profile profile { get; set; }
    }
    public class Profile
    {
        public string d_name { get; set; }
        public string dm_name { get; set; }
        public string u_name { get; set; }
        public bool is_sim { get; set; }
        public List<string> df_list { get; set; }
    }

    public class RegisterModel
    {

        public string d_name { get; set; }
        public string password { get; set; }

    }

    public class PushModel
    {
            public List<object> data { get; set; }
    }

    public class PullModel
    {
        public List<List<object>> samples { get; set; }
    }
    public class PullDataProcessModel
    {
        public DateTime? TimeStamp1 { get; set; }
        public string unspliteData1 { get; set; }
        public DateTime? TimeStamp2 { get; set; }
        public string unspliteData2 { get; set; }
    }
}
