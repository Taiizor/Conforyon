namespace Conforyon.Enum
{
    /// <summary>
    /// 
    /// </summary>
    public class Enums
    {
        #region Enums

        /// <summary>
        /// 
        /// </summary>
        public enum ColorType
        {
            /// <summary>
            /// 
            /// </summary>
            RGB1,
            /// <summary>
            /// 
            /// </summary>
            RGB2,
            /// <summary>
            /// 
            /// </summary>
            RGB3,
            /// <summary>
            /// 
            /// </summary>
            RRGGBB1,
            /// <summary>
            /// 
            /// </summary>
            RRGGBB2,
            /// <summary>
            /// 
            /// </summary>
            RRGGBB3,
            /// <summary>
            /// 
            /// </summary>
            RR,
            /// <summary>
            /// 
            /// </summary>
            GG,
            /// <summary>
            /// 
            /// </summary>
            BB,
            /// <summary>
            /// 
            /// </summary>
            OnlyR,
            /// <summary>
            /// 
            /// </summary>
            OnlyG,
            /// <summary>
            /// 
            /// </summary>
            OnlyB
        }

        /// <summary>
        /// 
        /// </summary>
        public enum CryptologyType
        {
            /// <summary>
            /// 
            /// </summary>
            AES,
            /// <summary>
            /// 
            /// </summary>
            MD5,
            /// <summary>
            /// 
            /// </summary>
            SHA1,
            /// <summary>
            /// 
            /// </summary>
            SHA256,
            /// <summary>
            /// 
            /// </summary>
            SHA384,
            /// <summary>
            /// 
            /// </summary>
            SHA512,
            /// <summary>
            /// 
            /// </summary>
            TEXT,
            /// <summary>
            /// 
            /// </summary>
            BASE
        }

        /// <summary>
        /// 
        /// </summary>
        public enum HashType
        {
            /// <summary>
            /// 
            /// </summary>
            MD5,
            /// <summary>
            /// 
            /// </summary>
            SHA1,
            /// <summary>
            /// 
            /// </summary>
            SHA256,
            /// <summary>
            /// 
            /// </summary>
            SHA384,
            /// <summary>
            /// 
            /// </summary>
            SHA512
        }

        /// <summary>
        /// 
        /// </summary>
        public enum LengthType
        {
            /// <summary>
            /// 
            /// </summary>
            MM,
            /// <summary>
            /// 
            /// </summary>
            CM,
            /// <summary>
            /// 
            /// </summary>
            DM,
            /// <summary>
            /// 
            /// </summary>
            M,
            /// <summary>
            /// 
            /// </summary>
            DAM,
            /// <summary>
            /// 
            /// </summary>
            HM,
            /// <summary>
            /// 
            /// </summary>
            KM,
        }

        /// <summary>
        /// 
        /// </summary>
        public enum SpeedType
        {
            /// <summary>
            /// 
            /// </summary>
            MPH,
            /// <summary>
            /// 
            /// </summary>
            KPH
        }

        /// <summary>
        /// 
        /// </summary>
        public enum StorageType
        {
            /// <summary>
            /// 
            /// </summary>
            Bit,
            /// <summary>
            /// 
            /// </summary>
            Byte,
            /// <summary>
            /// 
            /// </summary>
            KB,
            /// <summary>
            /// 
            /// </summary>
            MB,
            /// <summary>
            /// 
            /// </summary>
            GB,
            /// <summary>
            /// 
            /// </summary>
            TB,
            /// <summary>
            /// 
            /// </summary>
            PB,
            /// <summary>
            /// 
            /// </summary>
            EB,
            /// <summary>
            /// 
            /// </summary>
            ZB,
            /// <summary>
            /// 
            /// </summary>
            YB
        }

        /// <summary>
        /// 
        /// </summary>
        public enum TimeType
        {
            /// <summary>
            /// 
            /// </summary>
            Nanosecond,
            /// <summary>
            /// 
            /// </summary>
            Microsecond,
            /// <summary>
            /// 
            /// </summary>
            Millisecond,
            /// <summary>
            /// 
            /// </summary>
            Second,
            /// <summary>
            /// 
            /// </summary>
            Minute,
            /// <summary>
            /// 
            /// </summary>
            Hour,
            /// <summary>
            /// 
            /// </summary>
            Day,
            /// <summary>
            /// 
            /// </summary>
            Week,
            /// <summary>
            /// 
            /// </summary>
            Year,
            /// <summary>
            /// 
            /// </summary>
            Century,
            /// <summary>
            /// 
            /// </summary>
            Millennium
        }

        /// <summary>
        /// 
        /// </summary>
        public enum WeightType
        {
            /// <summary>
            /// 
            /// </summary>
            Milligram,
            /// <summary>
            /// 
            /// </summary>
            Gram,
            /// <summary>
            /// 
            /// </summary>
            KG
        }

        /// <summary>
        /// 
        /// </summary>
        public enum TypographyType
        {
            /// <summary>
            /// 
            /// </summary>
            INCH,
            /// <summary>
            /// 
            /// </summary>
            CM,
            /// <summary>
            /// 
            /// </summary>
            PX
        }

        /// <summary>
        /// 
        /// </summary>
        public enum TemperatureType
        {
            /// <summary>
            /// 
            /// </summary>
            Celsius,
            /// <summary>
            /// 
            /// </summary>
            Fahrenheit
        }

        /// <summary>
        /// 
        /// </summary>
        public enum IntType
        {
            /// <summary>
            /// 
            /// </summary>
            Int16,
            /// <summary>
            /// 
            /// </summary>
            Int32,
            /// <summary>
            /// 
            /// </summary>
            Int64,
            /// <summary>
            /// 
            /// </summary>
            UInt16,
            /// <summary>
            /// 
            /// </summary>
            UInt32,
            /// <summary>
            /// 
            /// </summary>
            UInt64
        }

        /// <summary>
        /// 
        /// </summary>
        public enum SearchType
        {
            /// <summary>
            /// 
            /// </summary>
            Starts,
            /// <summary>
            /// 
            /// </summary>
            Contains,
            /// <summary>
            /// 
            /// </summary>
            Ends
        }

        /// <summary>
        /// 
        /// </summary>
        public enum DetectType
        {
            /// <summary>
            /// 
            /// </summary>
            Dot,
            /// <summary>
            /// 
            /// </summary>
            Comma,
            /// <summary>
            /// 
            /// </summary>
            None
        }

        /// <summary>
        /// 
        /// </summary>
        public enum MethodType
        {
            /// <summary>
            /// 
            /// </summary>
            DataStorage,
            /// <summary>
            /// 
            /// </summary>
            Temperature,
            /// <summary>
            /// 
            /// </summary>
            Typography,
            /// <summary>
            /// 
            /// </summary>
            Speed,
#if CONFORYON
            /// <summary>
            /// 
            /// </summary>
            Error,
#endif
            /// <summary>
            /// 
            /// </summary>
            Time
        }

        #endregion
    }
}