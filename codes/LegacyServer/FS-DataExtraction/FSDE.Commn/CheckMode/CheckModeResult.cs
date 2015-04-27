﻿#region FileHeader
//  --------------------------------------------------------------------------------------------
//  <copyright file="CheckModeResult.cs" company="江苏飞尚安全监测咨询有限公司">
//  Copyright (C) 2014 飞尚科技
//  版权所有。 
//  </copyright>
//  <summary>
//  文件功能描述：
// 
//  创建标识：Created in 20140408 by WIN .
// 
//  修改标识：
//  修改描述：
// 
//  修改标识：
//  修改描述：
//  </summary>
//  ---------------------------------------------------------------------------------------------
#endregion
namespace FSDE.Commn.CheckMode
{
    using System.Linq;

    /// <summary>
    /// The check mode result.
    /// </summary>
    public class CheckModeResult
    {
        /// <summary>
        /// The get check result.
        /// </summary>
        /// <param name="packsge">
        /// The packsge.
        /// </param>
        /// <param name="startIndex">
        /// The start index.
        /// </param>
        /// <param name="endIndex">
        /// The end index.
        /// </param>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="byte[]"/>.
        /// </returns>
        public static byte[] GetCheckResult(byte[] packsge,int startIndex, int endIndex, CheckType type)
        {
            switch (type)
            {
                case CheckType.CRC16HighByteFirst:
                    return CalculateCrc16(packsge, startIndex, endIndex);
                case CheckType.CRC16LowByteFirst:
                    byte[] crc16 = CalculateCrc16(packsge, startIndex, endIndex);
                    return new[] { crc16[1], crc16[0] };
                case CheckType.Xor:
                    byte xor = CheckXor(packsge, startIndex, endIndex);
                    return new[] { xor };
                case CheckType.CRC8:
                    return CheckCrc8(packsge, startIndex, endIndex);
                case CheckType.PlusSum:
                   return CheckPlusSum(packsge, startIndex, endIndex);
                case CheckType.XorSum:
                    return CheckXorSum(packsge, startIndex, endIndex);
                case CheckType.NONE:
                    return new byte[] { 0, 0, 0, 0 };
                default:
                    return new byte[] { 0, 0, 0, 0 };
            }
        }
        
        /// <summary>
        /// The calculate crc 16.
        /// </summary>
        /// <param name="sourseArray">
        /// The sourse array.
        /// </param>
        /// <param name="startIndex">
        /// The start index.
        /// </param>
        /// <param name="endIndex">
        /// The end index.
        /// </param>
        /// <returns>
        /// The <see cref="byte[]"/>.
        /// </returns>
        private static byte[] CalculateCrc16(byte[] sourseArray, int startIndex, int endIndex)
        {
            byte crcHi = 0xff;
            byte crcLo = 0xff;
            for (int i = startIndex; i <= sourseArray.Length - endIndex; i++)
            {
                int crcIndex = crcLo ^ sourseArray[i];
                crcLo = (byte)(crcHi ^ crcTableH[crcIndex]);
                crcHi = crcTableL[crcIndex];
            }

            return new[] { crcHi, crcLo };
        }
        
        /// <summary>
        /// The com crc 8.
        /// </summary>
        /// <param name="sourseArray">
        /// The comp obj.
        /// </param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        private static byte[] CheckCrc8(byte[] sourseArray, int startIndex, int endIndex)
        {
            var val = new byte[sourseArray.Length - startIndex - endIndex + 1];
            for (int i = startIndex, j = 0; i <= sourseArray.Length - endIndex; i++)
            {
                val[j] = sourseArray[i];
                j++;
            }

            byte crc8 = val.Aggregate<byte, byte>(0, (current, b) => Crc8Table[current ^ b]);
            return new[] { crc8 };
        }

        /// <summary>
        /// 异或校验
        /// </summary>
        /// <returns></returns>
        private static byte CheckXor(byte[] packsge, int startIndex, int endIndex)
        {
            byte result = 0;
            for (int i = startIndex; i <= packsge.Length-endIndex; i++)
            {
                result = (byte)((((int)result) ^ ((int)packsge[i])) & 0x000000ff);
            }

            return result;
        }

        private static byte[] CheckPlusSum(byte[] packsge, int startIndex, int endIndex)
        {
            int sum = 0;
            for (int i = startIndex; i <= packsge.Length - endIndex; i++)
            {
                sum = (sum + packsge[i]) % 0xffff;
            }

            return new[] { (byte)(sum & 0xff) };
        }

        private static byte[] CheckXorSum(byte[] packsge, int startIndex, int endIndex)
        {
            byte check = (byte)(packsge[startIndex] ^ packsge[startIndex + 1]);
            for (int i = startIndex + 2; i < packsge.Length - endIndex + 1; i++)
            {
                check = (byte)(check ^ packsge[i]);
            }
            return new []{check};
        }


        #region CRC8校验表

