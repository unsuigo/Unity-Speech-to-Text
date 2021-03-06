// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: cloudSpeechBeta/cloud_speech.proto
// Original file comments:
// Copyright 2016 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Google.Cloud.Speech.V1Beta1 {
  /// <summary>
  ///  Service that implements Google Cloud Speech API.
  /// </summary>
  public static class Speech
  {
    static readonly string __ServiceName = "google.cloud.speech.v1beta1.Speech";

    static readonly Marshaller<global::Google.Cloud.Speech.V1Beta1.SyncRecognizeRequest> __Marshaller_SyncRecognizeRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Speech.V1Beta1.SyncRecognizeRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Speech.V1Beta1.SyncRecognizeResponse> __Marshaller_SyncRecognizeResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Speech.V1Beta1.SyncRecognizeResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Speech.V1Beta1.AsyncRecognizeRequest> __Marshaller_AsyncRecognizeRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Speech.V1Beta1.AsyncRecognizeRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Longrunning.Operation> __Marshaller_Operation = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Longrunning.Operation.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Speech.V1Beta1.StreamingRecognizeRequest> __Marshaller_StreamingRecognizeRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Speech.V1Beta1.StreamingRecognizeRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Speech.V1Beta1.StreamingRecognizeResponse> __Marshaller_StreamingRecognizeResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Speech.V1Beta1.StreamingRecognizeResponse.Parser.ParseFrom);

    static readonly Method<global::Google.Cloud.Speech.V1Beta1.SyncRecognizeRequest, global::Google.Cloud.Speech.V1Beta1.SyncRecognizeResponse> __Method_SyncRecognize = new Method<global::Google.Cloud.Speech.V1Beta1.SyncRecognizeRequest, global::Google.Cloud.Speech.V1Beta1.SyncRecognizeResponse>(
        MethodType.Unary,
        __ServiceName,
        "SyncRecognize",
        __Marshaller_SyncRecognizeRequest,
        __Marshaller_SyncRecognizeResponse);

    static readonly Method<global::Google.Cloud.Speech.V1Beta1.AsyncRecognizeRequest, global::Google.Longrunning.Operation> __Method_AsyncRecognize = new Method<global::Google.Cloud.Speech.V1Beta1.AsyncRecognizeRequest, global::Google.Longrunning.Operation>(
        MethodType.Unary,
        __ServiceName,
        "AsyncRecognize",
        __Marshaller_AsyncRecognizeRequest,
        __Marshaller_Operation);

    static readonly Method<global::Google.Cloud.Speech.V1Beta1.StreamingRecognizeRequest, global::Google.Cloud.Speech.V1Beta1.StreamingRecognizeResponse> __Method_StreamingRecognize = new Method<global::Google.Cloud.Speech.V1Beta1.StreamingRecognizeRequest, global::Google.Cloud.Speech.V1Beta1.StreamingRecognizeResponse>(
        MethodType.DuplexStreaming,
        __ServiceName,
        "StreamingRecognize",
        __Marshaller_StreamingRecognizeRequest,
        __Marshaller_StreamingRecognizeResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Speech.V1Beta1.CloudSpeechReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Speech</summary>
    public abstract class SpeechBase
    {
      /// <summary>
      ///  Perform synchronous speech-recognition: receive results after all audio
      ///  has been sent and processed.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Speech.V1Beta1.SyncRecognizeResponse> SyncRecognize(global::Google.Cloud.Speech.V1Beta1.SyncRecognizeRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Perform asynchronous speech-recognition: receive results via the
      ///  google.longrunning.Operations interface. `Operation.response` returns
      ///  `AsyncRecognizeResponse`.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Longrunning.Operation> AsyncRecognize(global::Google.Cloud.Speech.V1Beta1.AsyncRecognizeRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Perform bidirectional streaming speech-recognition: receive results while
      ///  sending audio. This method is only available via the gRPC API (not REST).
      /// </summary>
      public virtual global::System.Threading.Tasks.Task StreamingRecognize(IAsyncStreamReader<global::Google.Cloud.Speech.V1Beta1.StreamingRecognizeRequest> requestStream, IServerStreamWriter<global::Google.Cloud.Speech.V1Beta1.StreamingRecognizeResponse> responseStream, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Speech</summary>
    public class SpeechClient : ClientBase<SpeechClient>
    {
      /// <summary>Creates a new client for Speech</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SpeechClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Speech that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SpeechClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SpeechClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SpeechClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Perform synchronous speech-recognition: receive results after all audio
      ///  has been sent and processed.
      /// </summary>
      public virtual global::Google.Cloud.Speech.V1Beta1.SyncRecognizeResponse SyncRecognize(global::Google.Cloud.Speech.V1Beta1.SyncRecognizeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SyncRecognize(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Perform synchronous speech-recognition: receive results after all audio
      ///  has been sent and processed.
      /// </summary>
      public virtual global::Google.Cloud.Speech.V1Beta1.SyncRecognizeResponse SyncRecognize(global::Google.Cloud.Speech.V1Beta1.SyncRecognizeRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SyncRecognize, null, options, request);
      }
      /// <summary>
      ///  Perform synchronous speech-recognition: receive results after all audio
      ///  has been sent and processed.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Speech.V1Beta1.SyncRecognizeResponse> SyncRecognizeAsync(global::Google.Cloud.Speech.V1Beta1.SyncRecognizeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SyncRecognizeAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Perform synchronous speech-recognition: receive results after all audio
      ///  has been sent and processed.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Speech.V1Beta1.SyncRecognizeResponse> SyncRecognizeAsync(global::Google.Cloud.Speech.V1Beta1.SyncRecognizeRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SyncRecognize, null, options, request);
      }
      /// <summary>
      ///  Perform asynchronous speech-recognition: receive results via the
      ///  google.longrunning.Operations interface. `Operation.response` returns
      ///  `AsyncRecognizeResponse`.
      /// </summary>
      public virtual global::Google.Longrunning.Operation AsyncRecognize(global::Google.Cloud.Speech.V1Beta1.AsyncRecognizeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AsyncRecognize(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Perform asynchronous speech-recognition: receive results via the
      ///  google.longrunning.Operations interface. `Operation.response` returns
      ///  `AsyncRecognizeResponse`.
      /// </summary>
      public virtual global::Google.Longrunning.Operation AsyncRecognize(global::Google.Cloud.Speech.V1Beta1.AsyncRecognizeRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AsyncRecognize, null, options, request);
      }
      /// <summary>
      ///  Perform asynchronous speech-recognition: receive results via the
      ///  google.longrunning.Operations interface. `Operation.response` returns
      ///  `AsyncRecognizeResponse`.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Longrunning.Operation> AsyncRecognizeAsync(global::Google.Cloud.Speech.V1Beta1.AsyncRecognizeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AsyncRecognizeAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Perform asynchronous speech-recognition: receive results via the
      ///  google.longrunning.Operations interface. `Operation.response` returns
      ///  `AsyncRecognizeResponse`.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Longrunning.Operation> AsyncRecognizeAsync(global::Google.Cloud.Speech.V1Beta1.AsyncRecognizeRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AsyncRecognize, null, options, request);
      }
      /// <summary>
      ///  Perform bidirectional streaming speech-recognition: receive results while
      ///  sending audio. This method is only available via the gRPC API (not REST).
      /// </summary>
      public virtual AsyncDuplexStreamingCall<global::Google.Cloud.Speech.V1Beta1.StreamingRecognizeRequest, global::Google.Cloud.Speech.V1Beta1.StreamingRecognizeResponse> StreamingRecognize(Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return StreamingRecognize(new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Perform bidirectional streaming speech-recognition: receive results while
      ///  sending audio. This method is only available via the gRPC API (not REST).
      /// </summary>
      public virtual AsyncDuplexStreamingCall<global::Google.Cloud.Speech.V1Beta1.StreamingRecognizeRequest, global::Google.Cloud.Speech.V1Beta1.StreamingRecognizeResponse> StreamingRecognize(CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_StreamingRecognize, null, options);
      }
      protected override SpeechClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SpeechClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(SpeechBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SyncRecognize, serviceImpl.SyncRecognize)
          .AddMethod(__Method_AsyncRecognize, serviceImpl.AsyncRecognize)
          .AddMethod(__Method_StreamingRecognize, serviceImpl.StreamingRecognize).Build();
    }

  }
}
#endregion
