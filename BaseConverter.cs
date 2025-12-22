/*
TCreative Commons Attribution-NonCommercial 4.0 International
(CC BY-NC 4.0)

Copyright © 2025 Alexander Keyser
https://Website-ajk.uk

This project is licensed under the Creative Commons
Attribution-NonCommercial 4.0 International License.

Full license text:
https://creativecommons.org/licenses/by-nc/4.0/
Or open the LICENSE File within this project
*/

/*
 "BaseConverter" is a C# library that can convert between base 2, 10, and 16
 This is Version 1.0
*/

namespace BaseConverter;
public class BaseConverter
{ 
        #region IntToBinary
        public static string Base10_To_2(byte Integer)
        {
            List<byte> list = new List<byte>();
            byte bit;
            list.Add(0);
            for (int i = 0; Integer > 0; i++)
            {
                bit = Convert.ToByte(Integer % 2);
                list.Add(bit);
                Integer = Convert.ToByte(Integer / 2);
            }
            string FinalBinary = string.Empty;
            for (int i = list.Count -1; i > 0; i--)
            {
                FinalBinary += list[i];
            }

            return FinalBinary;
        }
        public static string Base10_To_2(Int16 Integer)
        {
            List<Int16> list = new List<Int16>();
            Int16 bit;
            list.Add(0);
            for (int i = 0; Integer > 0; i++)
            {

                bit = Convert.ToInt16(Integer % 2);
                list.Add(bit);
                Integer = Convert.ToInt16(Integer / 2);
            }
            string FinalBinary = string.Empty;
            for (int i = list.Count -1; i > 0; i--)
            {
                FinalBinary += list[i];
            }

            return FinalBinary;
        }
        public static string Base10_To_2(Int32 Integer)
        {
            List<Int32> list = new List<Int32>();
            Int32 bit;
            list.Add(0);
            for (int i = 0; Integer > 0; i++)
            {
                bit = Integer % 2;
                list.Add(bit);
                Integer = Integer / 2;
            }
            string FinalBinary = string.Empty;
            for (int i = list.Count -1; i > 0; i--)
            {
                FinalBinary += list[i];
            }

            return FinalBinary;
        }
        public static string Base10_To_2(Int64 Integer)
        {
            List<Int64> list = new List<Int64>();
            Int64 bit;
            list.Add(0);
            for (int i = 0; Integer > 0; i++)
            {
                bit = Integer % 2;
                list.Add(bit);
                Integer = Integer / 2;
            }
            string FinalBinary = string.Empty;
            for (int i = list.Count -1; i > 0; i--)
            {
                FinalBinary += list[i];
            }

            return FinalBinary;
        }
        public static string Base10_To_2(Int128 Integer)
        {
            List<Int128> list = new List<Int128>();
            Int128 bit;
            list.Add(0);
            for (int i = 0; Integer > 0; i++)
            {
                bit = Integer % 2;
                list.Add(bit);
                Integer = Integer / 2;
            }
            string FinalBinary = string.Empty;
            for (int i = list.Count -1; i > 0; i--)
            {
                FinalBinary += list[i];
            }

            return FinalBinary;
        }
        #endregion

        #region IntToHex
        public static string Base10_To_16(byte Integer)
        {
            return Convert.ToString(Integer, 16);
        }
        public static string Base10_To_16(Int16 Integer)
        {
            return Convert.ToString(Integer, 16);
        }
        public static string Base10_To_16(Int32 Integer)
        {
            return Convert.ToString(Integer, 16);
        }
        public static string Base10_To_16(Int64 Integer)
        {
            return Convert.ToString(Integer, 16);
        }
        #endregion

        #region BinaryToInt
        public static byte Base2_To_10_Byte(string Binary)
        {
            return Convert.ToByte(Binary, 2);
        }
        public static Int16 Base2_To_10_Int16(string Binary)
        {
            return Convert.ToInt16(Binary, 2);
        }
        public static Int32 Base2_To_10_Int32(string Binary)
        {
            return Convert.ToInt32(Binary, 2);
        }
        public static Int64 Base2_To_10_Int64(string Binary)
        {
            return Convert.ToInt64(Binary, 2);
        }
        #endregion

        #region BinaryToHex
        public static string BinaryToHex(string Binary)
        {
            return Base10_To_16(Base2_To_10_Int64(Binary));
        }
        #endregion

        #region HexToInt
        public static byte Base16_To_10_Byte(string Hex)
        {
            return Convert.ToByte(Hex, 16);
        }
        public static Int16 Base16_To_10_Int16(string Hex)
        {
            return Convert.ToInt16(Hex, 16);
        }
        public static Int32 Base16_To_10_Int32(string Hex)
        {
            return Convert.ToInt32(Hex, 16);
        }
        public static Int64 Base16_To_10_Int64(string Hex)
        {
            return Convert.ToInt64(Hex, 16);
        }
        #endregion

        #region HexToBinary
        public static string Base16_To_2(string Hex)
        {
            return Convert.ToString(Base16_To_10_Int64(Hex), 2);
            
        }
        #endregion

}