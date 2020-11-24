// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

#pragma warning disable SA1200 // Using directives should be placed correctly
#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1649 // File name should match first type name

namespace CoreLibrary.Generated.Resolvers
{
    using System;

    public class CoreLibraryGeneratedResolver : global::MessagePack.IFormatterResolver
    {
        public static readonly global::MessagePack.IFormatterResolver Instance = new CoreLibraryGeneratedResolver();

        private CoreLibraryGeneratedResolver()
        {
        }

        public global::MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.Formatter;
        }

        private static class FormatterCache<T>
        {
            internal static readonly global::MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

            static FormatterCache()
            {
                var f = CoreLibraryGeneratedResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    Formatter = (global::MessagePack.Formatters.IMessagePackFormatter<T>)f;
                }
            }
        }
    }

    internal static class CoreLibraryGeneratedResolverGetFormatterHelper
    {
        private static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static CoreLibraryGeneratedResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(7)
            {
                { typeof(global::System.Collections.Generic.List<global::CoreLibrary.Models.Crypto.CryptoKeyProtectorAssociation>), 0 },
                { typeof(object[]), 1 },
                { typeof(global::CoreLibrary.Models.Crypto.CryptoKeyProtectorIntent), 2 },
                { typeof(global::CoreLibrary.Models.Crypto.CryptoKey), 3 },
                { typeof(global::CoreLibrary.Models.Crypto.CryptoKeyProtector), 4 },
                { typeof(global::CoreLibrary.Models.Crypto.CryptoKeyProtectorAssociation), 5 },
                { typeof(global::CoreLibrary.Models.Crypto.Providers.CertificateCryptoProvider.CertificateCryptoProviderState), 6 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key))
            {
                return null;
            }

            switch (key)
            {
                case 0: return new global::MessagePack.Formatters.ListFormatter<global::CoreLibrary.Models.Crypto.CryptoKeyProtectorAssociation>();
                case 1: return new global::MessagePack.Formatters.ArrayFormatter<object>();
                case 2: return new CoreLibrary.Generated.Formatters.CoreLibrary.Models.Crypto.CryptoKeyProtectorIntentFormatter();
                case 3: return new CoreLibrary.Generated.Formatters.CoreLibrary.Models.Crypto.CryptoKeyFormatter();
                case 4: return new CoreLibrary.Generated.Formatters.CoreLibrary.Models.Crypto.CryptoKeyProtectorFormatter();
                case 5: return new CoreLibrary.Generated.Formatters.CoreLibrary.Models.Crypto.CryptoKeyProtectorAssociationFormatter();
                case 6: return new CoreLibrary.Generated.Formatters.CoreLibrary.Models.Crypto.Providers.CertificateCryptoProvider_CertificateCryptoProviderStateFormatter();
                default: return null;
            }
        }
    }
}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning restore SA1649 // File name should match first type name


// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

#pragma warning disable SA1200 // Using directives should be placed correctly
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace CoreLibrary.Generated.Formatters.CoreLibrary.Models.Crypto
{
    using System;
    using System.Buffers;
    using MessagePack;

    public sealed class CryptoKeyProtectorIntentFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::CoreLibrary.Models.Crypto.CryptoKeyProtectorIntent>
    {
        public void Serialize(ref MessagePackWriter writer, global::CoreLibrary.Models.Crypto.CryptoKeyProtectorIntent value, global::MessagePack.MessagePackSerializerOptions options)
        {
            writer.Write((Int32)value);
        }

        public global::CoreLibrary.Models.Crypto.CryptoKeyProtectorIntent Deserialize(ref MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            return (global::CoreLibrary.Models.Crypto.CryptoKeyProtectorIntent)reader.ReadInt32();
        }
    }
}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name



// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

