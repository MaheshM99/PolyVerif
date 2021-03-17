// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: tracking_feature.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.camera.tracking_feature
{

    [global::ProtoBuf.ProtoContract()]
    public partial class FeatureParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public FeatureParam()
        {
            extractor = new global::System.Collections.Generic.List<ExtractorParam>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(32)]
        public int feat_stride
        {
            get { return __pbn__feat_stride ?? 32; }
            set { __pbn__feat_stride = value; }
        }
        public bool ShouldSerializefeat_stride()
        {
            return __pbn__feat_stride != null;
        }
        public void Resetfeat_stride()
        {
            __pbn__feat_stride = null;
        }
        private int? __pbn__feat_stride;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<ExtractorParam> extractor { get; private set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string remap_model
        {
            get { return __pbn__remap_model ?? ""; }
            set { __pbn__remap_model = value; }
        }
        public bool ShouldSerializeremap_model()
        {
            return __pbn__remap_model != null;
        }
        public void Resetremap_model()
        {
            __pbn__remap_model = null;
        }
        private string __pbn__remap_model;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ExtractorParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ExtractorParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string feat_blob
        {
            get { return __pbn__feat_blob ?? ""; }
            set { __pbn__feat_blob = value; }
        }
        public bool ShouldSerializefeat_blob()
        {
            return __pbn__feat_blob != null;
        }
        public void Resetfeat_blob()
        {
            __pbn__feat_blob = null;
        }
        private string __pbn__feat_blob;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(FeatureType.ROIPooling)]
        public FeatureType feat_type
        {
            get { return __pbn__feat_type ?? FeatureType.ROIPooling; }
            set { __pbn__feat_type = value; }
        }
        public bool ShouldSerializefeat_type()
        {
            return __pbn__feat_type != null;
        }
        public void Resetfeat_type()
        {
            __pbn__feat_type = null;
        }
        private FeatureType? __pbn__feat_type;

        [global::ProtoBuf.ProtoMember(3)]
        public ROIPoolingParam roi_pooling_param { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public PSROIPoolingParam ps_roi_pooling_param { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public enum FeatureType
        {
            ROIPooling = 0,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ROIPoolingParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ROIPoolingParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(3)]
        public int pooled_h
        {
            get { return __pbn__pooled_h ?? 3; }
            set { __pbn__pooled_h = value; }
        }
        public bool ShouldSerializepooled_h()
        {
            return __pbn__pooled_h != null;
        }
        public void Resetpooled_h()
        {
            __pbn__pooled_h = null;
        }
        private int? __pbn__pooled_h;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(3)]
        public int pooled_w
        {
            get { return __pbn__pooled_w ?? 3; }
            set { __pbn__pooled_w = value; }
        }
        public bool ShouldSerializepooled_w()
        {
            return __pbn__pooled_w != null;
        }
        public void Resetpooled_w()
        {
            __pbn__pooled_w = null;
        }
        private int? __pbn__pooled_w;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool use_floor
        {
            get { return __pbn__use_floor ?? false; }
            set { __pbn__use_floor = value; }
        }
        public bool ShouldSerializeuse_floor()
        {
            return __pbn__use_floor != null;
        }
        public void Resetuse_floor()
        {
            __pbn__use_floor = null;
        }
        private bool? __pbn__use_floor;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PSROIPoolingParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PSROIPoolingParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(16)]
        public int heat_map_a
        {
            get { return __pbn__heat_map_a ?? 16; }
            set { __pbn__heat_map_a = value; }
        }
        public bool ShouldSerializeheat_map_a()
        {
            return __pbn__heat_map_a != null;
        }
        public void Resetheat_map_a()
        {
            __pbn__heat_map_a = null;
        }
        private int? __pbn__heat_map_a;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(10)]
        public int output_dim
        {
            get { return __pbn__output_dim ?? 10; }
            set { __pbn__output_dim = value; }
        }
        public bool ShouldSerializeoutput_dim()
        {
            return __pbn__output_dim != null;
        }
        public void Resetoutput_dim()
        {
            __pbn__output_dim = null;
        }
        private int? __pbn__output_dim;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(7)]
        public int group_height
        {
            get { return __pbn__group_height ?? 7; }
            set { __pbn__group_height = value; }
        }
        public bool ShouldSerializegroup_height()
        {
            return __pbn__group_height != null;
        }
        public void Resetgroup_height()
        {
            __pbn__group_height = null;
        }
        private int? __pbn__group_height;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(7)]
        public int group_width
        {
            get { return __pbn__group_width ?? 7; }
            set { __pbn__group_width = value; }
        }
        public bool ShouldSerializegroup_width()
        {
            return __pbn__group_width != null;
        }
        public void Resetgroup_width()
        {
            __pbn__group_width = null;
        }
        private int? __pbn__group_width;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(7)]
        public int pooled_height
        {
            get { return __pbn__pooled_height ?? 7; }
            set { __pbn__pooled_height = value; }
        }
        public bool ShouldSerializepooled_height()
        {
            return __pbn__pooled_height != null;
        }
        public void Resetpooled_height()
        {
            __pbn__pooled_height = null;
        }
        private int? __pbn__pooled_height;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(7)]
        public int pooled_width
        {
            get { return __pbn__pooled_width ?? 7; }
            set { __pbn__pooled_width = value; }
        }
        public bool ShouldSerializepooled_width()
        {
            return __pbn__pooled_width != null;
        }
        public void Resetpooled_width()
        {
            __pbn__pooled_width = null;
        }
        private int? __pbn__pooled_width;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(4)]
        public int sample_per_part
        {
            get { return __pbn__sample_per_part ?? 4; }
            set { __pbn__sample_per_part = value; }
        }
        public bool ShouldSerializesample_per_part()
        {
            return __pbn__sample_per_part != null;
        }
        public void Resetsample_per_part()
        {
            __pbn__sample_per_part = null;
        }
        private int? __pbn__sample_per_part;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ExternalParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ExternalParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(@"CaffeNet")]
        public string model_type
        {
            get { return __pbn__model_type ?? @"CaffeNet"; }
            set { __pbn__model_type = value; }
        }
        public bool ShouldSerializemodel_type()
        {
            return __pbn__model_type != null;
        }
        public void Resetmodel_type()
        {
            __pbn__model_type = null;
        }
        private string __pbn__model_type;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(@"caffe.pt")]
        public string proto_file
        {
            get { return __pbn__proto_file ?? @"caffe.pt"; }
            set { __pbn__proto_file = value; }
        }
        public bool ShouldSerializeproto_file()
        {
            return __pbn__proto_file != null;
        }
        public void Resetproto_file()
        {
            __pbn__proto_file = null;
        }
        private string __pbn__proto_file;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(@"caffe.model")]
        public string weight_file
        {
            get { return __pbn__weight_file ?? @"caffe.model"; }
            set { __pbn__weight_file = value; }
        }
        public bool ShouldSerializeweight_file()
        {
            return __pbn__weight_file != null;
        }
        public void Resetweight_file()
        {
            __pbn__weight_file = null;
        }
        private string __pbn__weight_file;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(1080)]
        public int resize_height
        {
            get { return __pbn__resize_height ?? 1080; }
            set { __pbn__resize_height = value; }
        }
        public bool ShouldSerializeresize_height()
        {
            return __pbn__resize_height != null;
        }
        public void Resetresize_height()
        {
            __pbn__resize_height = null;
        }
        private int? __pbn__resize_height;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(1920)]
        public int resize_width
        {
            get { return __pbn__resize_width ?? 1920; }
            set { __pbn__resize_width = value; }
        }
        public bool ShouldSerializeresize_width()
        {
            return __pbn__resize_width != null;
        }
        public void Resetresize_width()
        {
            __pbn__resize_width = null;
        }
        private int? __pbn__resize_width;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string input_blob
        {
            get { return __pbn__input_blob ?? ""; }
            set { __pbn__input_blob = value; }
        }
        public bool ShouldSerializeinput_blob()
        {
            return __pbn__input_blob != null;
        }
        public void Resetinput_blob()
        {
            __pbn__input_blob = null;
        }
        private string __pbn__input_blob;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string feat_blob
        {
            get { return __pbn__feat_blob ?? ""; }
            set { __pbn__feat_blob = value; }
        }
        public bool ShouldSerializefeat_blob()
        {
            return __pbn__feat_blob != null;
        }
        public void Resetfeat_blob()
        {
            __pbn__feat_blob = null;
        }
        private string __pbn__feat_blob;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(0.288889f)]
        public float offset_ratio
        {
            get { return __pbn__offset_ratio ?? 0.288889f; }
            set { __pbn__offset_ratio = value; }
        }
        public bool ShouldSerializeoffset_ratio()
        {
            return __pbn__offset_ratio != null;
        }
        public void Resetoffset_ratio()
        {
            __pbn__offset_ratio = null;
        }
        private float? __pbn__offset_ratio;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(@"feature.pt")]
        public string feature_file
        {
            get { return __pbn__feature_file ?? @"feature.pt"; }
            set { __pbn__feature_file = value; }
        }
        public bool ShouldSerializefeature_file()
        {
            return __pbn__feature_file != null;
        }
        public void Resetfeature_file()
        {
            __pbn__feature_file = null;
        }
        private string __pbn__feature_file;

    }

}

#pragma warning restore 0612, 1591, 3021