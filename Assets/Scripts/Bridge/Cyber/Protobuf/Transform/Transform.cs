// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/transform/proto/transform.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Transform {

  /// <summary>Holder for reflection information generated from modules/transform/proto/transform.proto</summary>
  public static partial class TransformReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/transform/proto/transform.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TransformReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidtb2R1bGVzL3RyYW5zZm9ybS9wcm90by90cmFuc2Zvcm0ucHJvdG8SEGFw",
            "b2xsby50cmFuc2Zvcm0aIW1vZHVsZXMvY29tbW9uL3Byb3RvL2hlYWRlci5w",
            "cm90bxojbW9kdWxlcy9jb21tb24vcHJvdG8vZ2VvbWV0cnkucHJvdG8iZQoJ",
            "VHJhbnNmb3JtEisKC3RyYW5zbGF0aW9uGAEgASgLMhYuYXBvbGxvLmNvbW1v",
            "bi5Qb2ludDNEEisKCHJvdGF0aW9uGAIgASgLMhkuYXBvbGxvLmNvbW1vbi5R",
            "dWF0ZXJuaW9uIoEBChBUcmFuc2Zvcm1TdGFtcGVkEiUKBmhlYWRlchgBIAEo",
            "CzIVLmFwb2xsby5jb21tb24uSGVhZGVyEhYKDmNoaWxkX2ZyYW1lX2lkGAIg",
            "ASgJEi4KCXRyYW5zZm9ybRgDIAEoCzIbLmFwb2xsby50cmFuc2Zvcm0uVHJh",
            "bnNmb3JtInIKEVRyYW5zZm9ybVN0YW1wZWRzEiUKBmhlYWRlchgBIAEoCzIV",
            "LmFwb2xsby5jb21tb24uSGVhZGVyEjYKCnRyYW5zZm9ybXMYAiADKAsyIi5h",
            "cG9sbG8udHJhbnNmb3JtLlRyYW5zZm9ybVN0YW1wZWRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Common.HeaderReflection.Descriptor, global::Apollo.Common.GeometryReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Transform.Transform), global::Apollo.Transform.Transform.Parser, new[]{ "Translation", "Rotation" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Transform.TransformStamped), global::Apollo.Transform.TransformStamped.Parser, new[]{ "Header", "ChildFrameId", "Transform" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Transform.TransformStampeds), global::Apollo.Transform.TransformStampeds.Parser, new[]{ "Header", "Transforms" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Transform : pb::IMessage<Transform> {
    private static readonly pb::MessageParser<Transform> _parser = new pb::MessageParser<Transform>(() => new Transform());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Transform> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Transform.TransformReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Transform() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Transform(Transform other) : this() {
      Translation = other.translation_ != null ? other.Translation.Clone() : null;
      Rotation = other.rotation_ != null ? other.Rotation.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Transform Clone() {
      return new Transform(this);
    }

    /// <summary>Field number for the "translation" field.</summary>
    public const int TranslationFieldNumber = 1;
    private global::Apollo.Common.Point3D translation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Point3D Translation {
      get { return translation_; }
      set {
        translation_ = value;
      }
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 2;
    private global::Apollo.Common.Quaternion rotation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Quaternion Rotation {
      get { return rotation_; }
      set {
        rotation_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Transform);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Transform other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Translation, other.Translation)) return false;
      if (!object.Equals(Rotation, other.Rotation)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (translation_ != null) hash ^= Translation.GetHashCode();
      if (rotation_ != null) hash ^= Rotation.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (translation_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Translation);
      }
      if (rotation_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Rotation);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (translation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Translation);
      }
      if (rotation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rotation);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Transform other) {
      if (other == null) {
        return;
      }
      if (other.translation_ != null) {
        if (translation_ == null) {
          translation_ = new global::Apollo.Common.Point3D();
        }
        Translation.MergeFrom(other.Translation);
      }
      if (other.rotation_ != null) {
        if (rotation_ == null) {
          rotation_ = new global::Apollo.Common.Quaternion();
        }
        Rotation.MergeFrom(other.Rotation);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (translation_ == null) {
              translation_ = new global::Apollo.Common.Point3D();
            }
            input.ReadMessage(translation_);
            break;
          }
          case 18: {
            if (rotation_ == null) {
              rotation_ = new global::Apollo.Common.Quaternion();
            }
            input.ReadMessage(rotation_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class TransformStamped : pb::IMessage<TransformStamped> {
    private static readonly pb::MessageParser<TransformStamped> _parser = new pb::MessageParser<TransformStamped>(() => new TransformStamped());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TransformStamped> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Transform.TransformReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransformStamped() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransformStamped(TransformStamped other) : this() {
      Header = other.header_ != null ? other.Header.Clone() : null;
      childFrameId_ = other.childFrameId_;
      Transform = other.transform_ != null ? other.Transform.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransformStamped Clone() {
      return new TransformStamped(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Apollo.Common.Header header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Header Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "child_frame_id" field.</summary>
    public const int ChildFrameIdFieldNumber = 2;
    private string childFrameId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ChildFrameId {
      get { return childFrameId_; }
      set {
        childFrameId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "transform" field.</summary>
    public const int TransformFieldNumber = 3;
    private global::Apollo.Transform.Transform transform_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Transform.Transform Transform {
      get { return transform_; }
      set {
        transform_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TransformStamped);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TransformStamped other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if (ChildFrameId != other.ChildFrameId) return false;
      if (!object.Equals(Transform, other.Transform)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      if (ChildFrameId.Length != 0) hash ^= ChildFrameId.GetHashCode();
      if (transform_ != null) hash ^= Transform.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (ChildFrameId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ChildFrameId);
      }
      if (transform_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Transform);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (ChildFrameId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ChildFrameId);
      }
      if (transform_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Transform);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TransformStamped other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          header_ = new global::Apollo.Common.Header();
        }
        Header.MergeFrom(other.Header);
      }
      if (other.ChildFrameId.Length != 0) {
        ChildFrameId = other.ChildFrameId;
      }
      if (other.transform_ != null) {
        if (transform_ == null) {
          transform_ = new global::Apollo.Transform.Transform();
        }
        Transform.MergeFrom(other.Transform);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (header_ == null) {
              header_ = new global::Apollo.Common.Header();
            }
            input.ReadMessage(header_);
            break;
          }
          case 18: {
            ChildFrameId = input.ReadString();
            break;
          }
          case 26: {
            if (transform_ == null) {
              transform_ = new global::Apollo.Transform.Transform();
            }
            input.ReadMessage(transform_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class TransformStampeds : pb::IMessage<TransformStampeds> {
    private static readonly pb::MessageParser<TransformStampeds> _parser = new pb::MessageParser<TransformStampeds>(() => new TransformStampeds());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TransformStampeds> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Transform.TransformReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransformStampeds() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransformStampeds(TransformStampeds other) : this() {
      Header = other.header_ != null ? other.Header.Clone() : null;
      transforms_ = other.transforms_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransformStampeds Clone() {
      return new TransformStampeds(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Apollo.Common.Header header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Header Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "transforms" field.</summary>
    public const int TransformsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Apollo.Transform.TransformStamped> _repeated_transforms_codec
        = pb::FieldCodec.ForMessage(18, global::Apollo.Transform.TransformStamped.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Transform.TransformStamped> transforms_ = new pbc::RepeatedField<global::Apollo.Transform.TransformStamped>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Transform.TransformStamped> Transforms {
      get { return transforms_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TransformStampeds);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TransformStampeds other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if(!transforms_.Equals(other.transforms_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      hash ^= transforms_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      transforms_.WriteTo(output, _repeated_transforms_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      size += transforms_.CalculateSize(_repeated_transforms_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TransformStampeds other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          header_ = new global::Apollo.Common.Header();
        }
        Header.MergeFrom(other.Header);
      }
      transforms_.Add(other.transforms_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (header_ == null) {
              header_ = new global::Apollo.Common.Header();
            }
            input.ReadMessage(header_);
            break;
          }
          case 18: {
            transforms_.AddEntriesFrom(input, _repeated_transforms_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code