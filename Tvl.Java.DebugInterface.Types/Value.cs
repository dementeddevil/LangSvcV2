﻿namespace Tvl.Java.DebugInterface.Types
{
    using System.Runtime.Serialization;
    using BitConverter = System.BitConverter;

    [DataContract]
    public struct Value
    {
        [DataMember(IsRequired = true)]
        public Tag Tag;

        [DataMember(IsRequired = true)]
        public long Data;

        public Value(Tag tag, long data)
        {
            Tag = tag;
            Data = data;
        }

        public static implicit operator Value(bool value)
        {
            return new Value(Tag.Boolean, value ? 1 : 0);
        }

        public static implicit operator Value(byte value)
        {
            return new Value(Tag.Byte, value);
        }

        public static implicit operator Value(short value)
        {
            return new Value(Tag.Short, value);
        }

        public static implicit operator Value(int value)
        {
            return new Value(Tag.Int, value);
        }

        public static implicit operator Value(long value)
        {
            return new Value(Tag.Long, value);
        }

        public static implicit operator Value(char value)
        {
            return new Value(Tag.Char, value);
        }

        public static implicit operator Value(float value)
        {
            return new Value(Tag.Float, ValueHelper.SingleToInt32Bits(value));
        }

        public static implicit operator Value(double value)
        {
            return new Value(Tag.Double, BitConverter.DoubleToInt64Bits(value));
        }

        public static implicit operator Value(TaggedObjectId value)
        {
            return new Value(value.Tag, value.ObjectId.Handle);
        }
    }
}
