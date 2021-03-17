// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: monitor_log.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.common.monitor
{

    [global::ProtoBuf.ProtoContract()]
    public partial class MonitorMessageItem : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public MonitorMessageItem()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(MessageSource.Unknown)]
        public MessageSource source
        {
            get { return __pbn__source ?? MessageSource.Unknown; }
            set { __pbn__source = value; }
        }
        public bool ShouldSerializesource()
        {
            return __pbn__source != null;
        }
        public void Resetsource()
        {
            __pbn__source = null;
        }
        private MessageSource? __pbn__source;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string msg
        {
            get { return __pbn__msg ?? ""; }
            set { __pbn__msg = value; }
        }
        public bool ShouldSerializemsg()
        {
            return __pbn__msg != null;
        }
        public void Resetmsg()
        {
            __pbn__msg = null;
        }
        private string __pbn__msg;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(LogLevel.Info)]
        public LogLevel log_level
        {
            get { return __pbn__log_level ?? LogLevel.Info; }
            set { __pbn__log_level = value; }
        }
        public bool ShouldSerializelog_level()
        {
            return __pbn__log_level != null;
        }
        public void Resetlog_level()
        {
            __pbn__log_level = null;
        }
        private LogLevel? __pbn__log_level;

        [global::ProtoBuf.ProtoContract()]
        public enum MessageSource
        {
            [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
            Unknown = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"CANBUS")]
            Canbus = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"CONTROL")]
            Control = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"DECISION")]
            Decision = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"LOCALIZATION")]
            Localization = 5,
            [global::ProtoBuf.ProtoEnum(Name = @"PLANNING")]
            Planning = 6,
            [global::ProtoBuf.ProtoEnum(Name = @"PREDICTION")]
            Prediction = 7,
            [global::ProtoBuf.ProtoEnum(Name = @"SIMULATOR")]
            Simulator = 8,
            [global::ProtoBuf.ProtoEnum(Name = @"HWSYS")]
            Hwsys = 9,
            [global::ProtoBuf.ProtoEnum(Name = @"ROUTING")]
            Routing = 10,
            [global::ProtoBuf.ProtoEnum(Name = @"MONITOR")]
            Monitor = 11,
            [global::ProtoBuf.ProtoEnum(Name = @"HMI")]
            Hmi = 12,
            [global::ProtoBuf.ProtoEnum(Name = @"RELATIVE_MAP")]
            RelativeMap = 13,
            [global::ProtoBuf.ProtoEnum(Name = @"GNSS")]
            Gnss = 14,
            [global::ProtoBuf.ProtoEnum(Name = @"CONTI_RADAR")]
            ContiRadar = 15,
            [global::ProtoBuf.ProtoEnum(Name = @"RACOBIT_RADAR")]
            RacobitRadar = 16,
            [global::ProtoBuf.ProtoEnum(Name = @"ULTRASONIC_RADAR")]
            UltrasonicRadar = 17,
            [global::ProtoBuf.ProtoEnum(Name = @"MOBILEYE")]
            Mobileye = 18,
            [global::ProtoBuf.ProtoEnum(Name = @"DELPHI_ESR")]
            DelphiEsr = 19,
        }

        [global::ProtoBuf.ProtoContract()]
        public enum LogLevel
        {
            [global::ProtoBuf.ProtoEnum(Name = @"INFO")]
            Info = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"WARN")]
            Warn = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"ERROR")]
            Error = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"FATAL")]
            Fatal = 3,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MonitorMessage : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public MonitorMessage()
        {
            item = new global::System.Collections.Generic.List<MonitorMessageItem>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::apollo.common.Header header { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<MonitorMessageItem> item { get; private set; }

    }

}

#pragma warning restore 0612, 1591, 3021