using System;

namespace CSharpFun
{
    public delegate bool TryParse<T>(string value, out T parsed);

    public static class TryParse
    {
        public static Option<bool> Bool(string value) => To<bool>(value, bool.TryParse);

        public static Option<byte> Byte(string value) => To<byte>(value, byte.TryParse);

        public static Option<sbyte> SByte(string value) => To<sbyte>(value, sbyte.TryParse);

        public static Option<char> Char(string value) => To<char>(value, char.TryParse);

        public static Option<decimal> Decimal(string value) => To<decimal>(value, decimal.TryParse);

        public static Option<double> Double(string value) => To<double>(value, double.TryParse);

        public static Option<float> Float(string value) => To<float>(value, float.TryParse);

        public static Option<int> Int(string value) => To<int>(value, int.TryParse);

        public static Option<uint> UInt(string value) => To<uint>(value, uint.TryParse);

        public static Option<long> Long(string value) => To<long>(value, long.TryParse);

        public static Option<ulong> ULong(string value) => To<ulong>(value, ulong.TryParse);

        public static Option<short> Short(string value) => To<short>(value, short.TryParse);

        public static Option<ushort> UShort(string value) => To<ushort>(value, ushort.TryParse);

        public static Option<DateTime> DateTime(string value) => To<DateTime>(value, System.DateTime.TryParse);

        public static Option<DateTimeOffset> DateTimeOffset(string value) => To<DateTimeOffset>(value, System.DateTimeOffset.TryParse);

        public static Option<TEnum> Enum<TEnum>(string value) where TEnum : struct, Enum => To<TEnum>(value, System.Enum.TryParse);

        public static Option<T> To<T>(string value, TryParse<T> tryParse)
        {
            if (tryParse == null) throw new ArgumentNullException(nameof(tryParse));

            return tryParse(value, out var parsed) 
                ? Option.Some(parsed) 
                : Option.None;
        }
    }
}