﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stream.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stream
    {
        public int streamID { get; set; }
        public string streamName { get; set; }
        public string streamDescription { get; set; }
        public string streamURL { get; set; }
        public Nullable<bool> streamEnabled { get; set; }
        public string streamImagethumbnail { get; set; }
        public string streamImage { get; set; }
        public Nullable<int> streamTypeID { get; set; }
    }
}