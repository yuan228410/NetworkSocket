﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSocket.Util
{
    /// <summary>
    /// GZip
    /// </summary>
    public static class GZip
    {
        /// <summary>
        /// Gzip压缩
        /// </summary>
        /// <param name="buffer">数据</param>        
        /// <returns></returns>
        public static byte[] Compress(byte[] buffer)
        {
            return GZip.Compress(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Gzip压缩
        /// </summary>
        /// <param name="buffer">数据</param>
        /// <param name="offset">偏移量</param>
        /// <param name="length">长度</param>
        /// <returns></returns>
        public static byte[] Compress(byte[] buffer, int offset, int length)
        {
            if (buffer == null || buffer.Length == 0)
            {
                return buffer;
            }

            using (var stream = new MemoryStream())
            {
                using (var zipStream = new GZipStream(stream, CompressionMode.Compress, true))
                {
                    zipStream.Write(buffer, 0, buffer.Length);
                }
                return stream.ToArray();
            }
        }
    }
}