        private static readonly byte[] Crc8Table =
            {
                0, 94, 188, 226, 97, 63, 221, 131, 194, 156, 126, 32, 163, 253, 31,
                65, 157, 195, 33, 127, 252, 162, 64, 30, 95, 1, 227, 189, 62, 96,
                130, 220, 35, 125, 159, 193, 66, 28, 254, 160, 225, 191, 93, 3, 128,
                222, 60, 98, 190, 224, 2, 92, 223, 129, 99, 61, 124, 34, 192, 158,
                29, 67, 161, 255, 70, 24, 250, 164, 39, 121, 155, 197, 132, 218, 56,
                102, 229, 187, 89, 7, 219, 133, 103, 57, 186, 228, 6, 88, 25, 71,
                165, 251, 120, 38, 196, 154, 101, 59, 217, 135, 4, 90, 184, 230,
                167, 249, 27, 69, 198, 152, 122, 36, 248, 166, 68, 26, 153, 199, 37,
                123, 58, 100, 134, 216, 91, 5, 231, 185, 140, 210, 48, 110, 237,
                179, 81, 15, 78, 16, 242, 172, 47, 113, 147, 205, 17, 79, 173, 243,
                112, 46, 204, 146, 211, 141, 111, 49, 178, 236, 14, 80, 175, 241,
                19, 77, 206, 144, 114, 44, 109, 51, 209, 143, 12, 82, 176, 238, 50,
                108, 142, 208, 83, 13, 239, 177, 240, 174, 76, 18, 145, 207, 45,
                115, 202, 148, 118, 40, 171, 245, 23, 73, 8, 86, 180, 234, 105, 55,
                213, 139, 87, 9, 235, 181, 54, 104, 138, 212, 149, 203, 41, 119,
                244, 170, 72, 22, 233, 183, 85, 11, 136, 214, 52, 106, 43, 117, 151,
                201, 74, 20, 246, 168, 116, 42, 200, 150, 21, 75, 169, 247, 182,
                232, 10, 84, 215, 137, 107, 53
            };

        #endregion CRC8校验表

        #region CRC16校验表

        private static byte[] crcTableH =
            {
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
                0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
                0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
                0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
                0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
                0x00, 0xC1, 0x81, 0x40,
            };

        private static byte[] crcTableL =
            {
                0x00, 0xC0, 0xC1, 0x01, 0xC3, 0x03, 0x02, 0xC2, 0xC6, 0x06, 0x07, 0xC7,
                0x05, 0xC5, 0xC4, 0x04, 0xCC, 0x0C, 0x0D, 0xCD, 0x0F, 0xCF, 0xCE, 0x0E,
                0x0A, 0xCA, 0xCB, 0x0B, 0xC9, 0x09, 0x08, 0xC8, 0xD8, 0x18, 0x19, 0xD9,
                0x1B, 0xDB, 0xDA, 0x1A, 0x1E, 0xDE, 0xDF, 0x1F, 0xDD, 0x1D, 0x1C, 0xDC,
                0x14, 0xD4, 0xD5, 0x15, 0xD7, 0x17, 0x16, 0xD6, 0xD2, 0x12, 0x13, 0xD3,
                0x11, 0xD1, 0xD0, 0x10, 0xF0, 0x30, 0x31, 0xF1, 0x33, 0xF3, 0xF2, 0x32,
                0x36, 0xF6, 0xF7, 0x37, 0xF5, 0x35, 0x34, 0xF4, 0x3C, 0xFC, 0xFD, 0x3D,
                0xFF, 0x3F, 0x3E, 0xFE, 0xFA, 0x3A, 0x3B, 0xFB, 0x39, 0xF9, 0xF8, 0x38,
                0x28, 0xE8, 0xE9, 0x29, 0xEB, 0x2B, 0x2A, 0xEA, 0xEE, 0x2E, 0x2F, 0xEF,
                0x2D, 0xED, 0xEC, 0x2C, 0xE4, 0x24, 0x25, 0xE5, 0x27, 0xE7, 0xE6, 0x26,
                0x22, 0xE2, 0xE3, 0x23, 0xE1, 0x21, 0x20, 0xE0, 0xA0, 0x60, 0x61, 0xA1,
                0x63, 0xA3, 0xA2, 0x62, 0x66, 0xA6, 0xA7, 0x67, 0xA5, 0x65, 0x64, 0xA4,
                0x6C, 0xAC, 0xAD, 0x6D, 0xAF, 0x6F, 0x6E, 0xAE, 0xAA, 0x6A, 0x6B, 0xAB,
                0x69, 0xA9, 0xA8, 0x68, 0x78, 0xB8, 0xB9, 0x79, 0xBB, 0x7B, 0x7A, 0xBA,
                0xBE, 0x7E, 0x7F, 0xBF, 0x7D, 0xBD, 0xBC, 0x7C, 0xB4, 0x74, 0x75, 0xB5,
                0x77, 0xB7, 0xB6, 0x76, 0x72, 0xB2, 0xB3, 0x73, 0xB1, 0x71, 0x70, 0xB0,
                0x50, 0x90, 0x91, 0x51, 0x93, 0x53, 0x52, 0x92, 0x96, 0x56, 0x57, 0x97,
                0x55, 0x95, 0x94, 0x54, 0x9C, 0x5C, 0x5D, 0x9D, 0x5F, 0x9F, 0x9E, 0x5E,
                0x5A, 0x9A, 0x9B, 0x5B, 0x99, 0x59, 0x58, 0x98, 0x88, 0x48, 0x49, 0x89,
                0x4B, 0x8B, 0x8A, 0x4A, 0x4E, 0x8E, 0x8F, 0x4F, 0x8D, 0x4D, 0x4C, 0x8C,
                0x44, 0x84, 0x85, 0x45, 0x87, 0x47, 0x46, 0x86, 0x82, 0x42, 0x43, 0x83,
                0x41, 0x81, 0x80, 0x40,
            };

        #endregion CRC16校验表

    }
}