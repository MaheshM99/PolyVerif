// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: fnn_model.proto

#pragma warning disable 0612, 1591, 3021
[global::ProtoBuf.ProtoContract()]
public partial class Vector : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }
    public Vector()
    {
        OnConstructor();
    }

    partial void OnConstructor();

    [global::ProtoBuf.ProtoMember(1)]
    public double[] columns { get; set; }

}

[global::ProtoBuf.ProtoContract()]
public partial class Matrix : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }
    public Matrix()
    {
        rows = new global::System.Collections.Generic.List<Vector>();
        OnConstructor();
    }

    partial void OnConstructor();

    [global::ProtoBuf.ProtoMember(1)]
    public global::System.Collections.Generic.List<Vector> rows { get; private set; }

}

[global::ProtoBuf.ProtoContract()]
public partial class Layer : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }
    public Layer()
    {
        OnConstructor();
    }

    partial void OnConstructor();

    [global::ProtoBuf.ProtoMember(1)]
    public int layer_input_dim
    {
        get { return __pbn__layer_input_dim.GetValueOrDefault(); }
        set { __pbn__layer_input_dim = value; }
    }
    public bool ShouldSerializelayer_input_dim()
    {
        return __pbn__layer_input_dim != null;
    }
    public void Resetlayer_input_dim()
    {
        __pbn__layer_input_dim = null;
    }
    private int? __pbn__layer_input_dim;

    [global::ProtoBuf.ProtoMember(2)]
    public int layer_output_dim
    {
        get { return __pbn__layer_output_dim.GetValueOrDefault(); }
        set { __pbn__layer_output_dim = value; }
    }
    public bool ShouldSerializelayer_output_dim()
    {
        return __pbn__layer_output_dim != null;
    }
    public void Resetlayer_output_dim()
    {
        __pbn__layer_output_dim = null;
    }
    private int? __pbn__layer_output_dim;

    [global::ProtoBuf.ProtoMember(3)]
    public Matrix layer_input_weight { get; set; }

    [global::ProtoBuf.ProtoMember(4)]
    public Vector layer_bias { get; set; }

    [global::ProtoBuf.ProtoMember(5)]
    [global::System.ComponentModel.DefaultValue(ActivationFunc.Relu)]
    public ActivationFunc layer_activation_func
    {
        get { return __pbn__layer_activation_func ?? ActivationFunc.Relu; }
        set { __pbn__layer_activation_func = value; }
    }
    public bool ShouldSerializelayer_activation_func()
    {
        return __pbn__layer_activation_func != null;
    }
    public void Resetlayer_activation_func()
    {
        __pbn__layer_activation_func = null;
    }
    private ActivationFunc? __pbn__layer_activation_func;

    [global::ProtoBuf.ProtoContract()]
    public enum ActivationFunc
    {
        [global::ProtoBuf.ProtoEnum(Name = @"RELU")]
        Relu = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"TANH")]
        Tanh = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"SIGMOID")]
        Sigmoid = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"SOFTMAX")]
        Softmax = 3,
    }

}

[global::ProtoBuf.ProtoContract()]
public partial class FnnModel : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }
    public FnnModel()
    {
        layer = new global::System.Collections.Generic.List<Layer>();
        OnConstructor();
    }

    partial void OnConstructor();

    [global::ProtoBuf.ProtoMember(1)]
    public int dim_input
    {
        get { return __pbn__dim_input.GetValueOrDefault(); }
        set { __pbn__dim_input = value; }
    }
    public bool ShouldSerializedim_input()
    {
        return __pbn__dim_input != null;
    }
    public void Resetdim_input()
    {
        __pbn__dim_input = null;
    }
    private int? __pbn__dim_input;

    [global::ProtoBuf.ProtoMember(2)]
    public Vector samples_mean { get; set; }

    [global::ProtoBuf.ProtoMember(3)]
    public Vector samples_std { get; set; }

    [global::ProtoBuf.ProtoMember(4)]
    public int num_layer
    {
        get { return __pbn__num_layer.GetValueOrDefault(); }
        set { __pbn__num_layer = value; }
    }
    public bool ShouldSerializenum_layer()
    {
        return __pbn__num_layer != null;
    }
    public void Resetnum_layer()
    {
        __pbn__num_layer = null;
    }
    private int? __pbn__num_layer;

    [global::ProtoBuf.ProtoMember(5)]
    public global::System.Collections.Generic.List<Layer> layer { get; private set; }

    [global::ProtoBuf.ProtoMember(6)]
    public int dim_output
    {
        get { return __pbn__dim_output.GetValueOrDefault(); }
        set { __pbn__dim_output = value; }
    }
    public bool ShouldSerializedim_output()
    {
        return __pbn__dim_output != null;
    }
    public void Resetdim_output()
    {
        __pbn__dim_output = null;
    }
    private int? __pbn__dim_output;

}

#pragma warning restore 0612, 1591, 3021