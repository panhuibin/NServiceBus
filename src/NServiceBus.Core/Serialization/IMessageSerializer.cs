namespace NServiceBus.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Interface used for serializing and deserializing messages.
    /// </summary>
    public interface IMessageSerializer
    {
        /// <summary>
        /// Gets the content type into which this serializer serializes the content to.
        /// </summary>
        string ContentType { get; }

        /// <summary>
        /// Serializes the given set of messages into the given stream.
        /// </summary>
        /// <param name="message">Message to serialize.</param>
        /// <param name="stream">Stream for <paramref name="message" /> to be serialized into.</param>
        void Serialize(object message, Stream stream);

        /// <summary>
        /// Deserializes from the given stream a set of messages.
        /// </summary>
        /// <param name="body">Byte array that contains messages.</param>
        /// <param name="messageTypes">
        /// The list of message types to deserialize. If null the types must be inferred from the
        /// serialized data.
        /// </param>
        /// <returns>Deserialized messages.</returns>
        object[] Deserialize(ReadOnlyMemory<byte> body, IList<Type> messageTypes = null);
    }
}