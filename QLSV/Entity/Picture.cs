﻿using System;
using System.Drawing;
using System.IO;

namespace QLSV.Entity
{
    class Picture
    {
        public Image Content { get; set; }

        public Picture()
        {

        }
        public Picture(Image content)
        {
            try
            {
                Content = content;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public byte[] toByteArray()
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                byte[] image = (byte[])converter.ConvertTo(Content, typeof(byte[]));
                return image;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Image ByteArrToImage(byte[] arr)
        {
            try
            {
                MemoryStream stream = new MemoryStream(arr);
                Image image = Image.FromStream(stream);
                return image;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
