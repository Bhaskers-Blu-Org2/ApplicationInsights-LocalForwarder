// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: agent/trace/v1/trace_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Opencensus.Proto.Agent.Trace.V1 {

  /// <summary>Holder for reflection information generated from agent/trace/v1/trace_service.proto</summary>
  public static partial class TraceServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for agent/trace/v1/trace_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TraceServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJhZ2VudC90cmFjZS92MS90cmFjZV9zZXJ2aWNlLnByb3RvEh9vcGVuY2Vu",
            "c3VzLnByb3RvLmFnZW50LnRyYWNlLnYxGi1vcGVuY2Vuc3VzL3Byb3RvL2Fn",
            "ZW50L2NvbW1vbi92MS9jb21tb24ucHJvdG8aJW9wZW5jZW5zdXMvcHJvdG8v",
            "dHJhY2UvdjEvdHJhY2UucHJvdG8aLG9wZW5jZW5zdXMvcHJvdG8vdHJhY2Uv",
            "djEvdHJhY2VfY29uZmlnLnByb3RvIoQBChRDdXJyZW50TGlicmFyeUNvbmZp",
            "ZxI0CgRub2RlGAEgASgLMiYub3BlbmNlbnN1cy5wcm90by5hZ2VudC5jb21t",
            "b24udjEuTm9kZRI2CgZjb25maWcYAiABKAsyJi5vcGVuY2Vuc3VzLnByb3Rv",
            "LnRyYWNlLnYxLlRyYWNlQ29uZmlnIoQBChRVcGRhdGVkTGlicmFyeUNvbmZp",
            "ZxI0CgRub2RlGAEgASgLMiYub3BlbmNlbnN1cy5wcm90by5hZ2VudC5jb21t",
            "b24udjEuTm9kZRI2CgZjb25maWcYAiABKAsyJi5vcGVuY2Vuc3VzLnByb3Rv",
            "LnRyYWNlLnYxLlRyYWNlQ29uZmlnIoEBChlFeHBvcnRUcmFjZVNlcnZpY2VS",
            "ZXF1ZXN0EjQKBG5vZGUYASABKAsyJi5vcGVuY2Vuc3VzLnByb3RvLmFnZW50",
            "LmNvbW1vbi52MS5Ob2RlEi4KBXNwYW5zGAIgAygLMh8ub3BlbmNlbnN1cy5w",
            "cm90by50cmFjZS52MS5TcGFuIhwKGkV4cG9ydFRyYWNlU2VydmljZVJlc3Bv",
            "bnNlMpYCCgxUcmFjZVNlcnZpY2USfAoGQ29uZmlnEjUub3BlbmNlbnN1cy5w",
            "cm90by5hZ2VudC50cmFjZS52MS5DdXJyZW50TGlicmFyeUNvbmZpZxo1Lm9w",
            "ZW5jZW5zdXMucHJvdG8uYWdlbnQudHJhY2UudjEuVXBkYXRlZExpYnJhcnlD",
            "b25maWciACgBMAEShwEKBkV4cG9ydBI6Lm9wZW5jZW5zdXMucHJvdG8uYWdl",
            "bnQudHJhY2UudjEuRXhwb3J0VHJhY2VTZXJ2aWNlUmVxdWVzdBo7Lm9wZW5j",
            "ZW5zdXMucHJvdG8uYWdlbnQudHJhY2UudjEuRXhwb3J0VHJhY2VTZXJ2aWNl",
            "UmVzcG9uc2UiACgBMAFCgwEKImlvLm9wZW5jZW5zdXMucHJvdG8uYWdlbnQu",
            "dHJhY2UudjFCEVRyYWNlU2VydmljZVByb3RvUAFaSGdpdGh1Yi5jb20vY2Vu",
            "c3VzLWluc3RydW1lbnRhdGlvbi9vcGVuY2Vuc3VzLXByb3RvL2dlbi1nby9h",
            "Z2VudC90cmFjZS92MWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Opencensus.Proto.Agent.Common.V1.CommonReflection.Descriptor, global::Opencensus.Proto.Trace.V1.TraceReflection.Descriptor, global::Opencensus.Proto.Trace.V1.TraceConfigReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Opencensus.Proto.Agent.Trace.V1.CurrentLibraryConfig), global::Opencensus.Proto.Agent.Trace.V1.CurrentLibraryConfig.Parser, new[]{ "Node", "Config" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Opencensus.Proto.Agent.Trace.V1.UpdatedLibraryConfig), global::Opencensus.Proto.Agent.Trace.V1.UpdatedLibraryConfig.Parser, new[]{ "Node", "Config" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Opencensus.Proto.Agent.Trace.V1.ExportTraceServiceRequest), global::Opencensus.Proto.Agent.Trace.V1.ExportTraceServiceRequest.Parser, new[]{ "Node", "Spans" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Opencensus.Proto.Agent.Trace.V1.ExportTraceServiceResponse), global::Opencensus.Proto.Agent.Trace.V1.ExportTraceServiceResponse.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CurrentLibraryConfig : pb::IMessage<CurrentLibraryConfig> {
    private static readonly pb::MessageParser<CurrentLibraryConfig> _parser = new pb::MessageParser<CurrentLibraryConfig>(() => new CurrentLibraryConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CurrentLibraryConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Opencensus.Proto.Agent.Trace.V1.TraceServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CurrentLibraryConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CurrentLibraryConfig(CurrentLibraryConfig other) : this() {
      node_ = other.node_ != null ? other.node_.Clone() : null;
      config_ = other.config_ != null ? other.config_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CurrentLibraryConfig Clone() {
      return new CurrentLibraryConfig(this);
    }

    /// <summary>Field number for the "node" field.</summary>
    public const int NodeFieldNumber = 1;
    private global::Opencensus.Proto.Agent.Common.V1.Node node_;
    /// <summary>
    /// This is required only in the first message on the stream or if the
    /// previous sent CurrentLibraryConfig message has a different Node (e.g.
    /// when the same RPC is used to configure multiple Applications).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Agent.Common.V1.Node Node {
      get { return node_; }
      set {
        node_ = value;
      }
    }

    /// <summary>Field number for the "config" field.</summary>
    public const int ConfigFieldNumber = 2;
    private global::Opencensus.Proto.Trace.V1.TraceConfig config_;
    /// <summary>
    /// Current configuration.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Trace.V1.TraceConfig Config {
      get { return config_; }
      set {
        config_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CurrentLibraryConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CurrentLibraryConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Node, other.Node)) return false;
      if (!object.Equals(Config, other.Config)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (node_ != null) hash ^= Node.GetHashCode();
      if (config_ != null) hash ^= Config.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (node_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Node);
      }
      if (config_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Config);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (node_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Node);
      }
      if (config_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Config);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CurrentLibraryConfig other) {
      if (other == null) {
        return;
      }
      if (other.node_ != null) {
        if (node_ == null) {
          node_ = new global::Opencensus.Proto.Agent.Common.V1.Node();
        }
        Node.MergeFrom(other.Node);
      }
      if (other.config_ != null) {
        if (config_ == null) {
          config_ = new global::Opencensus.Proto.Trace.V1.TraceConfig();
        }
        Config.MergeFrom(other.Config);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (node_ == null) {
              node_ = new global::Opencensus.Proto.Agent.Common.V1.Node();
            }
            input.ReadMessage(node_);
            break;
          }
          case 18: {
            if (config_ == null) {
              config_ = new global::Opencensus.Proto.Trace.V1.TraceConfig();
            }
            input.ReadMessage(config_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class UpdatedLibraryConfig : pb::IMessage<UpdatedLibraryConfig> {
    private static readonly pb::MessageParser<UpdatedLibraryConfig> _parser = new pb::MessageParser<UpdatedLibraryConfig>(() => new UpdatedLibraryConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UpdatedLibraryConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Opencensus.Proto.Agent.Trace.V1.TraceServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdatedLibraryConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdatedLibraryConfig(UpdatedLibraryConfig other) : this() {
      node_ = other.node_ != null ? other.node_.Clone() : null;
      config_ = other.config_ != null ? other.config_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdatedLibraryConfig Clone() {
      return new UpdatedLibraryConfig(this);
    }

    /// <summary>Field number for the "node" field.</summary>
    public const int NodeFieldNumber = 1;
    private global::Opencensus.Proto.Agent.Common.V1.Node node_;
    /// <summary>
    /// This field is ignored when the RPC is used to configure only one Application.
    /// This is required only in the first message on the stream or if the
    /// previous sent UpdatedLibraryConfig message has a different Node.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Agent.Common.V1.Node Node {
      get { return node_; }
      set {
        node_ = value;
      }
    }

    /// <summary>Field number for the "config" field.</summary>
    public const int ConfigFieldNumber = 2;
    private global::Opencensus.Proto.Trace.V1.TraceConfig config_;
    /// <summary>
    /// Requested updated configuration.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Trace.V1.TraceConfig Config {
      get { return config_; }
      set {
        config_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UpdatedLibraryConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UpdatedLibraryConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Node, other.Node)) return false;
      if (!object.Equals(Config, other.Config)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (node_ != null) hash ^= Node.GetHashCode();
      if (config_ != null) hash ^= Config.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (node_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Node);
      }
      if (config_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Config);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (node_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Node);
      }
      if (config_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Config);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UpdatedLibraryConfig other) {
      if (other == null) {
        return;
      }
      if (other.node_ != null) {
        if (node_ == null) {
          node_ = new global::Opencensus.Proto.Agent.Common.V1.Node();
        }
        Node.MergeFrom(other.Node);
      }
      if (other.config_ != null) {
        if (config_ == null) {
          config_ = new global::Opencensus.Proto.Trace.V1.TraceConfig();
        }
        Config.MergeFrom(other.Config);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (node_ == null) {
              node_ = new global::Opencensus.Proto.Agent.Common.V1.Node();
            }
            input.ReadMessage(node_);
            break;
          }
          case 18: {
            if (config_ == null) {
              config_ = new global::Opencensus.Proto.Trace.V1.TraceConfig();
            }
            input.ReadMessage(config_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ExportTraceServiceRequest : pb::IMessage<ExportTraceServiceRequest> {
    private static readonly pb::MessageParser<ExportTraceServiceRequest> _parser = new pb::MessageParser<ExportTraceServiceRequest>(() => new ExportTraceServiceRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExportTraceServiceRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Opencensus.Proto.Agent.Trace.V1.TraceServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportTraceServiceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportTraceServiceRequest(ExportTraceServiceRequest other) : this() {
      node_ = other.node_ != null ? other.node_.Clone() : null;
      spans_ = other.spans_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportTraceServiceRequest Clone() {
      return new ExportTraceServiceRequest(this);
    }

    /// <summary>Field number for the "node" field.</summary>
    public const int NodeFieldNumber = 1;
    private global::Opencensus.Proto.Agent.Common.V1.Node node_;
    /// <summary>
    /// This is required only in the first message on the stream or if the
    /// previous sent ExportTraceServiceRequest message has a different Node (e.g.
    /// when the same RPC is used to send Spans from multiple Applications).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Agent.Common.V1.Node Node {
      get { return node_; }
      set {
        node_ = value;
      }
    }

    /// <summary>Field number for the "spans" field.</summary>
    public const int SpansFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Opencensus.Proto.Trace.V1.Span> _repeated_spans_codec
        = pb::FieldCodec.ForMessage(18, global::Opencensus.Proto.Trace.V1.Span.Parser);
    private readonly pbc::RepeatedField<global::Opencensus.Proto.Trace.V1.Span> spans_ = new pbc::RepeatedField<global::Opencensus.Proto.Trace.V1.Span>();
    /// <summary>
    /// A list of Spans that belong to the last received Node.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Opencensus.Proto.Trace.V1.Span> Spans {
      get { return spans_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExportTraceServiceRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExportTraceServiceRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Node, other.Node)) return false;
      if(!spans_.Equals(other.spans_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (node_ != null) hash ^= Node.GetHashCode();
      hash ^= spans_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (node_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Node);
      }
      spans_.WriteTo(output, _repeated_spans_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (node_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Node);
      }
      size += spans_.CalculateSize(_repeated_spans_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExportTraceServiceRequest other) {
      if (other == null) {
        return;
      }
      if (other.node_ != null) {
        if (node_ == null) {
          node_ = new global::Opencensus.Proto.Agent.Common.V1.Node();
        }
        Node.MergeFrom(other.Node);
      }
      spans_.Add(other.spans_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (node_ == null) {
              node_ = new global::Opencensus.Proto.Agent.Common.V1.Node();
            }
            input.ReadMessage(node_);
            break;
          }
          case 18: {
            spans_.AddEntriesFrom(input, _repeated_spans_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ExportTraceServiceResponse : pb::IMessage<ExportTraceServiceResponse> {
    private static readonly pb::MessageParser<ExportTraceServiceResponse> _parser = new pb::MessageParser<ExportTraceServiceResponse>(() => new ExportTraceServiceResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExportTraceServiceResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Opencensus.Proto.Agent.Trace.V1.TraceServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportTraceServiceResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportTraceServiceResponse(ExportTraceServiceResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportTraceServiceResponse Clone() {
      return new ExportTraceServiceResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExportTraceServiceResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExportTraceServiceResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExportTraceServiceResponse other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code