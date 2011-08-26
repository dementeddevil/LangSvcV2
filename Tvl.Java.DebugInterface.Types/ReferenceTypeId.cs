﻿namespace Tvl.Java.DebugInterface.Types
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public struct ReferenceTypeId : IEquatable<ReferenceTypeId>
    {
        [DataMember(IsRequired = true)]
        public long Handle;

        public ReferenceTypeId(long handle)
        {
            Handle = handle;
        }

        public static bool operator ==(ReferenceTypeId x, ReferenceTypeId y)
        {
            return x.Handle == y.Handle;
        }

        public static bool operator !=(ReferenceTypeId x, ReferenceTypeId y)
        {
            return x.Handle != y.Handle;
        }

        public bool Equals(ReferenceTypeId other)
        {
            return this.Handle == other.Handle;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ReferenceTypeId))
                return false;

            return this.Handle == ((ReferenceTypeId)obj).Handle;
        }

        public override int GetHashCode()
        {
            return Handle.GetHashCode();
        }
    }
}