#pragma warning disable SA1129 // Do not use default value type constructor
#pragma warning disable SA1200 // Using directives should be placed correctly
#pragma warning disable SA1309 // Field names should not begin with underscore
#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace CoreLibrary.Generated.Formatters.CoreLibrary.Models.Crypto
{
    using System;
    using System.Buffers;
    using MessagePack;

    public sealed class CryptoKeyFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::CoreLibrary.Models.Crypto.CryptoKey>
    {

        public void Serialize(ref MessagePackWriter writer, global::CoreLibrary.Models.Crypto.CryptoKey value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNil();
                return;
            }

            IFormatterResolver formatterResolver = options.Resolver;
            writer.WriteArrayHeader(2);
            formatterResolver.GetFormatterWithVerify<global::System.Guid>().Serialize(ref writer, value.KeyId, options);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<global::CoreLibrary.Models.Crypto.CryptoKeyProtectorAssociation>>().Serialize(ref writer, value.Protectors, options);
        }

        public global::CoreLibrary.Models.Crypto.CryptoKey Deserialize(ref MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            IFormatterResolver formatterResolver = options.Resolver;
            var length = reader.ReadArrayHeader();
            var __KeyId__ = default(global::System.Guid);
            var __Protectors__ = default(global::System.Collections.Generic.List<global::CoreLibrary.Models.Crypto.CryptoKeyProtectorAssociation>);

            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 0:
                        __KeyId__ = formatterResolver.GetFormatterWithVerify<global::System.Guid>().Deserialize(ref reader, options);
                        break;
                    case 1:
                        __Protectors__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<global::CoreLibrary.Models.Crypto.CryptoKeyProtectorAssociation>>().Deserialize(ref reader, options);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var ____result = new global::CoreLibrary.Models.Crypto.CryptoKey();
            ____result.KeyId = __KeyId__;
            ____result.Protectors = __Protectors__;
            reader.Depth--;
            return ____result;
        }
    }

    public sealed class CryptoKeyProtectorFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::CoreLibrary.Models.Crypto.CryptoKeyProtector>
    {

        public void Serialize(ref MessagePackWriter writer, global::CoreLibrary.Models.Crypto.CryptoKeyProtector value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNil();
                return;
            }

            IFormatterResolver formatterResolver = options.Resolver;
            value.OnBeforeSerialize();
            writer.WriteArrayHeader(3);
            writer.Write(value.ProtectorKey);
            formatterResolver.GetFormatterWithVerify<object[]>().Serialize(ref writer, value.ProtectorState, options);
            formatterResolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.ProtectorName, options);
        }

        public global::CoreLibrary.Models.Crypto.CryptoKeyProtector Deserialize(ref MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            IFormatterResolver formatterResolver = options.Resolver;
            var length = reader.ReadArrayHeader();
            var __ProtectorKey__ = default(byte[]);
            var __ProtectorState__ = default(object[]);
            var __ProtectorName__ = default(string);

            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 0:
                        __ProtectorKey__ = reader.ReadBytes()?.ToArray();
                        break;
                    case 1:
                        __ProtectorState__ = formatterResolver.GetFormatterWithVerify<object[]>().Deserialize(ref reader, options);
                        break;
                    case 2:
                        __ProtectorName__ = formatterResolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var ____result = new global::CoreLibrary.Models.Crypto.CryptoKeyProtector();
            ____result.ProtectorKey = __ProtectorKey__;
            ____result.ProtectorState = __ProtectorState__;
            ____result.ProtectorName = __ProtectorName__;
            ____result.OnAfterDeserialize();
            reader.Depth--;
            return ____result;
        }
    }

    public sealed class CryptoKeyProtectorAssociationFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::CoreLibrary.Models.Crypto.CryptoKeyProtectorAssociation>
    {

        public void Serialize(ref MessagePackWriter writer, global::CoreLibrary.Models.Crypto.CryptoKeyProtectorAssociation value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNil();
                return;
            }

            IFormatterResolver formatterResolver = options.Resolver;
            writer.WriteArrayHeader(2);
            formatterResolver.GetFormatterWithVerify<global::CoreLibrary.Models.Crypto.CryptoKeyProtectorIntent>().Serialize(ref writer, value.Intent, options);
            formatterResolver.GetFormatterWithVerify<global::CoreLibrary.Models.Crypto.CryptoKeyProtector>().Serialize(ref writer, value.Protector, options);
        }

        public global::CoreLibrary.Models.Crypto.CryptoKeyProtectorAssociation Deserialize(ref MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            IFormatterResolver formatterResolver = options.Resolver;
            var length = reader.ReadArrayHeader();
            var __Intent__ = default(global::CoreLibrary.Models.Crypto.CryptoKeyProtectorIntent);
            var __Protector__ = default(global::CoreLibrary.Models.Crypto.CryptoKeyProtector);

            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 0:
                        __Intent__ = formatterResolver.GetFormatterWithVerify<global::CoreLibrary.Models.Crypto.CryptoKeyProtectorIntent>().Deserialize(ref reader, options);
                        break;
                    case 1:
                        __Protector__ = formatterResolver.GetFormatterWithVerify<global::CoreLibrary.Models.Crypto.CryptoKeyProtector>().Deserialize(ref reader, options);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var ____result = new global::CoreLibrary.Models.Crypto.CryptoKeyProtectorAssociation();
            ____result.Intent = __Intent__;
            ____result.Protector = __Protector__;
            reader.Depth--;
            return ____result;
        }
    }
}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1129 // Do not use default value type constructor
#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning restore SA1309 // Field names should not begin with underscore
#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name

// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

#pragma warning disable SA1129 // Do not use default value type constructor
#pragma warning disable SA1200 // Using directives should be placed correctly
#pragma warning disable SA1309 // Field names should not begin with underscore
#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace CoreLibrary.Generated.Formatters.CoreLibrary.Models.Crypto.Providers
{
    using System;
    using System.Buffers;
    using MessagePack;

    public sealed class CertificateCryptoProvider_CertificateCryptoProviderStateFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::CoreLibrary.Models.Crypto.Providers.CertificateCryptoProvider.CertificateCryptoProviderState>
    {

        public void Serialize(ref MessagePackWriter writer, global::CoreLibrary.Models.Crypto.Providers.CertificateCryptoProvider.CertificateCryptoProviderState value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNil();
                return;
            }

            IFormatterResolver formatterResolver = options.Resolver;
            writer.WriteArrayHeader(2);
            formatterResolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.Serial, options);
            writer.Write(value.ProviderKey);
        }

        public global::CoreLibrary.Models.Crypto.Providers.CertificateCryptoProvider.CertificateCryptoProviderState Deserialize(ref MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            IFormatterResolver formatterResolver = options.Resolver;
            var length = reader.ReadArrayHeader();
            var __Serial__ = default(string);
            var __ProviderKey__ = default(byte[]);

            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 0:
                        __Serial__ = formatterResolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
                        break;
                    case 1:
                        __ProviderKey__ = reader.ReadBytes()?.ToArray();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var ____result = new global::CoreLibrary.Models.Crypto.Providers.CertificateCryptoProvider.CertificateCryptoProviderState();
            ____result.Serial = __Serial__;
            ____result.ProviderKey = __ProviderKey__;
            reader.Depth--;
            return ____result;
        }
    }
}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1129 // Do not use default value type constructor
#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning restore SA1309 // Field names should not begin with underscore
#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name

